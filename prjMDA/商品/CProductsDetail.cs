using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectMda
{
    public class CProductsDetail
    {
        public string 電影院名稱TheaterName { get; set; }
        public string 商品名稱ProName { get; set; }
        public decimal 小計金額ListTotal { get; set; }
        public decimal 單價Price { get; set; }
        public int 數量Amount { get; set; }       
        public int 商品編號ProId { get; set; }
        
    }
}
