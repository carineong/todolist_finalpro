using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist_finalpro_framework
{
    public class ToDoModel
    {
        public int profile;
        public int id;
        public string desc;
        public int category;
        public DateTime start;
        public DateTime end;
        public int status;
        public int deleted;
        public int prior;
    }

    public class ListToDo
    {
        public List<ToDoModel> todos;

        // ʹ��To-do �����ID������To-do ���������
        public string this[int i]
        {
            get
            {
                var todo = todos.Find(x => (x.id == i));
                return todo.desc;
            }
        }

        // ʹ��To-do ���������������To-do �����ID
        public int this[string i]
        {

            get
            {
                var todo = todos.Find(x => (x.desc == i));
                return todo.id;
            }
        }

        public ListToDo getProfiles_ToDo(int profile_id)
        {
            List<ToDoModel> certain_todos = todos.FindAll(x => (x.profile == profile_id));
            ListToDo tmp = new ListToDo();
            tmp.todos = certain_todos;
            return tmp;
        }

        public ListToDo getCategory_ToDo(int cat_id)
        {
            List<ToDoModel> certain_todos = todos.FindAll(x => (x.category == cat_id));
            ListToDo tmp = new ListToDo();
            tmp.todos = certain_todos;
            return tmp;
        }
    }

}
