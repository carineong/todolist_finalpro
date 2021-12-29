using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using ComponentFactory.Krypton.Toolkit;

namespace todolist_finalpro_framework
{
    public partial class CategoryForm : KryptonForm
    {
        int currentProfile = 0;
        public Database myDatabase;
        public SQLiteConnection sqliteConn;
        List<Category> categories = new List<Category> { };
        public Query<Category> QueryCategory;
        public Query<ToDoModel> QueryToDo;

        public CategoryForm(Database db, SQLiteConnection sq, int p)
        {
            InitializeComponent();
            myDatabase = db;
            sqliteConn = sq;
            currentProfile = p;
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            QueryCategory = myDatabase.QueryCategory;
            QueryToDo = myDatabase.QueryToDo;
            textBoxAdd.GotFocus += textBoxAdd_GotFocus;
            RefreshTable();
        }
        
        // 当用户Focus 时清除预设的文字
        private void textBoxAdd_GotFocus(object sender, EventArgs e)
        {
            textBoxAdd.Text = "";
        }

        // 刷新GridView 界面
        private void RefreshTable()
        {
            categories = QueryCategory(sqliteConn, new Dictionary<string, object> { {"Profile",currentProfile}});
            gridCategory.Rows.Clear();
            gridCategory.Refresh();

            // GridView 相关Styling
            foreach (DataGridViewColumn col in gridCategory.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
                col.DefaultCellStyle.ForeColor = Color.White;
            }

            // 显示当前Profile 的所有Category
            int cnt = 0;
            foreach (Category cat in categories)
            {
                if (cat.desc == "") continue;
                gridCategory.Rows.Add();
                gridCategory.AutoGenerateColumns = true;
                gridCategory.Rows[cnt].Cells[0].Style.ForeColor = MyColour.categories[cat.id % MyColour.categories.Length];
                gridCategory.Rows[cnt].Cells[0].Value = cat.desc;
                gridCategory.Rows[cnt].Cells[1].Value = cat.id;
                cnt++;
            }
            gridCategory.Focus();
        }

        // 增加新的Category
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string cat = textBoxAdd.Text;
            if(cat == "")
            {
                MessageBox.Show("Please enter valid category");
                return;
            }
            foreach(Category c in categories)
            {
                if(cat == c.desc)
                {
                    MessageBox.Show("Category already existed");
                    return;
                }
            }
            myDatabase.InsertCategory(sqliteConn, new string[] { cat }, new int[] { currentProfile });
            RefreshTable();
        }

        // 删除旧的Category，且该Category下的所有原To-do 任务被分配成无标签
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridCategory.CurrentCell == null)
            {
                MessageBox.Show("Please select a task");
                return;
            }
            int row_ind = gridCategory.CurrentCell.RowIndex;
            string type = gridCategory[0, row_ind].Value.ToString();
            int data_id = Convert.ToInt32(gridCategory[1, row_ind].Value);
            var cond = new Dictionary<string, object> { { "Profile", currentProfile }, { "Type", type }, { "Deleted", 1 } };
            myDatabase.UpdateProfile_Category(sqliteConn, "Category", cond, data_id);

            // 该Category下的所有原To-do 任务被分配成无标签
            List<ToDoModel> catTaskList = new List<ToDoModel>();
            catTaskList = QueryToDo(sqliteConn, new Dictionary<string, object> { { "CategoryID", data_id } });
            cond = new Dictionary<string, object> { { "CategoryID", 1 } }; // CategoryID = 1 默认为无标签
            foreach (ToDoModel todo in catTaskList)
            {
                myDatabase.UpdateToDo(sqliteConn, cond, todo.id);
            }
            RefreshTable();
        }
    }
}
