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
        List<ToDoModel> getCurrent;
        int addNewFlag = 0;
        public MainForm()
        {
            InitializeComponent();
            gridToDo.EnableHeadersVisualStyles = false;
            grpAddTask.Visible = false;
        }
        DateTime selectedDateStart = DateTime.Today;
        DateTime selectedDateEnd = DateTime.Today;
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            // calendar里的selected date改了以后在这里写代码
            //Debug.WriteLine($"DataType: {e.Start.GetType()}, Date Changed: Start =  " +
            //            e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString());
            selectedDateStart = e.Start;
            selectedDateEnd = e.End;
            Debug.Write("Date changed");
            string category = comboCategory.Text;
            showCategoryToDo(getCurrent, category);
            
        }
        // 可以刷新gridview
        
        // 不管日期
        private void showAll(List<ToDoModel> getCurrent)
        {

            gridToDo.Rows.Clear();
            gridToDo.Refresh();
            getCurrent = my_db.QueryToDo(sqlite_conn, new Dictionary<string, object> { });
            int counter = 0;
            foreach (ToDoModel todo in getCurrent)
            {

                gridToDo.Rows.Add();
                gridToDo.AutoGenerateColumns = true;
                gridToDo.Rows[counter].Cells[1].Value = todo.Description; // first cell
                gridToDo.Rows[counter].Cells[2].Value = categories[todo.Category - 1]; // second cell
                gridToDo.Rows[counter].Cells[3].Value = todo.Start.ToShortDateString();
                gridToDo.Rows[counter].Cells[4].Value = todo.End.ToShortDateString();
                gridToDo.Rows[counter].Cells[6].Value = todo.ID;

                if (todo.Done == 1)
                {
                    gridToDo.Rows[counter].Cells[0].Value = true;
                    gridToDo.Rows[counter].Cells[5].Value = "Complete";
                }
                else
                {
                    gridToDo.Rows[counter].Cells[0].Value = false;
                    gridToDo.Rows[counter].Cells[5].Value = "Pending";
                }
                counter++;
                
            }
        }
        
        // 实现只展示一部分category的todo
        // category用来决定什么category被展示
        private void showCategoryToDo(List<ToDoModel> getCurrent, string Category)
        {

            gridToDo.Rows.Clear();
            gridToDo.Refresh();
            getCurrent = my_db.QueryToDo(sqlite_conn, new Dictionary<string, object> { });
            int counter = 0;
            if (Category == "All")
            {
                foreach (ToDoModel todo in getCurrent)
                {

                    //Debug.WriteLine($"id: {todo.ID}, Desc: {todo.Description}, Category: {categories[todo.Category-1]}, Start: {todo.Start.ToShortDateString()}, " +
                    //                $"End: {todo.End.ToShortDateString()}, Done: {todo.Done}\n");
                    if (selectedDateStart <= todo.Start && selectedDateEnd >= todo.Start)
                    {
                        gridToDo.Rows.Add();
                        gridToDo.AutoGenerateColumns = true;
                        gridToDo.Rows[counter].Cells[1].Value = todo.Description; // first cell
                        gridToDo.Rows[counter].Cells[2].Value = categories[todo.Category - 1]; // second cell
                        gridToDo.Rows[counter].Cells[3].Value = todo.Start.ToShortDateString();
                        gridToDo.Rows[counter].Cells[4].Value = todo.End.ToShortDateString();
                        gridToDo.Rows[counter].Cells[6].Value = todo.ID;

                        if (todo.Done == 1)
                        {
                            gridToDo.Rows[counter].Cells[0].Value = true;
                            gridToDo.Rows[counter].Cells[5].Value = "Complete";
                        }
                        else
                        {
                            gridToDo.Rows[counter].Cells[0].Value = false;
                            gridToDo.Rows[counter].Cells[5].Value = "Pending";
                        }
                        counter++;
                    }
                }
            }
            foreach (ToDoModel todo in getCurrent)
            {

                //Debug.WriteLine($"id: {todo.ID}, Desc: {todo.Description}, Category: {categories[todo.Category-1]}, Start: {todo.Start.ToShortDateString()}, " +
                //                $"End: {todo.End.ToShortDateString()}, Done: {todo.Done}\n");
                if (selectedDateStart <= todo.Start && selectedDateEnd >= todo.Start && categories[todo.Category - 1] == Category)
                {
                    gridToDo.Rows.Add();
                    gridToDo.AutoGenerateColumns = true;
                    gridToDo.Rows[counter].Cells[1].Value = todo.Description; // first cell
                    gridToDo.Rows[counter].Cells[2].Value = categories[todo.Category - 1]; // second cell
                    gridToDo.Rows[counter].Cells[3].Value = todo.Start.ToShortDateString();
                    gridToDo.Rows[counter].Cells[4].Value = todo.End.ToShortDateString();
                    gridToDo.Rows[counter].Cells[6].Value = todo.ID;

                    if (todo.Done == 1)
                    {
                        gridToDo.Rows[counter].Cells[0].Value = true;
                        gridToDo.Rows[counter].Cells[5].Value = "Complete";
                    }
                    else
                    {
                        gridToDo.Rows[counter].Cells[0].Value = false;
                        gridToDo.Rows[counter].Cells[5].Value = "Pending";
                    }
                    counter++;
                }
            }
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

            

            // *取得所有todo，没有条件限制
            getCurrent =  my_db.QueryToDo(sqlite_conn, new Dictionary<string, object> { });

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
            // 先显示全部的todo
            /*
            Dictionary<string, object> update_cond = new Dictionary<string, object> { };
            update_cond.Add("Description", "Project X PPT");
            update_cond.Add("Done", 0);
            update_cond.Add("StartDate", DateTime.Now.AddDays(-4));
            update_cond.Add("EndDate", DateTime.Now.AddDays(7));
            update_cond.Add("CategoryID", categories_id["Work"]);
            my_db.UpdateToDo(sqlite_conn, update_cond, getCurrent[1].ID);
            */
            //getCurrent = my_db.QueryToDo(sqlite_conn, new Dictionary<string, object> { });
            //Debug.WriteLine(getCurrent.Count);
            
            
            foreach(string cat in categories)
            {
                comboAddTask.Items.Add(cat);
            }
            comboAddTask.Text = categories[0];

            comboCategory.Items.Add("All");
            foreach (string cat in categories)
            {
                comboCategory.Items.Add(cat);
            }
            comboCategory.Text = "All";

            showAll(getCurrent);

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            
            if (addNewFlag == 1) addNewFlag = 0;
            else addNewFlag = 1;
            if(addNewFlag == 1)
            {
                grpAddTask.Visible = true;
                btnAddNew.Text = "Cancel";
                txtAddTask.Focus();
            }
            else
            {
                grpAddTask.Visible = false;
                btnAddNew.Text = "Add Task";
                gridToDo.Focus();
            }
            //btnAddNew.BackColor = formPalette.ButtonStyles.ButtonCommon.StateCommon.Back.Color1;
            //btnAddNew.ForeColor = formPalette.ButtonStyles.ButtonCommon.StateCommon.Content.ShortText.Color1;

        }

        private void btnEnterTask_Click(object sender, EventArgs e)
        {
            // *增加todo操作
            ToDoModel new_todo = new ToDoModel();
            new_todo.Description = txtAddTask.Text;
            new_todo.Category = categories_id[comboAddTask.Text];
            new_todo.Start = datePickerStart.Value;
            new_todo.End = datePickerEnd.Value;
            new_todo.Done = 0;
            my_db.InsertNewToDo(sqlite_conn, new_todo);
            getCurrent = my_db.QueryToDo(sqlite_conn, new Dictionary<string, object> { });
            string category = comboCategory.Text;
            showCategoryToDo(getCurrent, category);
        }
        

        private void gridToDo_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine("End Edit");
            int col_ind = gridToDo.CurrentCell.ColumnIndex;
            int row_ind = gridToDo.CurrentCell.RowIndex;
            Debug.WriteLine($"{row_ind}, {col_ind}, {gridToDo[col_ind, row_ind].Value}");
            int data_id = Convert.ToInt32(gridToDo[6, row_ind].Value);
            var changes = gridToDo[col_ind,row_ind].Value;
            Dictionary<string, object> cond = new Dictionary<string, object> { };
            DialogResult dialogResult;

            switch (col_ind)
            {
                case 0: //完成与否
                    cond.Add("Done", Convert.ToInt32(changes));
                    my_db.UpdateToDo(sqlite_conn, cond, data_id);
                    if(Convert.ToInt32(changes) == 1) gridToDo[5, row_ind].Value = "Complete";
                    else gridToDo[5, row_ind].Value = "Pending";
                    break;
                case 1:
                    
                    //string desc = Convert.ToString(gridToDo.Rows[row_ind].Cells[1].Value);
                    dialogResult = MessageBox.Show("Are you sure you want to make this change?"
 
                                     ,"Changes", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //在database改
                        var description = gridToDo[col_ind, row_ind].Value;
                        cond.Add("Description", Convert.ToString(description));
                        my_db.UpdateToDo(sqlite_conn, cond, data_id);
                        
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //可以不管
                    }
                    break;
                case 2:
                    string category = (Convert.ToString(gridToDo[col_ind, row_ind].Value));
                    int ind = 0;
                    foreach(string cattest in categories)
                    {
                        if(category == cattest)
                        {
                            break;
                        }
                        ind++;
                    }
                    if(ind > categories.Length - 1)
                    {
                        MessageBox.Show("Category does not exist!");
                        break;
                    }

                    dialogResult = MessageBox.Show("Are you sure you want to make this change?"

                                     , "Changes", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //在database改
                        cond.Add("CategoryID", ind + 1);
                        my_db.UpdateToDo(sqlite_conn, cond, data_id);

                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        //可以不管
                    }


                    break;
                case 3:
                    DateTime startDate;
                    try
                    {
                        startDate = Convert.ToDateTime(gridToDo[col_ind, row_ind].Value);
                        dialogResult = MessageBox.Show("Are you sure you want to make this change?"

                                     , "Changes", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //在database改
                            cond.Add("StartDate", startDate);
                            my_db.UpdateToDo(sqlite_conn, cond, data_id);

                        }

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Wrong start date format!");
                    }
                    break;
                case 4:
                    DateTime endDate;
                    try
                    {
                        endDate = Convert.ToDateTime(gridToDo[col_ind, row_ind].Value);
                        dialogResult = MessageBox.Show("Are you sure you want to make this change?"

                                     , "Changes", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //在database改
                            cond.Add("EndDate", endDate);
                            my_db.UpdateToDo(sqlite_conn, cond, data_id);

                        }

                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Wrong end date format!");
                    }
                    break;
                case 5:
                    break;
            }
            //getCurrent = my_db.QueryToDo(sqlite_conn, new Dictionary<string, object> { });
            //showCategoryToDo(getCurrent, comboCategory.Text);

        }

        private void comboCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            getCurrent = my_db.QueryToDo(sqlite_conn, new Dictionary<string, object> { });
            string cat = comboCategory.Text;
            showCategoryToDo(getCurrent, cat);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            gridToDo.Focus();
            getCurrent = my_db.QueryToDo(sqlite_conn, new Dictionary<string, object> { });

            showAll(getCurrent);
        }

    }
    
}
