using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.ProductionManage
{
    [TableAttribute("Sys_DeliveryCompletionRate")]
    public class DeliveryCompletionRateEntity : IEntity<DeliveryCompletionRateEntity>
    {
        [ColumnAttribute("Id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string Month { get; set; }
        public double DeliveryRate { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
