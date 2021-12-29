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
        public Database myDatabase;
        public SQLiteConnection sqliteConn;
        public string[] presetProfiles = {"Study", "Personal", "Work", "Errands", "Others" };
        public string[] presetCategories = {""};
        public string[] status = { "Pending", "In Progress", "Completed" };
        public string[] priorityDisplay = { "☆", "★" };

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
            myDatabase = new Database();
            sqliteConn = myDatabase.CreateConnection("Bob"); // 数据库名字，若过后要实行user制度，可以每个user一个database
            
            // 注册+委托
            QueryToDo = myDatabase.QueryToDo;
            QueryProfile = myDatabase.QueryProfile;
            QueryCategory = myDatabase.QueryCategory;
            txtAddTask.GotFocus += txtAddTask_GotFocus;

            if (myDatabase.CreateTable(sqliteConn)) // 若true，则初次创建；若false，则已经存在该表格
            {
                myDatabase.InsertProfile(sqliteConn, presetProfiles);
                for(int i = 1; i <= presetProfiles.Length; i++)
                {
                    myDatabase.InsertCategory(sqliteConn, presetCategories, Enumerable.Repeat<int>(i, presetCategories.Length).ToArray());
                }       
            }
            profiles.profiles = QueryProfile(sqliteConn, new Dictionary<string, object> { });

            // 初始化全局数据（GridView里要展示什么Data）
            currentProfile = 0;
            currentCategory = -1;
            currentStatus = -1;
            currentTaskList.todos = QueryToDo(sqliteConn, new Dictionary<string, object> { });

            // 初始化日历控件
            monthCalendar.TodayDate = DateTime.Today;
            monthCalendar.SelectionStart = monthCalendar.SelectionEnd = monthCalendar.TodayDate;
            datePickerEnd.CalendarTodayDate = DateTime.Today;
            
            // 初始化Profile选取栏
            foreach (var pro in profiles.profiles)
            {
                comboProfile.Items.Add(pro.desc);
            }
            comboProfile.Text = profiles[1]; //不确定

            
            // 初始化Category选取栏
            InitCategories();

            // GridView 设置一些特殊column 的外表
            ((DataGridViewComboBoxColumn)gridToDo.Columns["columnStatus"]).Items.AddRange(status);
            ((DataGridViewComboBoxColumn)gridToDo.Columns["columnStatus"]).FlatStyle = FlatStyle.Flat;
            ((DataGridViewComboBoxColumn)gridToDo.Columns["columnCategory"]).FlatStyle = FlatStyle.Flat;

           
            // 这是为了设置button 中的星星， 尤其注意设置的font 和default 有关系，可以适当改 
            ((DataGridViewButtonColumn)gridToDo.Columns["columnPriority"]).FlatStyle = FlatStyle.Popup;
            ((DataGridViewButtonColumn)gridToDo.Columns["columnPriority"]).DefaultCellStyle.Font =
                new Font("Times New Roman", gridToDo.DefaultCellStyle.Font.Size * 2, FontStyle.Regular);
            RefreshTable(InitCondition());
        }
        private void InitCategories()
        {
            // 从Database 中读出所有的categories
            categories.categories = QueryCategory(sqliteConn, new Dictionary<string, object> { {"Profile", currentProfile}});

            // 在Combobox 控件中添加相应的category
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

        // 生成SQL 查询的基本条件 
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

        // 刷新To-do任务GridView
        private void RefreshTable(Dictionary<string, object> cond)
        {
            currentTaskList.todos = QueryToDo(sqliteConn, cond);
            try
            {
                // 如果用户在修改GridView 以后立刻Focus到别的 Cell，此时Clear 会出现Reentrant 错误
                gridToDo.Rows.Clear();
            }
            catch
            {
                return;
            }
            gridToDo.Refresh();

            // GridView 的Styling
            foreach (DataGridViewColumn col in gridToDo.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                if (col.HeaderText == "Priority") continue;
                col.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
                col.DefaultCellStyle.ForeColor = Color.White;
            }

            // 先显示优先级高的
            int cnt = 0;
            foreach (ToDoModel todo in currentTaskList.todos)
            {
                if (todo.prior == 0) continue;
                gridToDo.Rows.Add();
                gridToDo.AutoGenerateColumns = true;
                if(todo.prior == 1)
                {
                    gridToDo.Rows[cnt].Cells[0].Value = priorityDisplay[1];
                    gridToDo.Rows[cnt].Cells[0].Style.ForeColor = Color.Yellow;
                }
                else
                {
                    gridToDo.Rows[cnt].Cells[0].Value = priorityDisplay[0];
                    gridToDo.Rows[cnt].Cells[0].Style.ForeColor = Color.White;
                }
                
                gridToDo.Rows[cnt].Cells[1].Value = todo.desc;

                gridToDo.Rows[cnt].Cells[2].Style.ForeColor = MyColour.categories[todo.category % MyColour.categories.Length];
                gridToDo.Rows[cnt].Cells[2].Value = categories[todo.category]; 
                gridToDo.Rows[cnt].Cells[3].Value = todo.end.ToString("yyyy-MM-dd");
                if (todo.end < DateTime.Today)
                {
                    if (todo.status == 2) // Completed
                    {
                        gridToDo.Rows[cnt].Cells[4].Value = "0";
                    }
                    else
                    {
                        gridToDo.Rows[cnt].Cells[4].Value = "exp";
                    }
                }
                else
                {
                    gridToDo.Rows[cnt].Cells[4].Value = (todo.end - DateTime.Today).TotalDays;
                }
                gridToDo.Rows[cnt].Cells[5].Value = status[todo.status];
                gridToDo.Rows[cnt].Cells[6].Value = todo.id;
                cnt++;
            }

            // 再显示优先级低的
            foreach (ToDoModel todo in currentTaskList.todos)
            {
                if (todo.prior == 1) continue;
                gridToDo.Rows.Add();
                gridToDo.AutoGenerateColumns = true;
                if (todo.prior == 1)
                {
                    gridToDo.Rows[cnt].Cells[0].Value = priorityDisplay[1];
                    gridToDo.Rows[cnt].Cells[0].Style.ForeColor = Color.Yellow;
                }
                else
                {
                    gridToDo.Rows[cnt].Cells[0].Value = priorityDisplay[0];
                    gridToDo.Rows[cnt].Cells[0].Style.ForeColor = Color.White;
                }

                gridToDo.Rows[cnt].Cells[1].Value = todo.desc;

                gridToDo.Rows[cnt].Cells[2].Style.ForeColor = MyColour.categories[todo.category % MyColour.categories.Length];
                gridToDo.Rows[cnt].Cells[2].Value = categories[todo.category];
                gridToDo.Rows[cnt].Cells[3].Value = todo.end.ToString("yyyy-MM-dd");
                if (todo.end < DateTime.Today)
                {
                    if (todo.status == 2) // Completed
                    {
                        gridToDo.Rows[cnt].Cells[4].Value = "0";
                    }
                    else
                    {
                        gridToDo.Rows[cnt].Cells[4].Value = "exp";
                    }
                }
                else
                {
                    gridToDo.Rows[cnt].Cells[4].Value = (todo.end - DateTime.Today).TotalDays;
                }
                gridToDo.Rows[cnt].Cells[5].Value = status[todo.status];
                gridToDo.Rows[cnt].Cells[6].Value = todo.id;
                cnt++;
            }
            gridToDo.Focus();
        }

        // 显示所有To-do 任务
        private void btnAll_Click(object sender, EventArgs e)
        {
            currentStatus = -1;
            RefreshTable(InitCondition());
        }

        // 显示还没开始做的To-do 任务
        private void btnPending_Click(object sender, EventArgs e)
        {
            currentStatus = 0;
            RefreshTable(InitCondition());
        }

        // 显示正在进行中的To-do 任务
        private void btnInProgress_Click(object sender, EventArgs e)
        {
            currentStatus = 1;
            RefreshTable(InitCondition());
        }

        // 显示已完成的To-do 任务
        private void btnCompleted_Click(object sender, EventArgs e)
        {
            currentStatus = 2;
            RefreshTable(InitCondition());
        }

        // 增添新的To-do 任务
        private void btnEnterTask_Click(object sender, EventArgs e)
        {
            ToDoModel new_todo = new ToDoModel();
            if(txtAddTask.Text == "") // 保卫语句
            {
                MessageBox.Show("Please enter a valid description");
                return;
            }
            new_todo.desc = txtAddTask.Text;
            new_todo.category = categories[comboAddTask.Text]; // 注意 Category 可以为空（不设类型）
            new_todo.start = DateTime.Today;
            new_todo.end = datePickerEnd.Value;
            new_todo.status = 0;
            new_todo.profile = currentProfile;
            new_todo.prior = 0;
            myDatabase.InsertNewToDo(sqliteConn, new_todo);
            RefreshTable(InitCondition());
        }

        // 删除To-do 任务
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (gridToDo.CurrentCell == null)
            {
                MessageBox.Show("Please select a task");
                return;
            }
            int row_ind = gridToDo.CurrentCell.RowIndex;
            int data_id = Convert.ToInt32(gridToDo[6, row_ind].Value);
            var cond = InitCondition();
            cond.Add("Deleted", 1); // 不直接从Database 中删除，以便之后还可以恢复
            myDatabase.UpdateToDo(sqliteConn, cond, data_id);
            RefreshTable(InitCondition());
        }

        // 增加新的Category or 删除旧的Category
        private void buttonCategory_Click(object sender, EventArgs e)
        {
            gridToDo.Focus();
            var f = new CategoryForm(myDatabase, sqliteConn, currentProfile);
            f.ShowDialog();
            InitCategories();
            RefreshTable(InitCondition());

        }

        // 使用番茄钟小工具，完成任务
        private void buttonPomodoro_Click(object sender, EventArgs e)
        {
            gridToDo.Focus();
            var f = new PomodoroForm(currentProfile);
            f.ShowDialog();
        }

        // 只处理点击Priority 星星的 Cell， 设置任务的优先级
        private void gridToDo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == gridToDo.Columns["columnPriority"].Index)
            {
                if (e.RowIndex == -1) return;
                // 从 not priority 设置成 priority
                if (gridToDo.Rows[e.RowIndex].Cells[0].Value.ToString() == priorityDisplay[0])
                {
                    gridToDo.Rows[e.RowIndex].Cells[0].Value = priorityDisplay[1]; // display
                    var cond = new Dictionary<string, object> { { "Profile", currentProfile } };
                    int data_id = Convert.ToInt32(gridToDo[6, e.RowIndex].Value);
                    cond.Add("Priority", 1);
                    myDatabase.UpdateToDo(sqliteConn, cond, data_id);
                }
                //从 priority 设置成 not priority
                else
                {
                    gridToDo.Rows[e.RowIndex].Cells[0].Value = priorityDisplay[0];
                    var cond = new Dictionary<string, object> { { "Profile", currentProfile } };
                    int data_id = Convert.ToInt32(gridToDo[6, e.RowIndex].Value);
                    cond.Add("Priority", 0);
                    myDatabase.UpdateToDo(sqliteConn, cond, data_id);
                }
                RefreshTable(InitCondition());
            }
        }

        // Calendar 控件：显示指定日期以后ddl 的所有任务
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            List<DateTime> selectedDateRange = new List<DateTime> { e.Start, e.End };
            Debug.Write("Date changed");
            var cond = InitCondition();
            cond.Add("EndDate", selectedDateRange);
            RefreshTable(cond);
        }

        // 切换Profile
        private void comboProfile_SelectedValueChanged(object sender, EventArgs e)
        {
            currentProfile = profiles[comboProfile.Text];
            InitCategories();
            RefreshTable(InitCondition());
        }

        // 只显示选定Category 的To-do 任务
        private void comboCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            currentCategory = comboCategory.Text == "All" ? -1 : categories[comboCategory.Text];
            var cond = InitCondition();
            RefreshTable(cond);
        }

        // 直接从GridView 中修改To-do 任务的相关信息，并同步到数据库中
        private void gridToDo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int col_ind = gridToDo.CurrentCell.ColumnIndex;
            int row_ind = gridToDo.CurrentCell.RowIndex;
            int data_id = Convert.ToInt32(gridToDo[6, row_ind].Value);
            var cond = new Dictionary<string, object> { { "Profile", currentProfile } };

            switch (col_ind)
            {
                case 1: // Column = Description
                    var description = gridToDo[col_ind, row_ind].Value;
                    cond.Add("Description", Convert.ToString(description));
                    myDatabase.UpdateToDo(sqliteConn, cond, data_id);
                    break;
                case 2: // Column = Category
                    string category = (Convert.ToString(gridToDo[col_ind, row_ind].Value));
                    int ind = categories[category];
                    cond.Add("CategoryID", ind);
                    myDatabase.UpdateToDo(sqliteConn, cond, data_id);
                    gridToDo.Rows[row_ind].Cells[2].Style.ForeColor = MyColour.categories[ind % MyColour.categories.Length];
                    break;
                case 3: // Column = Date End
                    DateTime endDate;
                    try
                    {
                        endDate = Convert.ToDateTime(gridToDo[col_ind, row_ind].Value);
                        //在database改
                        cond.Add("EndDate", endDate);
                        myDatabase.UpdateToDo(sqliteConn, cond, data_id);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Wrong end date format!");
                    }
                    break;
                case 5: // Column = Status
                    string stat = Convert.ToString(gridToDo[col_ind, row_ind].Value);
                    ind = Array.IndexOf(status, stat);
                    if (ind < 0) MessageBox.Show("Status does not exist!");
                    cond.Add("Status", ind);
                    myDatabase.UpdateToDo(sqliteConn, cond, data_id);
                    break;
            }
            RefreshTable(InitCondition());
        }

        // 为了在用户点击时清除textbox 中的默认文字
        private void txtAddTask_GotFocus(object sender, EventArgs e)
        {
            txtAddTask.Text = "";
        }
    }
}

/* ================================ Database operations =================================
; 取得所有todo，没有条件限制
; getCurrent = myDatabase.QueryToDo(sqliteConn, new Dictionary<string, object> { });

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


; List<ToDoModel> getCurrent = myDatabase.QueryToDo(sqliteConn, cond);
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
; myDatabase.UpdateToDo(sqliteConn, update_cond, getCurrent[1].ID);

; getCurrent = myDatabase.QueryToDo(sqliteConn, new Dictionary<string, object> { });
; Debug.WriteLine(getCurrent.Count);
========================================================================================*/