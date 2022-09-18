using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMDA.模組
{
    class MovieComment
    {
        public double Rate { get; set; }
        public String Comment_Title { get; set; }
        public String Comments { get; set; }
        public String TAG { get; set; }
        public DateTime Comment_Time { get; set; }
        //public DateTime Viewing_Time { get; set; }
        //public String Source { get; set; }//做一個LISTBUTION不然會亂KEY
        public int Thumbs_Up { get; set; }
        public int Thumbs_Down { get; set; }
        //public int Public_ID { get; set; }
        //public bool OX_Floor { get; set; }
        //public String Update_Image { get; set; }
    }
}
