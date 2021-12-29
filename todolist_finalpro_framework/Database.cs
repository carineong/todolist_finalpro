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
        //建立数据库链接
        public SQLiteConnection CreateConnection(string db_name)
        {

            SQLiteConnection sqliteConn;
            // Create a new database connection:
            sqliteConn = new SQLiteConnection($"Data Source = {db_name}.db; Version = 3; New = True; Compress = True; ");
            // Open the connection:
            try
            {
                sqliteConn.Open();
            }
            catch (Exception)
            {
                return null;
            }
            return sqliteConn;
        }

        //查询数据库里是否已经有to_do表。若没有则建表
        public bool CreateTable(SQLiteConnection conn)
        {
            string cmd = "SELECT count(*) FROM sqlite_master WHERE type = 'table' AND name = 'to_do'";
            int rowCount = GetCount(conn, cmd);

            if (rowCount > 0)//已经有表了
            {

                Debug.WriteLine($"{rowCount} Table Exists!");
                //string Dropsql = $"DROP TABLE Category";
                //ExecuteCommand(sqliteCmd, Dropsql);
                return false;
            }
            else//表不存在。创to_do, category和profile表
            {
                Debug.WriteLine("Table Not Found!");
                string createToDo = $"CREATE TABLE to_do" +
                    $"           (id INTEGER PRIMARY KEY AUTOINCREMENT," +
                    $"            Description TEXT NOT NULL," +
                    $"            CategoryID INT NOT NULL, " +
                    $"            StartDate TEXT NOT NULL, " +
                    $"            EndDate TEXT, " +
                    $"            Status INT NOT NULL," +
                    $"            ProfileID INT NOT NULL," +
                    $"            Priority INT NOT NULL," +
                    $"            Deleted INT NOT NULL)";
                NonQueryCmd(conn, createToDo);

                string createCategory = $"CREATE TABLE Category" +
                            $"           (id INTEGER PRIMARY KEY AUTOINCREMENT," +
                            $"            Type TEXT NOT NULL," +
                            $"            ProfileID INT NOT NULL," +
                            $"            Deleted INT NOT NULL)";
                NonQueryCmd(conn, createCategory);

                string createProfile = $"CREATE TABLE Profile" +
            $"           (id INTEGER PRIMARY KEY AUTOINCREMENT," +
            $"            Type TEXT NOT NULL," +
            $"            Deleted INT NOT NULL)";
                NonQueryCmd(conn, createProfile);
                return true;
            }
        }

        //执行非查询操作，如INSERT, UPDATE等等
        public void NonQueryCmd(SQLiteConnection conn, string cmd)
        {
            SQLiteCommand sqliteCmd;
            sqliteCmd = conn.CreateCommand();
            sqliteCmd.CommandText = cmd;
            sqliteCmd.ExecuteNonQuery();
        }

        //执行查询操作，如SELECT
        public SQLiteDataReader QueryCmd(SQLiteConnection conn, string cmd)
        {
            SQLiteCommand sqliteCmd;
            sqliteCmd = conn.CreateCommand();
            sqliteCmd.CommandText = cmd;
            SQLiteDataReader sqliteDatareader = sqliteCmd.ExecuteReader();
            return sqliteDatareader;
        }

        //执行获取特定统计结果操作，如SELECT (*) COUNT
        public int GetCount(SQLiteConnection conn, string cmd)
        {
            SQLiteCommand sqliteCmd;
            sqliteCmd = conn.CreateCommand();
            sqliteCmd.CommandText = cmd;
            return Convert.ToInt32(sqliteCmd.ExecuteScalar());
        }

        /* 各表的INSERT操作*/
        //增加新的大类Profile
        public void InsertProfile(SQLiteConnection conn, string[] cat)
        {
            SQLiteCommand sqliteCmd;
            sqliteCmd = conn.CreateCommand();

            sqliteCmd.CommandText = $"INSERT INTO Profile (Type, Deleted) VALUES (@typeval, 0)";

            foreach (string line in cat)
            {
                sqliteCmd.Parameters.AddWithValue("typeval", line);

                sqliteCmd.ExecuteNonQuery();
            }
        }

        //在指定大类中增加分组Cateogry
        public void InsertCategory(SQLiteConnection conn, string[] cat, int[] profileID)
        {
            SQLiteCommand sqliteCmd;
            sqliteCmd = conn.CreateCommand();

            sqliteCmd.CommandText = $"INSERT INTO Category (Type, ProfileID, Deleted) VALUES (@typeval, @pID, 0)";
            int len = cat.Length;
            for (int i = 0; i < len; i++)
            {
                sqliteCmd.Parameters.AddWithValue("typeval", cat[i]);
                sqliteCmd.Parameters.AddWithValue("pID", profileID[i]);
                sqliteCmd.ExecuteNonQuery();
            }
        }

        //增加具体的待办事项to_do
        public void InsertNewToDo(SQLiteConnection conn, ToDoModel to_do)
        {
            string insertNew = "INSERT INTO to_do " +
                                "(Description, CategoryID, StartDate, EndDate, Status, ProfileID, Priority, Deleted) " +
                                $"VALUES ('{to_do.desc}', '{to_do.category}', " +
                                $"'{to_do.start.ToString("yyyy-MM-dd")}', " +
                                $"'{to_do.end.ToString("yyyy-MM-dd")}', '{to_do.status}', '{to_do.profile}', 0, 0)";

            NonQueryCmd(conn, insertNew);
        }



        /*各表的查询操作*/
        //可根据指定条件查询大类Profile
        public List<Profile> QueryProfile(SQLiteConnection conn, Dictionary<string, object> cond, int notDeleted = 1)
        {
            string cmd = "SELECT * FROM Profile";
            int condNum = 0;
            foreach (var item in cond) //遍历存放各条件的dict
            {
                string key = item.Key;
                var val = item.Value;
                if (condNum == 0)
                {
                    cmd += " WHERE";
                }

                switch (key)
                {
                    case "Type": //大类名
                        if (condNum >= 1)
                        {
                            cmd += " AND";
                        }
                        condNum++;
                        cmd += $" Type = {(string)val}";
                        break;

                }
            }

            //取所有、或已删除、或未删除的项
            if (notDeleted != 0)
            {
                if (condNum == 0)
                {
                    cmd += " WHERE";
                }
                else if (condNum >= 1)
                {
                    cmd += " AND";
                }
                cmd += " Deleted = ";
                if (notDeleted == 1)
                {
                    cmd += "0";
                }
                else if (notDeleted == -1)
                {
                    cmd += "1";
                }
            }
            cmd += " ORDER BY id"; //结果得根据id排序
            Debug.WriteLine(cmd);
            SQLiteDataReader datareader = QueryCmd(conn, cmd);
            List<Profile> cur = new List<Profile>();

            while (datareader.Read()) //将结果用Profile类存起来
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

        //可根据指定条件查询分组Category
        public List<Category> QueryCategory(SQLiteConnection conn, Dictionary<string, object> cond, int notDeleted = 1)
        {
            string cmd = "SELECT * FROM Category";
            int condNum = 0;
            foreach (var item in cond) //遍历存放各条件的dict
            {
                string key = item.Key;
                var val = item.Value;
                if (condNum == 0)
                {
                    cmd += " WHERE";
                }

                switch (key)
                {
                    case "Profile": //取特定Profile的Category
                        if (condNum >= 1)
                        {
                            cmd += " AND";
                        }
                        condNum++;
                        cmd += $" ProfileID = {(int)val}";
                        break;
                    case "Type": //取特定内容的Category
                        if (condNum >= 1)
                        {
                            cmd += " AND";
                        }
                        condNum++;
                        cmd += $" Type = {(string)val}";
                        break;

                }
            }

            //取所有、或已删除、或未删除的项
            if (notDeleted != 0)
            {
                if (condNum == 0)
                {
                    cmd += " WHERE";
                }
                else if (condNum >= 1)
                {
                    cmd += " AND";
                }
                cmd += " Deleted = ";
                if (notDeleted == 1)
                {
                    cmd += "0";
                }
                else if (notDeleted == -1)
                {
                    cmd += "1";
                }
            }
            cmd += " ORDER BY id";//结果得根据id排序
            Debug.WriteLine(cmd);
            SQLiteDataReader datareader = QueryCmd(conn, cmd);
            List<Category> cur = new List<Category>();

            while (datareader.Read())//将结果用Category类存起来
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

        //可根据指定条件查询待办事项to_do
        public List<ToDoModel> QueryToDo(SQLiteConnection conn, Dictionary<string, object> cond, int notDeleted = 1)
        {
            string cmd = "SELECT * FROM to_do";
            int condNum = 0;
            foreach (var item in cond)//遍历存放各条件的dict
            {
                string key = item.Key;
                var val = item.Value;
                if (condNum == 0)
                {
                    cmd += " WHERE";
                }

                switch (key)
                {
                    case "Profile": //取特定Profile的to_do
                        if (condNum >= 1)
                        {
                            cmd += " AND";
                        }
                        condNum++;
                        cmd += $" ProfileID = {(int)val}";
                        break;
                    case "CategoryID": //取特定Category的to_do
                        if (condNum >= 1)
                        {
                            cmd += " AND";
                        }
                        condNum++;
                        cmd += $" CategoryID = {(int)val}";
                        break;
                    case "StartDate": //取特定开始日期的to_do
                        if (condNum >= 1)
                        {
                            cmd += " AND";
                        }
                        condNum++;
                        List<DateTime> start_dt = (List<DateTime>)val;
                        cmd += $" DATE(StartDate) BETWEEN '{start_dt[0].ToString("yyyy-MM-dd")}' AND '{start_dt[1].ToString("yyyy-MM-dd")}'";
                        break;
                    case "EndDate": //取特定结束日期的to_do
                        if (condNum >= 1)
                        {
                            cmd += " AND";
                        }
                        condNum++;
                        List<DateTime> end_dt = (List<DateTime>)val;
                        cmd += $" DATE(EndDate) >= '{end_dt[0].ToString("yyyy-MM-dd")}' AND  '{end_dt[1].ToString("yyyy-MM-dd")}'";
                        break;
                    case "Status": //取特定状态的to_do
                        if (condNum >= 1)
                        {
                            cmd += " AND";
                        }
                        condNum++;
                        cmd += $" Status = '{val}'";
                        break;
                    case "Priority": //根据优先级取to_do
                        if (condNum >= 1)
                        {
                            cmd += " AND";
                        }
                        condNum++;
                        cmd += $" Priority = {(int)val}";
                        break;
                }
            }

            //取所有、或已删除、或未删除的项
            if (notDeleted != 0)
            {
                if (condNum == 0)
                {
                    cmd += " WHERE";
                }
                else if (condNum >= 1)
                {
                    cmd += " AND";
                }
                cmd += " Deleted = ";
                if (notDeleted == 1)
                {
                    cmd += "0";
                }
                else if (notDeleted == -1)
                {
                    cmd += "1";
                }
            }
            cmd += " ORDER BY Priority, EndDate, id";//结果得先根据优先级、定下的完成日期、id排序
            Debug.WriteLine(cmd);

            SQLiteDataReader datareader = QueryCmd(conn, cmd);
            List<ToDoModel> cur = new List<ToDoModel>();

            while (datareader.Read())//将结果用ToDoModel类存起来
            {
                ToDoModel tmp = new ToDoModel();
                tmp.id = Convert.ToInt32(datareader["id"]);
                tmp.desc = Convert.ToString(datareader["Description"]);
                tmp.category = Convert.ToInt32(datareader["CategoryID"]);
                tmp.prior = Convert.ToInt32(datareader["Priority"]);
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

        /*各表的更新操作*/
        //ToDo的更新操作
        public void UpdateToDo(SQLiteConnection conn, Dictionary<string, object> cond, int id)
        {
            string cmd = "UPDATE to_do SET";

            int condNum = 0;
            foreach (var item in cond)//遍历存放各条件的dict
            {
                string key = item.Key;
                var val = item.Value;
                switch (key)
                {
                    case "Description": //改内容
                        if (condNum >= 1)
                        {
                            cmd += ",";
                        }
                        condNum++;
                        cmd += $" Description = '{(string)val}'";
                        break;

                    case "Status": //改状态
                        if (condNum >= 1)
                        {
                            cmd += ",";
                        }
                        condNum++;
                        cmd += $" Status = {(int)val}";
                        break;

                    case "CategoryID": //改Category
                        if (condNum >= 1)
                        {
                            cmd += ",";
                        }
                        condNum++;
                        cmd += $" CategoryID = {(int)val}";
                        break;

                    case "StartDate": //改开始时间
                        if (condNum >= 1)
                        {
                            cmd += ",";
                        }
                        condNum++;
                        cmd += $" StartDate = '{((DateTime)val).ToString("yyyy-MM-dd")}'";
                        break;

                    case "EndDate": //改预定的完成时间
                        if (condNum >= 1)
                        {
                            cmd += ",";
                        }
                        condNum++;
                        cmd += $" EndDate = '{((DateTime)val).ToString("yyyy-MM-dd")}'";
                        break;
                    case "Deleted": //删除或恢复
                        if (condNum >= 1)
                        {
                            cmd += ",";
                        }
                        condNum++;
                        cmd += $" Deleted = {(int)val}";
                        break;
                    case "Priority": //改事项的优先级
                        if (condNum >= 1)
                        {
                            cmd += ",";
                        }
                        condNum++;
                        cmd += $" Priority = {(int)val}";
                        break;
                }
            }
            cmd += $" WHERE id = {id}";
            Debug.WriteLine(cmd);
            NonQueryCmd(conn, cmd);
            return;
        }

        // Profile或Category的更新操作
        public void UpdateProfile_Category(SQLiteConnection conn, string table, Dictionary<string, object> cond, int id)
        {
            string cmd = $"UPDATE {table} SET";

            int condNum = 0;
            foreach (var item in cond)//遍历存放各条件的dict
            {
                string key = item.Key;
                var val = item.Value;
                switch (key)
                {
                    case "Type"://改内容
                        if (condNum >= 1)
                        {
                            cmd += ",";
                        }
                        condNum++;
                        cmd += $" Type = '{(string)val}'";
                        break;

                    case "Profile"://若是Category表，可修改其对应的Profile
                        if (table != "Category")
                        {
                            break;
                        }
                        if (condNum >= 1)
                        {
                            cmd += ",";
                        }
                        condNum++;
                        cmd += $" ProfileID = '{(int)val}'";
                        break;

                    case "Deleted": //删除会恢复
                        if (condNum >= 1)
                        {
                            cmd += ",";
                        }
                        condNum++;
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
