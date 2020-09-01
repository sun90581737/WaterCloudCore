using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.ProductionManage
{
    
    [TableAttribute("Sys_EHNumberMoldsDelivered")]
    public class EHNumberMoldsDeliveredEntity : IEntity<EHNumberMoldsDeliveredEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string Type { get; set; }
        public int? Number { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
