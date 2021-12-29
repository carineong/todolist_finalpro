using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Data.SQLite;
using ComponentFactory.Krypton.Toolkit;

namespace todolist_finalpro_framework
{
    public delegate List<T> Query<T>(SQLiteConnection conn, Dictionary<string, object> cond, int not_delete = 1);
    public partial class MainForm : KryptonForm
    {
        // table format :  desc, category, ddl, day left, status
        public Database my_db;
        public SQLiteConnection sqlite_conn;
        public string[] preset_profiles = {"Study", "Personal", "Work", "Errands", "Others" };
        public string[] preset_categories = {""};
        public string[] status = { "Pending", "In Progress", "Completed" };

        ListProfile profiles = new ListProfile();
        ListCategory categories = new ListCategory();
        ListToDo currentTaskList = new ListToDo();

        int currentProfile, currentStatus, currentCategory;

        public Query<ToDoModel> QueryToDo;
        public Query<Profile> QueryProfile;
        public Query<Category> QueryCategory;

        public MainForm()
        {
            InitializeComponent();
            gridToDo.EnableHeadersVisualStyles = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            my_db = new Database();
            sqlite_conn = my_db.CreateConnection("Bob"); //数据库名字，若过后要实行user制度，可以每个user一个database

            QueryToDo = my_db.QueryToDo;
            QueryProfile = my_db.QueryProfile;
            QueryCategory = my_db.QueryCategory;


            bool create_table = my_db.CreateTable(sqlite_conn); //若true，则初次创建；若false，则已经存在该表格
            if (create_table)
            {
                my_db.InsertProfile(sqlite_conn, preset_profiles);
                for(int i = 1; i <= 5; i++)
                {
                    my_db.InsertCategory(sqlite_conn, preset_categories, Enumerable.Repeat<int>(i, preset_categories.Length).ToArray());
                }       
            }
            profiles.profiles = QueryProfile(sqlite_conn, new Dictionary<string, object> { });

            // init globals
            currentProfile = 0;
            currentCategory = -1;
            currentStatus = -1;

            // init calendar
            monthCalendar.TodayDate = DateTime.Today;
            monthCalendar.SelectionStart = monthCalendar.SelectionEnd = monthCalendar.TodayDate;
            currentTaskList.todos = QueryToDo(sqlite_conn, new Dictionary<string, object> { });
 
            foreach (var pro in profiles.profiles)
            {
                comboProfile.Items.Add(pro.desc);
            }
            comboProfile.Text = profiles[1]; //不确定


            InitCategories();
            ((DataGridViewComboBoxColumn)gridToDo.Columns["columnStatus"]).Items.AddRange(status);
            ((DataGridViewComboBoxColumn)gridToDo.Columns["columnStatus"]).FlatStyle = FlatStyle.Flat;
            ((DataGridViewComboBoxColumn)gridToDo.Columns["columnCategory"]).FlatStyle = FlatStyle.Flat;



            RefreshTable(InitCondition());

        }
        private void InitCategories()
        {
            categories.categories = QueryCategory(sqlite_conn, new Dictionary<string, object> { {"Profile", currentProfile}});
            comboAddTask.Items.Clear();
            comboCategory.Items.Clear();
            ((DataGridViewComboBoxColumn)gridToDo.Columns["columnCategory"]).Items.Clear();
            foreach (var cat in categories.categories)
            {
                if (cat.desc == "") continue;
                comboAddTask.Items.Add(cat.desc);
                ((DataGridViewComboBoxColumn)gridToDo.Columns["columnCategory"]).Items.Add(cat.desc);

            }
            comboAddTask.Text = "";

            comboCategory.Items.Add("All");
            foreach (var cat in categories.categories)
            {
                if (cat.desc == "") continue;
                comboCategory.Items.Add(cat.desc);

            }
            comboCategory.Text = "All";
        }
        private Dictionary<string, object> InitCondition()
        {
            var cond = new Dictionary<string, object> { { "Profile", currentProfile } };
            if (currentStatus != -1)
            {
                cond.Add("Status", currentStatus);
            }
            if (currentCategory != -1)
            {
                cond.Add("CategoryID", currentCategory);
            }
            return cond;
        }
        private void RefreshTable(Dictionary<string, object> cond)
        {
            currentTaskList.todos = QueryToDo(sqlite_conn, cond);
            gridToDo.Rows.Clear();
            gridToDo.Refresh();

            int cnt = 0;
            foreach (ToDoModel todo in currentTaskList.todos)
            {
                gridToDo.Rows.Add();
                gridToDo.AutoGenerateColumns = true;
                gridToDo.Rows[cnt].Cells[0].Value = todo.desc; 
                gridToDo.Rows[cnt].Cells[1].Value = categories[todo.category]; 
                gridToDo.Rows[cnt].Cells[2].Value = todo.end.ToString("yyyy-MM-dd");
                if (todo.end < DateTime.Today)
                {
                    if (todo.status == 2) // Completed
                    {
                        gridToDo.Rows[cnt].Cells[3].Value = "0";
                    }
                    else
                    {
                        gridToDo.Rows[cnt].Cells[3].Value = "Overdue";
                    }
                }
                else
                {
                    gridToDo.Rows[cnt].Cells[3].Value = (todo.end - DateTime.Today).ToString("dd");
                }
                gridToDo.Rows[cnt].Cells[4].Value = status[todo.status];
                gridToDo.Rows[cnt].Cells[5].Value = todo.id;
                cnt++;
            }
            gridToDo.Focus();
        }


