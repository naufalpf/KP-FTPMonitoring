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
    
    public partial class MasterFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MasterFile()
        {
            this.HistoryMonitoringLogs = new HashSet<HistoryMonitoringLog>();
            this.MonitoringLogs = new HashSet<MonitoringLog>();
        }
    
        public int Id { get; set; }
        public Nullable<int> SroId { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HistoryMonitoringLog> HistoryMonitoringLogs { get; set; }
        public virtual MasterSRO MasterSRO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MonitoringLog> MonitoringLogs { get; set; }
    }
}