using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.TeamTask
{
    [TableAttribute("Sys_TDJiadongRateTrend")]
    public class TDJiadongRateTrendEntity : IEntity<TDJiadongRateTrendEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string DeviceType { get; set; }
        public string DeviceName { get; set; }
        public int? Number { get; set; }
        public string Spare { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