        private void btnAll_Click(object sender, EventArgs e)
        {
            currentStatus = -1;
            RefreshTable(InitCondition());
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            currentStatus = 0;
            RefreshTable(InitCondition());
        }

        private void btnInProgress_Click(object sender, EventArgs e)
        {
            currentStatus = 1;
            RefreshTable(InitCondition());
        }

        private void btnCompleted_Click(object sender, EventArgs e)
        {
            currentStatus = 2;
            RefreshTable(InitCondition());
        }

        // add new task to database
        private void btnEnterTask_Click(object sender, EventArgs e)
        {
            ToDoModel new_todo = new ToDoModel();
            if(txtAddTask.Text == "")
            {
                MessageBox.Show("Please enter a valid description");
                return;
            }
            new_todo.desc = txtAddTask.Text;
            new_todo.category = categories[comboAddTask.Text];
            new_todo.start = DateTime.Today;
            new_todo.end = datePickerEnd.Value;
            new_todo.status = 0;
            new_todo.profile = currentProfile;
            new_todo.prior = 0;
            my_db.InsertNewToDo(sqlite_conn, new_todo);
            RefreshTable(InitCondition());
        }

        // do something when selected date in calendar changed, i.e show ddl after selected date
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            // calendar里的selected date改了以后在这里写代码
            //Debug.WriteLine($"DataType: {e.Start.GetType()}, Date Changed: Start =  " +
            //            e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString());
            List<DateTime> selectedDateRange = new List<DateTime> { e.Start, e.End };
            Debug.Write("Date changed");
            var cond = InitCondition();
            cond.Add("EndDate", selectedDateRange);
            RefreshTable(cond);
        }

        private void comboProfile_SelectedValueChanged(object sender, EventArgs e)
        {
            currentProfile = profiles[comboProfile.Text];
            InitCategories();
            RefreshTable(InitCondition());
        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(gridToDo.CurrentCell == null)
            {
                MessageBox.Show("Please select a task");
                return;
            }
            int row_ind = gridToDo.CurrentCell.RowIndex;
            int data_id = Convert.ToInt32(gridToDo[5, row_ind].Value);
            var cond = InitCondition();
            cond.Add("Deleted", 1);
            my_db.UpdateToDo(sqlite_conn, cond, data_id);
            gridToDo.Focus();
        }

        private void buttonCategory_Click(object sender, EventArgs e)
        {
            gridToDo.Focus();
            var f = new CategoryForm(my_db, sqlite_conn, currentProfile);
            f.ShowDialog();
            InitCategories();
            RefreshTable(InitCondition());

        }

        private void buttonPomodoro_Click(object sender, EventArgs e)
        {
            gridToDo.Focus();
            var f = new PomodoroForm(currentProfile);
            f.ShowDialog();
        }

