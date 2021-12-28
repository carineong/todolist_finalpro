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
        public string this[int i]
        {

            get
            {
                var cat = profiles.Find(x => (x.id == i));
                return cat.desc;
            }
            //set
            //{
            //    var cat = profiles.Find(x => (x.id == i));
            //    cat.desc = value;
            //}
        }

        public int this[string i]
        {

            get
            {
                var cat = profiles.Find(x => (x.desc == i));
                return cat.id;
            }
            //set
            //{
            //    var cat = profiles.Find(x => (x.desc == i));
            //    cat.id = value;
            //}
        }

    }

}
