//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FTPMonitoring.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MonitoringLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MonitoringLog()
        {
            this.MonitoringLogDetails = new HashSet<MonitoringLogDetail>();
        }
    
        public int Id { get; set; }
        public Nullable<int> FileId { get; set; }
    
        public virtual MasterFile MasterFile { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonitoringLogDetail> MonitoringLogDetails { get; set; }
    }
}
