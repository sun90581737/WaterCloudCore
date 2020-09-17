using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.EquipmentMaintain
{
    [TableAttribute("Sys_EMEquipmentList")]
    public class EMEquipmentListEntity : IEntity<EMEquipmentListEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Department { get; set; }
        public string State { get; set; }
        public DateTime? DateArrival { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
