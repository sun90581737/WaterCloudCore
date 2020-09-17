using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.EquipmentMaintain
{
    [TableAttribute("Sys_EMMaintainPlan")]
    public class EMMaintainPlanEntity : IEntity<EMMaintainPlanEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string EquipmentNumber { get; set; }
        public string EquipmentName { get; set; }
        public string Department { get; set; }
        public string MaintainPlan { get; set; }
        public string MaintainType { get; set; }
        public DateTime? PlanStartTime { get; set; }
        public DateTime? PlanEndTime { get; set; }
        public string Remarks { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
