//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace FB.CMS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_Flow_Litigation
    {
        public int ID { get; set; }
        public string RootId { get; set; }
        public string WfmId { get; set; }
        public string Applyer { get; set; }
        public string Branch { get; set; }
        public string ApplyerPhone { get; set; }
        public string PropertyName { get; set; }
        public string PropertyAddress { get; set; }
        public Nullable<decimal> CommAmount { get; set; }
        public string IsDocument { get; set; }
        public string IsIoriginal { get; set; }
        public string CaseRemark { get; set; }
        public string UnSafeCause { get; set; }
        public Nullable<System.DateTime> CheckTime { get; set; }
        public Nullable<System.DateTime> dRecordTime { get; set; }
        public Nullable<bool> IsNew { get; set; }
        public Nullable<bool> IsWast { get; set; }
    }
}
