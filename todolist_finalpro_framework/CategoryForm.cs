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
        public Database my_db;
        public SQLiteConnection sqlite_conn;
        List<Category> categories = new List<Category> { };
        public Query<Category> QueryCategory;
        public Query<ToDoModel> QueryToDo;

        public CategoryForm(Database db, SQLiteConnection sq, int p)
        {
            InitializeComponent();
            my_db = db;
            sqlite_conn = sq;
            currentProfile = p;
        }
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            QueryCategory = my_db.QueryCategory;
            QueryToDo = my_db.QueryToDo;
            textBoxAdd.GotFocus += textBoxAdd_GotFocus;
            RefreshTable();
        }
        private void textBoxAdd_GotFocus(object sender, EventArgs e)
        {
            textBoxAdd.Text = "";
        }
        private void RefreshTable()
        {
            categories = QueryCategory(sqlite_conn, new Dictionary<string, object> { {"Profile",currentProfile}});
            gridCategory.Rows.Clear();
            gridCategory.Refresh();

            foreach (DataGridViewColumn col in gridCategory.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.DefaultCellStyle.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
                col.DefaultCellStyle.ForeColor = Color.White;
            }

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
            my_db.InsertCategory(sqlite_conn, new string[] { cat }, new int[] { currentProfile });
            RefreshTable();
        }

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
            my_db.UpdateProfile_Category(sqlite_conn, "Category", cond, data_id);

            List<ToDoModel> catTaskList = new List<ToDoModel>();
            catTaskList = QueryToDo(sqlite_conn, new Dictionary<string, object> { { "CategoryID", data_id } });
            cond = new Dictionary<string, object> { { "CategoryID", 1 } };
            foreach (ToDoModel todo in catTaskList)
            {
                my_db.UpdateToDo(sqlite_conn, cond, todo.id);
            }
            RefreshTable();
        }
    }
}
