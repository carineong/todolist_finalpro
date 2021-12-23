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
   
    public partial class MainForm : KryptonForm
    {
        // table format :  desc, category, ddl, day left, status
        public Database my_db;
        public SQLiteConnection sqlite_conn;
        public string[] profiles = {"Study", "Personal", "Work", "Errands", "Others" };
        public string[] categories = {"All","ICS", "OS", "C-sharp"};
        public string[] status = { "Pending", "In Progress", "Completed" };
        public Dictionary<string, int> profiles_id = new Dictionary<string, int> { { "Study", 0 }, { "Personal", 1 }, { "Work", 2 }, { "Errands", 3 }, { "Others", 4 } };
        public Dictionary<string, int> categories_id;
        List<ToDoModel> currentTaskList;
        int currentProfile, currentStatus, currentCategory;

        /* Restructuring Functions */
        public MainForm()
        {
            InitializeComponent();
            gridToDo.EnableHeadersVisualStyles = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            my_db = new Database();
            sqlite_conn = my_db.CreateConnection("Bob6"); //数据库名字，若过后要实行user制度，可以每个user一个database
            bool create_table = my_db.CreateTable(sqlite_conn); //若true，则初次创建；若false，则已经存在该表格
            if (create_table)
            {
                my_db.InsertCategory(sqlite_conn, categories);
            }

            // init
            currentProfile = 0;
            currentCategory = -1;
            currentStatus = -1;

            // init calendar
            monthCalendar.TodayDate = DateTime.Today;
            monthCalendar.SelectionStart = monthCalendar.SelectionEnd = monthCalendar.TodayDate;
            currentTaskList = my_db.QueryToDo(sqlite_conn, new Dictionary<string, object> { });
            categories_id = my_db.GetCategoryID(sqlite_conn);
 
            foreach (string cat in profiles)
            {
                comboProfile.Items.Add(cat);
            }
            comboProfile.Text = profiles[0];

            foreach (string cat in categories)
            {
                if (cat == "All") continue;
                comboAddTask.Items.Add(cat);
            }
            comboAddTask.Text = categories[1];

            comboCategory.Items.Add("All");
            foreach (string cat in categories)
            {
                comboCategory.Items.Add(cat);
            }
            comboCategory.Text = "All";

            RefreshTable(InitCondition());

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
            currentTaskList = my_db.QueryToDo(sqlite_conn, cond);
            gridToDo.Rows.Clear();
            gridToDo.Refresh();
            int cnt = 0;
            foreach (ToDoModel todo in currentTaskList)
            {
                gridToDo.Rows.Add();
                gridToDo.AutoGenerateColumns = true;
                gridToDo.Rows[cnt].Cells[0].Value = todo.desc; 
                gridToDo.Rows[cnt].Cells[1].Value = categories[todo.category - 1]; 
                gridToDo.Rows[cnt].Cells[2].Value = todo.end.ToString("yyyy-MM-dd"); 
                gridToDo.Rows[cnt].Cells[3].Value = (todo.end - DateTime.Today).ToString("dd"); 
                gridToDo.Rows[cnt].Cells[4].Value = status[todo.status];
                gridToDo.Rows[cnt].Cells[5].Value = todo.id;
                cnt++;
            }
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
            new_todo.desc = txtAddTask.Text;
            new_todo.category = categories_id[comboAddTask.Text];
            new_todo.start = DateTime.Today;
            new_todo.end = datePickerEnd.Value;
            new_todo.status = 0;
            new_todo.profile = currentProfile;
            my_db.InsertNewToDo(sqlite_conn, new_todo);
            RefreshTable(InitCondition());
        }

        // do something when selected date in calendar changed
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
            currentProfile = profiles_id[comboProfile.Text];
            var cond = InitCondition();
            RefreshTable(cond);
        }

        private void comboCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            currentCategory = comboCategory.Text == "All" ? -1 : categories_id[comboCategory.Text];
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
                    break;
                case 1:
                    string category = (Convert.ToString(gridToDo[col_ind, row_ind].Value));
                    int ind = Array.IndexOf(categories, category);
                    if (ind < 0) MessageBox.Show("Category does not exist!");
                    cond.Add("CategoryID", ind);
                    my_db.UpdateToDo(sqlite_conn, cond, data_id);
                    break;
                case 2:
                    DateTime endDate;
                    try
                    {
                        endDate = Convert.ToDateTime(gridToDo[col_ind, row_ind].Value);
                        //在database改
                        cond.Add("EndDate", endDate);
                        my_db.UpdateToDo(sqlite_conn, cond, data_id);
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
            RefreshTable(InitCondition());
        }
    }
}
