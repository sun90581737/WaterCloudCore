using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.AutomationLine
{
    [TableAttribute("Sys_DataAcquisitionDetail")]
    public class DataAcquisitionDetailEntity : IEntity<DataAcquisitionDetailEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public DateTime? RunTime { get; set; }
        public string DeviceName { get; set; }
        public int? SpindleSpeed { get; set; }
        public int? FeedSpeed { get; set; }
        public int? SpindleRatio { get; set; }
        public int? FeedRatio { get; set; }
        public int? LoadRatio { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
