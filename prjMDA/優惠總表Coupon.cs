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
    
    public partial class 優惠總表Coupon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public 優惠總表Coupon()
        {
            this.優惠明細CouponLists = new HashSet<優惠明細CouponLists>();
        }
    
        public int 優惠編號Coupon_ID { get; set; }
        public string 優惠名稱Coupon_Name { get; set; }
        public decimal 優惠折扣CouponDiscount { get; set; }
        public string 優惠代碼Coupon_Code { get; set; }
        public System.DateTime 優惠截止日期CouponDueDate { get; set; }
        public int 優惠所需紅利BonusCost { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<優惠明細CouponLists> 優惠明細CouponLists { get; set; }
    }
}
