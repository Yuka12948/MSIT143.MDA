//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjMDA
{
    using System;
    using System.Collections.Generic;
    
    public partial class 出售座位明細SeatSold
    {
        public int 訂單編號Order_ID { get; set; }
        public int 出售明細編號Sold_ID { get; set; }
        public int 場次編號Screening_ID { get; set; }
        public string 座位表編號Seat_ID { get; set; }
    
        public virtual 場次Screening 場次Screening { get; set; }
        public virtual 訂單總表Orders 訂單總表Orders { get; set; }
    }
}
