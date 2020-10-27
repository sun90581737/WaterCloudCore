using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.OperationMonitoring
{
    [TableAttribute("Sys_ODDelayMoldList")]
    public class ODDelayMoldListEntity : IEntity<ODDelayMoldListEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string MoldNo { get; set; }
        public string Customers { get; set; }
        public string Type { get; set; }
        public DateTime? PlannedDeliveryDate { get; set; }
        public string EarlyWarning { get; set; }
        public int? IsEffective { get; set; }
    }
}
