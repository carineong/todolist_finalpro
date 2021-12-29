using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todolist_finalpro_framework
{
    public class Profile
    {
        public int id;
        public string desc;
        public int deleted;
    }
    public class ListProfile
    {
        public List<Profile> profiles;

        // 使用Profile ID索引出Profile 的名字
        public string this[int i]
        {

            get
            {
                var cat = profiles.Find(x => (x.id == i));
                return cat.desc;
            }
        }

        // 使用Profile 的名字索引出Profile ID
        public int this[string i]
        {

            get
            {
                var cat = profiles.Find(x => (x.desc == i));
                return cat.id;
            }
        }

    }

}
