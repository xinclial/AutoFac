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
    
    public partial class T_Flow_CommissionRemit
    {
        public long GUID { get; set; }
        public string RemitRootID { get; set; }
        public string RemitCaseNum { get; set; }
        public string RemitSalerID { get; set; }
        public string RemitSalerName { get; set; }
        public string FullAddress { get; set; }
        public System.DateTime RemitDate { get; set; }
        public Nullable<int> RemitFlag { get; set; }
        public string CreateUserID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string Remark { get; set; }
        public string Client1 { get; set; }
        public string Client2 { get; set; }
    }
}
