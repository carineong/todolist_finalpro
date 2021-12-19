using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist_finalpro_framework
{
    public class ToDoModel
    {
        int id;
        string desc;
        int done;
        int category;
        DateTime start;
        DateTime end;

        public int ID
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }

        public string Description
        {
            get
            {
                return this.desc;
            }
            set
            {
                this.desc = value;
            }
        }

        public int Done
        {
            get
            {
                return this.done;
            }
            set
            {
                this.done = value;
            }
        }

        public int Category
        {
            get
            {
                return this.category;
            }
            set
            {
                this.category = value;
            }
        }

        public DateTime Start
        {
            get
            {
                return this.start;
            }
            set
            {
                this.start = value;
            }
        }

        public DateTime End
        {
            get
            {
                return this.end;
            }
            set
            {
                this.end = value;
            }
        }
    }
}
