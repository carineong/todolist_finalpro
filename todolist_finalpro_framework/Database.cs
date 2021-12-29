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

        public bool CreateTable(SQLiteConnection conn)
        {
            string cmd = "SELECT count(*) FROM sqlite_master WHERE type = 'table' AND name = 'to_do'";
            SQLiteDataReader result = QueryCmd(conn, cmd);
            int RowCount = GetCount(conn, cmd);
            if (RowCount > 0)
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
                    $"            ProfileID INT NOT NULL," +
                    $"            StartDate TEXT NOT NULL, " +
                    $"            EndDate TEXT, " +
                    $"            Status INT NOT NULL," +
                    $"            Priority INT NOT NULL," +
                    $"            Deleted INT NOT NULL)";
                NonQueryCmd(conn, CreateTodo);

                string CreateCategory = $"CREATE TABLE Category" +
                            $"           (id INTEGER PRIMARY KEY AUTOINCREMENT," +
                            $"            Type TEXT NOT NULL," +
                            $"            ProfileID INT NOT NULL," +
                            $"            Deleted INT NOT NULL)";
                NonQueryCmd(conn, CreateCategory);

                string CreateProfile = $"CREATE TABLE Profile" +
            $"           (id INTEGER PRIMARY KEY AUTOINCREMENT," +
            $"            Type TEXT NOT NULL," +
            $"            Deleted INT NOT NULL)";
                NonQueryCmd(conn, CreateProfile);
                return true;
            }
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
       
        //public Dictionary<string, int> GetCategoryID(SQLiteConnection conn)
        //{
            
        //    string getCategories = "SELECT * FROM Category";
        //    SQLiteDataReader datareader = QueryCmd(conn, getCategories);

        //    Dictionary<string, int> categories = new Dictionary<string, int>();

        //    while (datareader.Read())
        //    {
        //        categories.Add(Convert.ToString(datareader["Type"]), Convert.ToInt32(datareader["id"]));
        //    }

        //    datareader.Close();
        //    return categories;
        
        //}


        // Profile、Category及todo的增加数据操作
        
        public void InsertProfile(SQLiteConnection conn, string[] cat)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();

            sqlite_cmd.CommandText = $"INSERT INTO Profile (Type, Deleted) VALUES (@typeval, 0)";

            foreach (string line in cat)
            {
                sqlite_cmd.Parameters.AddWithValue("typeval", line);

                sqlite_cmd.ExecuteNonQuery();
            }
        }

        public void InsertCategory(SQLiteConnection conn, string[] cat, int[] profileID)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();

            sqlite_cmd.CommandText = $"INSERT INTO Category (Type, ProfileID, Deleted) VALUES (@typeval, @pID, 0)";
            int len = cat.Length;
            for (int i = 0; i < len; i++)
            {
                sqlite_cmd.Parameters.AddWithValue("typeval", cat[i]);
                sqlite_cmd.Parameters.AddWithValue("pID", profileID[i]);
                sqlite_cmd.ExecuteNonQuery();
            }
        }

        public void InsertNewToDo(SQLiteConnection conn, ToDoModel to_do)
        {

            string Insert_New = "INSERT INTO to_do " +
                                "(Description, CategoryID, StartDate, EndDate, Status, ProfileID, Priority, Deleted) " +
                                $"VALUES ('{to_do.desc}', '{to_do.category}', " +
                                $"'{to_do.start.ToString("yyyy-MM-dd")}', " +
                                $"'{to_do.end.ToString("yyyy-MM-dd")}', '{to_do.status}', '{to_do.profile}', 0, 0)";

            NonQueryCmd(conn, Insert_New);

        }

        

        
        // Profile、Category及todo的查询操作
        public List<Profile> QueryProfile(SQLiteConnection conn, Dictionary<string, object> cond, int not_delete = 1)
        {
            string cmd = "SELECT * FROM Profile";
            int cond_num = 0;
            foreach (var item in cond)
            {
                string key = item.Key;
                var val = item.Value;
                if (cond_num == 0)
                {
                    cmd += " WHERE";
                }

                switch (key)
                {
                    case "Type":
                        if (cond_num >= 1)
                        {
                            cmd += " AND";
                        }
                        cond_num++;
                        cmd += $" Type = {(string)val}";
                        break;
              
                }
            }

            if (not_delete != 0)
            {
                if (cond_num == 0)
                {
                    cmd += " WHERE";
                }
                else if (cond_num >= 1)
                {
                    cmd += " AND";
                }
                cmd += " Deleted = ";
                if (not_delete == 1)
                {
                    cmd += "0";
                }
                else if (not_delete == -1)
                {
                    cmd += "1";
                }
            }
            cmd += " ORDER BY id";
            Debug.WriteLine(cmd);
            SQLiteDataReader datareader = QueryCmd(conn, cmd);
            List<Profile> cur = new List<Profile>();

            while (datareader.Read())
            {
                Profile tmp = new Profile();
                tmp.id = Convert.ToInt32(datareader["id"]);
                tmp.desc = Convert.ToString(datareader["Type"]);
                tmp.deleted = Convert.ToInt32(datareader["Deleted"]);
                cur.Add(tmp);
            }
            datareader.Close();

            return cur;
        }

        public List<Category> QueryCategory(SQLiteConnection conn, Dictionary<string, object> cond, int not_delete = 1)
        {
            string cmd = "SELECT * FROM Category";
            int cond_num = 0;
            foreach (var item in cond)
            {
                string key = item.Key;
                var val = item.Value;
                if (cond_num == 0)
                {
                    cmd += " WHERE";
                }

                switch (key)
                {
                    case "Profile":
                        if (cond_num >= 1)
                        {
                            cmd += " AND";
                        }
                        cond_num++;
                        cmd += $" ProfileID = {(int)val}";
                        break;
                    case "Type":
                        if (cond_num >= 1)
                        {
                            cmd += " AND";
                        }
                        cond_num++;
                        cmd += $" Type = {(string)val}";
                        break;

                }
            }

            if (not_delete != 0)
            {
                if (cond_num == 0)
                {
                    cmd += " WHERE";
                }
                else if (cond_num >= 1)
                {
                    cmd += " AND";
                }
                cmd += " Deleted = ";
                if (not_delete == 1)
                {
                    cmd += "0";
                }
                else if (not_delete == -1)
                {
                    cmd += "1";
                }
            }
            cmd += " ORDER BY id";
            Debug.WriteLine(cmd);
            SQLiteDataReader datareader = QueryCmd(conn, cmd);
            List<Category> cur = new List<Category>();

            while (datareader.Read())
            {
                Category tmp = new Category();
                tmp.id = Convert.ToInt32(datareader["id"]);
                tmp.desc = Convert.ToString(datareader["Type"]);
                tmp.profile = Convert.ToInt32(datareader["ProfileID"]);
                tmp.deleted = Convert.ToInt32(datareader["Deleted"]);
                cur.Add(tmp);
            }
            datareader.Close();

            return cur;
        }

        public List<ToDoModel> QueryToDo(SQLiteConnection conn, Dictionary<string, object> cond, int not_delete = 1)
        {
            string cmd = "SELECT * FROM to_do";
            int cond_num = 0;
            foreach (var item in cond)
            {
                string key = item.Key;
                var val = item.Value;
                if (cond_num == 0)
                {
                    cmd += " WHERE";
                }

                switch (key)
                {
                    case "Profile":
                        if (cond_num >= 1)
                        {
                            cmd += " AND";
                        }
                        cond_num++;
                        cmd += $" ProfileID = {(int)val}";
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
                        List<DateTime> start_dt = (List<DateTime>)val;
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
                    case "Status":
                        if (cond_num >= 1)
                        {
                            cmd += " AND";
                        }
                        cond_num++;
                        cmd += $" Status = '{val}'";
                        break;
                    case "Priority":
                        if (cond_num >= 1)
                        {
                            cmd += " AND";
                        }
                        cond_num++;
                        cmd += $" Priority = {(int)val}";
                        break;
                }
            }

            if (not_delete != 0)
            {
                if (cond_num == 0)
                {
                    cmd += " WHERE";
                }
                else if (cond_num >= 1)
                {
                    cmd += " AND";
                }
                cmd += " Deleted = ";
                if (not_delete == 1)
                {
                    cmd += "0";
                }
                else if (not_delete == -1)
                {
                    cmd += "1";
                }
            }
            cmd += " ORDER BY id";
            Debug.WriteLine(cmd);

            SQLiteDataReader datareader = QueryCmd(conn, cmd);
            List<ToDoModel> cur = new List<ToDoModel>();

            while (datareader.Read())
            {
                ToDoModel tmp = new ToDoModel();
                tmp.id = Convert.ToInt32(datareader["id"]);
                tmp.desc = Convert.ToString(datareader["Description"]);
                tmp.category = Convert.ToInt32(datareader["CategoryID"]);

                tmp.profile = Convert.ToInt32(datareader["ProfileID"]);
                tmp.start = DateTime.ParseExact(datareader["StartDate"].ToString(), "yyyy-MM-dd", null);
                tmp.end = DateTime.ParseExact(datareader["EndDate"].ToString(), "yyyy-MM-dd", null);
                tmp.status = Convert.ToInt32(datareader["Status"]);
                tmp.deleted = Convert.ToInt32(datareader["Deleted"]);
                cur.Add(tmp);
            }

            datareader.Close();

            return cur;
        }


        // Profile、Category及todo的更新操作
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

                    case "Status":
                        if (cond_num >= 1)
                        {
                            cmd += ",";
                        }
                        cond_num++;
                        cmd += $" Status = {(int)val}";
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
                    case "Deleted":
                        if (cond_num >= 1)
                        {
                            cmd += ",";
                        }
                        cond_num++;
                        cmd += $" Deleted = {(int)val}";
                        break;
                    case "Priority":
                        if (cond_num >= 1)
                        {
                            cmd += ",";
                        }
                        cond_num++;
                        cmd += $" Priority = {(int)val}";
                        break;
                }
            }
            cmd += $" WHERE id = {id}";
            Debug.WriteLine(cmd);
            NonQueryCmd(conn, cmd);
            return;
        }

        public void UpdateProfile_Category(SQLiteConnection conn, string table, Dictionary<string, object> cond, int id)
        {
            string cmd = $"UPDATE {table} SET";

            int cond_num = 0;
            foreach (var item in cond)
            {
                string key = item.Key;
                var val = item.Value;
                switch (key)
                {
                    case "Type":
                        if (cond_num >= 1)
                        {
                            cmd += ",";
                        }
                        cond_num++;
                        cmd += $" Type = '{(string)val}'";
                        break;

                    case "Profile":
                        if(table != "Category")
                        {
                            break;
                        }
                        if (cond_num >= 1)
                        {
                            cmd += ",";
                        }
                        cond_num++;
                        cmd += $" ProfileID = '{(int)val}'";
                        break;

                    case "Deleted":
                        if (cond_num >= 1)
                        {
                            cmd += ",";
                        }
                        cond_num++;
                        cmd += $" Deleted = {(int)val}";
                        break;
                }
            }
            cmd += $" WHERE id = {id}";
            Debug.WriteLine(cmd);
            NonQueryCmd(conn, cmd);
            return;
        }


        //删除表操作
        public bool DeleteTable(SQLiteConnection conn, string table_name)
        {
            string DropTable = $"DROP TABLE {table_name}";
            NonQueryCmd(conn, DropTable);

            return true;
        }

    }
}
