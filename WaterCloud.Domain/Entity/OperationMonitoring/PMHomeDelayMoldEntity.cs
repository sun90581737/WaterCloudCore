using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.OperationMonitoring
{
    [TableAttribute("Sys_PMHomeDelayMold")]
    public class PMHomeDelayMoldEntity : IEntity<PMHomeDelayMoldEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int id { get; set; }
        public string MoldNo { get; set; }
        public string Edition { get; set; }
        public string Type { get; set; }
        public DateTime PlannedDeliveryDate { get; set; }
        public string Progress { get; set; }
        public string ProgressColor { get; set; }
        public int IsEffective { get; set; }
    }
}
