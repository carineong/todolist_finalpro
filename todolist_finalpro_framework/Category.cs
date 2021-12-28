using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist_finalpro_framework
{
    public class Category
    {
        public int id;
        public string desc;
        public int profile;
        public int deleted;
    }

    public class ListCategory
    {
        public List<Category> categories;
        public string this[int i]
        {
            
            get {
                var cat = categories.Find(x => (x.id == i));
                    return cat.desc; 
            }
            //set { 
            //    var cat = categories.Find(x => (x.id == i));
            //    cat.desc = value; 
            //}
        }

        public int this[string i]
        {

            get
            {
                var cat = categories.Find(x => (x.desc == i));
                return cat.id;
            }
            //set
            //{
            //    var cat = categories.Find(x => (x.desc == i));
            //    cat.id = value;
            //}
        }

        public ListCategory getProfiles_Category(int profile_id)
        {
            List<Category> cat = categories.FindAll(x => (x.profile == profile_id));
            ListCategory tmp = new ListCategory();
            tmp.categories = cat;
            return tmp;
        }
    }

}
