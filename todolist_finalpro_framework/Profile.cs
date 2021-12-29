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

        // ʹ��Profile ID������Profile ������
        public string this[int i]
        {

            get
            {
                var cat = profiles.Find(x => (x.id == i));
                return cat.desc;
            }
        }

        // ʹ��Profile ������������Profile ID
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
