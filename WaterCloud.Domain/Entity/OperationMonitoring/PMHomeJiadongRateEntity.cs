using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.OperationMonitoring
{
    [TableAttribute("Sys_PMHomeJiadongRate")]
    public class PMHomeJiadongRateEntity : IEntity<PMHomeJiadongRateEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int id { get; set; }
        public string Month_Day { get; set; }
        public string Device_Name { get; set; }
        public double TrendRate { get; set; }
        public DateTime CreationTime { get; set; }
        public int IsEffective { get; set; }
    }
}