        private void comboCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            currentCategory = comboCategory.Text == "All" ? -1 : categories[comboCategory.Text];
            var cond = InitCondition();
            RefreshTable(cond);
        }

        private void gridToDo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int col_ind = gridToDo.CurrentCell.ColumnIndex;
            int row_ind = gridToDo.CurrentCell.RowIndex;
            int data_id = Convert.ToInt32(gridToDo[5, row_ind].Value);
            var cond = new Dictionary<string, object> { { "Profile", currentProfile } };

            switch (col_ind)
            {
                case 0:
                    //string desc = Convert.ToString(gridToDo.Rows[row_ind].Cells[1].Value);
                    var description = gridToDo[col_ind, row_ind].Value;
                    cond.Add("Description", Convert.ToString(description));
                    my_db.UpdateToDo(sqlite_conn, cond, data_id);
                    RefreshTable(InitCondition());
                    break;
                case 1:
                    //Debug.WriteLine(Convert.ToString(gridToDo[col_ind, row_ind].Value));
                    string category = (Convert.ToString(gridToDo[col_ind, row_ind].Value));
                    //int ind = Array.IndexOf(categories, category);
                    int ind = categories[category];
                    //if (ind < 0) MessageBox.Show("Category does not exist!");
                    cond.Add("CategoryID", ind);
                    my_db.UpdateToDo(sqlite_conn, cond, data_id);
                    //RefreshTable(InitCondition());
                    break;
                case 2:
                    DateTime endDate;
                    try
                    {
                        endDate = Convert.ToDateTime(gridToDo[col_ind, row_ind].Value);
                        //在database改
                        cond.Add("EndDate", endDate);
                        my_db.UpdateToDo(sqlite_conn, cond, data_id);
                        RefreshTable(InitCondition());
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Wrong end date format!");
                    }
                    break;
                case 4:
                    string stat = Convert.ToString(gridToDo[col_ind, row_ind].Value);
                    ind = Array.IndexOf(status, stat);
                    if (ind < 0) MessageBox.Show("Status does not exist!");
                    cond.Add("Status", ind);
                    my_db.UpdateToDo(sqlite_conn, cond, data_id);
                    break;

            }
            
        }
    }
}

/* ================================ Database operations =================================
; 取得所有todo，没有条件限制
; getCurrent = my_db.QueryToDo(sqlite_conn, new Dictionary<string, object> { });

; 有条件的取得todo, 可以多重
; Dictionary<string, object> cond = new Dictionary<string, object> { };

; 根据done status
; cond.Add("Done", 0);

; 根据类型
; cond.Add("CategoryID", catogeries_id["Other"]);

; 根据开始时间段（可以都是同一天或指定的时间段）
; cond.Add("StartDate", new List<DateTime> { DateTime.Now.AddDays(-1), DateTime.Now.AddDays(-1) });

; 根据预定结束时间段（可以都是同一天或指定的时间段）
; cond.Add("EndDate", new List<DateTime> { DateTime.Now, DateTime.Now.AddDays(25) });


; List<ToDoModel> getCurrent = my_db.QueryToDo(sqlite_conn, cond);
; Debug.WriteLine(getCurrent.Count);
; foreach (ToDoModel todo in getCurrent)
; {
;     Debug.WriteLine($"id: {todo.ID}, Desc: {todo.Description}, Category: {categories[todo.Category-1]}, Start: {todo.Start.ToShortDateString()}, " +
;                     $"End: {todo.End.ToShortDateString()}, Done: {todo.Done}\n");
; }

; 更新原本的todo
; 先显示全部的todo

; Dictionary<string, object> update_cond = new Dictionary<string, object> { };
; update_cond.Add("Description", "Project X PPT");
; update_cond.Add("Done", 0);
; update_cond.Add("StartDate", DateTime.Now.AddDays(-4));
; update_cond.Add("EndDate", DateTime.Now.AddDays(7));
; update_cond.Add("CategoryID", categories_id["Work"]);
; my_db.UpdateToDo(sqlite_conn, update_cond, getCurrent[1].ID);

; getCurrent = my_db.QueryToDo(sqlite_conn, new Dictionary<string, object> { });
; Debug.WriteLine(getCurrent.Count);
========================================================================================*/