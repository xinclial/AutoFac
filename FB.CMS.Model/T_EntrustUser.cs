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
    
    public partial class T_EntrustUser
    {
        public long ID { get; set; }
        public string Prootid { get; set; }
        public string wfmid { get; set; }
        public string UserName { get; set; }
        public string UserID { get; set; }
        public string UserCode { get; set; }
        public string OrgName { get; set; }
        public Nullable<long> OrgID { get; set; }
        public string UserType { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string UserParent { get; set; }
        public string UserRole { get; set; }
        public Nullable<int> IsLeave { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public Nullable<System.DateTime> CheckTime { get; set; }
        public Nullable<System.DateTime> dRecordTime { get; set; }
        public Nullable<int> Rank { get; set; }
    }
}
