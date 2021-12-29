using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace todolist_finalpro_framework
{
    // 用于Form的颜色设置
    static class MyColour
    {
        // 每个Category Label 分配一个颜色（使用 id % categories.Len 索引，所以颜色仍可能重复）
        static public Color[] categories = {
                Color.Yellow,
                Color.Orange,
                Color.Tomato,
                Color.Cyan,
                Color.LawnGreen,
                Color.Peru,
                Color.DeepPink,
                Color.Firebrick,
                Color.LightSalmon,
                Color.Aquamarine,
                Color.PaleGreen,
                Color.PowderBlue,
                Color.Plum,
                Color.Pink,
                Color.Wheat
                };
    }
}
