using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.ProductionManage
{
    [TableAttribute("Sys_EHDeliveryCompletionRate")]
    public class EHDeliveryCompletionRateEntity : IEntity<EHDeliveryCompletionRateEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string Month { get; set; }
        public int? DeliveryRate { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
