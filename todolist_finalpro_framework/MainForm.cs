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
        public Database my_db;
        public SQLiteConnection sqlite_conn;
        public string[] categories = { "Personal", "Study", "Work", "Errands", "Other" };
        public Dictionary<string, int> categories_id;
        public MainForm()
        {
            InitializeComponent();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            // calendar里的selected date改了以后在这里写代码
            Debug.WriteLine($"DataType: {e.Start.GetType()}, Date Changed: Start =  " +
                        e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            my_db = new Database();
            sqlite_conn = my_db.CreateConnection("Alice"); //数据库名字，若过后要实行user制度，可以每个user一个database
            bool create_table = my_db.CreateTable(sqlite_conn); //若true，则初次创建；若false，则已经存在该表格
            if (create_table)
            {
                my_db.InsertCategory(sqlite_conn, categories);
            }

            categories_id = my_db.GetCategoryID(sqlite_conn);

            // *增加todo操作
            //ToDoModel new_todo = new ToDoModel();
            //new_todo.Description = "Testing 1";
            //new_todo.Category = categories_id["Personal"];
            //new_todo.Start = DateTime.Now;
            //new_todo.End = new_todo.Start.AddDays(5);
            //new_todo.Done = 0;
            //my_db.InsertNewToDo(sqlite_conn, new_todo);

            // *取得所有todo，没有条件限制
            //List<ToDoModel> getCurrent =  my_db.QueryToDo(sqlite_conn, new Dictionary<string, object> { }); 

            // *有条件的取得todo, 可以多重
            //Dictionary<string, object> cond = new Dictionary<string, object> { };

            // 根据done status
            //cond.Add("Done", 0);

            // 根据类型
            //cond.Add("CategoryID", catogeries_id["Other"]);

            //根据开始时间段（可以都是同一天或指定的时间段）
            //cond.Add("StartDate", new List<DateTime> { DateTime.Now.AddDays(-1), DateTime.Now.AddDays(-1) });

            //根据预定结束时间段（可以都是同一天或指定的时间段）
            //cond.Add("EndDate", new List<DateTime> { DateTime.Now, DateTime.Now.AddDays(25) });


            //List<ToDoModel> getCurrent = my_db.QueryToDo(sqlite_conn, cond);
            //Debug.WriteLine(getCurrent.Count);
            //foreach (ToDoModel todo in getCurrent)
            //{
            //    Debug.WriteLine($"id: {todo.ID}, Desc: {todo.Description}, Category: {categories[todo.Category-1]}, Start: {todo.Start.ToShortDateString()}, " +
            //                    $"End: {todo.End.ToShortDateString()}, Done: {todo.Done}\n");
            //}

            // *更新原本的todo
            //Dictionary<string, object> update_cond = new Dictionary<string, object> { };
            //update_cond.Add("Description", "Project X PPT");
            //update_cond.Add("Done", 0);
            //update_cond.Add("StartDate", DateTime.Now.AddDays(-4));
            //update_cond.Add("EndDate", DateTime.Now.AddDays(7));
            //update_cond.Add("CategoryID", categories_id["Work"]);
            //my_db.UpdateToDo(sqlite_conn, update_cond, getCurrent[1].ID);

            //getCurrent = my_db.QueryToDo(sqlite_conn, new Dictionary<string, object> { });
            ////Debug.WriteLine(getCurrent.Count);
            //foreach (ToDoModel todo in getCurrent)
            //{
            //    Debug.WriteLine($"id: {todo.ID}, Desc: {todo.Description}, Category: {categories[todo.Category-1]}, Start: {todo.Start.ToShortDateString()}, " +
            //                    $"End: {todo.End.ToShortDateString()}, Done: {todo.Done}\n");
            //}


        }
    }
}
