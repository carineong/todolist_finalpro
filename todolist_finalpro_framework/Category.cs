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

        // 使用Category ID 索引出Category的名字
        public string this[int i]
        {
            
            get {
                var cat = categories.Find(x => (x.id == i));
                if (cat == null) return "";
                return cat.desc; 
            }
        }

        // 使用Category 的名字索引出Category ID
        public int this[string i]
        {

            get
            {
                var cat = categories.Find(x => (x.desc == i));
                if (cat == null) return 0;
                return cat.id;
            }
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
