using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjMDAComment
{

    struct MyItem
    {
        public MyItem( decimal 實際名稱, string 顯示名稱)
        {
            RealValue = 實際名稱;
            DisplayName = 顯示名稱;
        }
        public decimal RealValue { get; set; }
        public string DisplayName { get; set; }
        public override string ToString()
        {
            return DisplayName.ToString();
        }
    }
}
