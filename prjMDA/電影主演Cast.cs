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
    
    public partial class 電影主演Cast
    {
        public int 主演編號MA_ID { get; set; }
        public int 電影編號Movie_ID { get; set; }
        public int 演員編號Actor_ID { get; set; }
        public string 角色名字Character_Name { get; set; }
        public string 角色說明Character_illustrate { get; set; }
    
        public virtual 電影Movies 電影Movies { get; set; }
        public virtual 演員總表Actors 演員總表Actors { get; set; }
    }
}
