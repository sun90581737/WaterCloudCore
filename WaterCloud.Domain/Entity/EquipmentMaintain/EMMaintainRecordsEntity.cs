using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.EquipmentMaintain
{
    [TableAttribute("Sys_EMMaintainRecords")]
    public class EMMaintainRecordsEntity : IEntity<EMMaintainRecordsEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string RepairOrderNo { get; set; }
        public string RepairDepartment { get; set; }
        public string RepairEquipment { get; set; }
        public string RepairPersonnel { get; set; }
        public string FaultDescription { get; set; }
        public string ServiceNumber { get; set; }
        public string ServiceType { get; set; }
        public string Supplier { get; set; }
        public string FaultCategory { get; set; }
        public double MaintainPrice { get; set; }
        public string State { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
