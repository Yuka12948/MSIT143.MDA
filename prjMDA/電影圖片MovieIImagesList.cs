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
    
    public partial class 電影圖片MovieIImagesList
    {
        public int 電影圖片編號MI_ID { get; set; }
        public int 電影編號Movie_ID { get; set; }
        public int 圖片編號Image_ID { get; set; }
    
        public virtual 電影Movies 電影Movies { get; set; }
        public virtual 電影圖片總表MovieImages 電影圖片總表MovieImages { get; set; }
    }
}
