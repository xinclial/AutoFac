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
    
    public partial class t_Flow_ClinetInfo_Log
    {
        public System.Guid ID { get; set; }
        public string RootID { get; set; }
        public string WfmID { get; set; }
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string FlowName { get; set; }
        public string OrgID { get; set; }
        public string OrgName { get; set; }
        public string FlowType { get; set; }
        public Nullable<System.DateTime> LogTime { get; set; }
        public Nullable<int> FlowID { get; set; }
        public string Remark { get; set; }
    }
}
