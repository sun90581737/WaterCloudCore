using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.AutomationLine
{
    [TableAttribute("Sys_DataAcquisition")]
    public class DataAcquisitionEntity : IEntity<DataAcquisitionEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string DeviceName { get; set; }
        public string DeviceRunStatus { get; set; }
        public string DeviceUrl { get; set; }
        public string DeviceLndicatorLight { get; set; }
        public int? TodayOutput { get; set; }
        public double TodayJiadong { get; set; }
        public int? SpindleSpeed { get; set; }
        public int? FeedSpeed { get; set; }
        public int? SpindleRatio { get; set; }
        public int? FeedRatio { get; set; }
        public int? LoadRatio { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
