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
    
    public partial class HR_Base
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HR_Base()
        {
            this.HR_Relation = new HashSet<HR_Relation>();
        }
    
        public int baseId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string UserId { get; set; }
        public string Duty { get; set; }
        public string State { get; set; }
        public string ParentId { get; set; }
        public string Path { get; set; }
        public Nullable<int> Level { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public Nullable<int> LatestFlag { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HR_Relation> HR_Relation { get; set; }
    }
}
