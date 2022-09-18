using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMDAComment
{
    public class obj
    {
        public int 評論編號Comment_ID { get; set; }
        public string 評論標題Comment_Title { get; set; }
        public int 會員編號Member_ID { get; set; }
        public string 暱稱NickName { get; set; }
        public int 電影編號Movie_ID { get; set; }
        public string 中文標題Title_Cht { get; set; }
        public Nullable<decimal> 評分Rate { get; set; }
        public Nullable<decimal> 期待度anticipation { get; set; }
        public string 評論內容Comments { get; set; }
        public System.DateTime 發佈時間Comment_Time { get; set; }
        public Nullable<System.DateTime> 觀影日期Viewing_Time { get; set; }
        public string 觀影方式Source { get; set; }
        public Nullable<int> 公開等級編號Public_ID { get; set; }
        public Nullable<bool> 是否開放討論串OX_Floor { get; set; }
        public int 屏蔽Invisible { get; set; }
        public int 檢舉Report { get; set; }
    }
}
