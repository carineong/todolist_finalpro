using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace todolist_finalpro_framework
{
    public partial class Form1 : KryptonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            // calendar里的selected date改了以后在这里写代码
        }
    }
}
