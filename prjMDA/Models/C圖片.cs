using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMDA.Models
{
    public class C圖片
    {
        public byte[] 圖片Image { get; set; }
        public int  圖片編號Image_ID { get; set; }
        public int 電影編號Movie_ID { get; set; }

        public int 屏蔽Invisible { get; set; }
        public string 中文標題Title_Cht{ get; set; }
}
}
