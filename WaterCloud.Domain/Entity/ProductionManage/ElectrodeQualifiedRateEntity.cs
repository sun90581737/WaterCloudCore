using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.ProductionManage
{
    [TableAttribute("Sys_ElectrodeQualifiedRate")]
    public class ElectrodeQualifiedRateEntity : IEntity<ElectrodeQualifiedRateEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string MonthDay { get; set; }
        public string DeviceName { get; set; }
        public double TrendRate { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
