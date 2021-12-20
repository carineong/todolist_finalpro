using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Diagnostics;
using System.IO;

namespace todolist_finalpro_framework
{
    public class Database
    {

        public SQLiteConnection CreateConnection(string db_name)
        {

            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            sqlite_conn = new SQLiteConnection($"Data Source = {db_name}.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception)
            {
                return null;
            }
            return sqlite_conn;
        }
        
        public void NonQueryCmd(SQLiteConnection conn, string cmd)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = cmd;
            sqlite_cmd.ExecuteNonQuery();
        }

        public SQLiteDataReader QueryCmd(SQLiteConnection conn, string cmd)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = cmd;
            SQLiteDataReader sqlite_datareader = sqlite_cmd.ExecuteReader();
            return sqlite_datareader;
        }

        public int GetCount(SQLiteConnection conn, string cmd)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = cmd;
            return Convert.ToInt32(sqlite_cmd.ExecuteScalar());
        }
        public bool CreateTable(SQLiteConnection conn)
        {
            string cmd = "SELECT count(*) FROM sqlite_master WHERE type = 'table' AND name = 'to_do'";
            SQLiteDataReader result = QueryCmd(conn, cmd);
            int RowCount = GetCount(conn, cmd);
            if (RowCount>0)
            {

                Debug.WriteLine($"{RowCount} Table Exists!");
                //string Dropsql = $"DROP TABLE Category";
                //ExecuteCommand(sqlite_cmd, Dropsql);


                return false;
            }
            else
            {
                Debug.WriteLine("Table Not Found!");
                string CreateTodo = $"CREATE TABLE to_do" +
                    $"           (id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    $"            Description TEXT NOT NULL," +
                    $"            CategoryID INT NOT NULL, " +
                    $"            StartDate TEXT NOT NULL, " +
                    $"            EndDate TEXT, " +
                    $"            Done INT NOT NULL)";
                NonQueryCmd(conn, CreateTodo);

                string CreateCategory = $"CREATE TABLE Category" +
                            $"           (id INTEGER PRIMARY KEY AUTOINCREMENT," +
                            $"            Type TEXT NOT NULL)";
                NonQueryCmd(conn, CreateCategory);
                return true;
            }


        }
        public void InsertCategory(SQLiteConnection conn, string [] cat)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = $"INSERT INTO Category (Type) VALUES (@typeval)";

            

            foreach (string line in cat)
            {
                sqlite_cmd.Parameters.AddWithValue("typeval", line);
                sqlite_cmd.ExecuteNonQuery();
            }
            
        }

        
        public Dictionary<string, int> GetCategoryID(SQLiteConnection conn)
        {
            
            string getCategories = "SELECT * FROM Category";
            SQLiteDataReader datareader = QueryCmd(conn, getCategories);

            Dictionary<string, int> categories = new Dictionary<string, int>();

            while (datareader.Read())
            {
                categories.Add(Convert.ToString(datareader["Type"]), Convert.ToInt32(datareader["id"]));
            }

            datareader.Close();
            return categories;
        
        }

        public void InsertNewToDo(SQLiteConnection conn, ToDoModel to_do)
        {

            string Insert_New = "INSERT INTO to_do " +
                                "(Description, CategoryID, StartDate, EndDate, Done) " +
                                $"VALUES ('{to_do.Description}', '{to_do.Category}', " +
                                $"'{to_do.Start.ToString("yyyy-MM-dd")}', " +
                                $"'{to_do.End.ToString("yyyy-MM-dd")}', '{to_do.Done}')";

            NonQueryCmd(conn, Insert_New);

        }

        public bool DeleteTable(SQLiteConnection conn, string table_name)
        {         
            string DropTable = $"DROP TABLE {table_name}";
            NonQueryCmd(conn, DropTable);

            return true;
        }

        public List<ToDoModel> GetToDoData(SQLiteConnection conn, string cmd)
        {
            SQLiteDataReader datareader = QueryCmd(conn, cmd);
            List<ToDoModel> cur = new List<ToDoModel>();
        
            while (datareader.Read())
            {
                ToDoModel tmp = new ToDoModel();
                tmp.ID = Convert.ToInt32(datareader["id"]);
                tmp.Description = Convert.ToString(datareader["Description"]);
                tmp.Category = Convert.ToInt32(datareader["CategoryID"]);
              
               
                tmp.Start = DateTime.ParseExact(datareader["StartDate"].ToString(), "yyyy-MM-dd", null);
                tmp.End = DateTime.ParseExact(datareader["EndDate"].ToString(), "yyyy-MM-dd", null);
                tmp.Done = Convert.ToInt32(datareader["Done"]);
                cur.Add(tmp);
            }
            datareader.Close();
           
            return cur;
        }

        public List<ToDoModel> QueryToDo (SQLiteConnection conn, Dictionary<string, object> cond)
        {
            
            string cmd = "SELECT * FROM to_do";
            int cond_num = 0;
            foreach (var item in cond)
            {
                string key = item.Key;
                var val = item.Value;
                if(cond_num == 0)
                {
                    cmd += " WHERE";
                }
                
                switch (key)
                {
                    case "Done":
                        if(cond_num >= 1)
                        {
                            cmd += " AND";
                        }
                        cond_num++;
                        cmd += $" Done = {(int)val}";
                        break;

                    case "CategoryID":
                        if (cond_num >= 1)
                        {
                            cmd += " AND";
                        }
                        cond_num++;
                        cmd += $" CategoryID = {(int)val}";
                        break;
                    case "StartDate":
                        if (cond_num >= 1)
                        {
                            cmd += " AND";
                        }
                        cond_num++;
                        List<DateTime> start_dt = (List < DateTime >) val;
                        cmd += $" DATE(StartDate) BETWEEN '{start_dt[0].ToString("yyyy-MM-dd")}' AND '{start_dt[1].ToString("yyyy-MM-dd")}'";
                        break;
                    case "EndDate":
                        if (cond_num >= 1)
                        {
                            cmd += " AND";
                        }
                        cond_num++;
                        List<DateTime> end_dt = (List<DateTime>)val;
                        cmd += $" DATE(EndDate) >= '{end_dt[0].ToString("yyyy-MM-dd")}' AND  '{end_dt[1].ToString("yyyy-MM-dd")}'";
                        break;
                }
            }
            cmd += " ORDER BY id";
            Debug.WriteLine(cmd);
            return GetToDoData(conn, cmd);
        }
        public void UpdateToDo(SQLiteConnection conn, Dictionary<string, object> cond, int id)
        {
            string cmd = "UPDATE to_do SET";//times = @newtime WHERE en = @the_en AND cn = @the_cn;";
             
            int cond_num = 0;
            foreach (var item in cond)
            {
                string key = item.Key;
                var val = item.Value;
                switch (key)
                {
                    case "Description":
                        if (cond_num >= 1)
                        {
                            cmd += ",";
                        }
                        cond_num++;
                        cmd += $" Description = '{(string)val}'";
                        break;

                    case "Done":
                        if (cond_num >= 1)
                        {
                            cmd += ",";
                        }
                        cond_num++;
                        cmd += $" Done = {(int)val}";
                        break;

                    case "CategoryID":
                        if (cond_num >= 1)
                        {
                            cmd += ",";
                        }
                        cond_num++;
                        cmd += $" CategoryID = {(int)val}";
                        break;

                    case "StartDate":
                        if (cond_num >= 1)
                        {
                            cmd += ",";
                        }
                        cond_num++;
                        cmd += $" StartDate = '{((DateTime)val).ToString("yyyy-MM-dd")}'";
                        break;

                    case "EndDate":
                        if (cond_num >= 1)
                        {
                            cmd += ",";
                        }
                        cond_num++;
                        cmd += $" EndDate = '{((DateTime)val).ToString("yyyy-MM-dd")}'";
                        break;
                }
            }
            cmd += $" WHERE id = {id}";
            Debug.WriteLine(cmd);
            NonQueryCmd(conn, cmd);
            return ;
            
        }

    }
}
