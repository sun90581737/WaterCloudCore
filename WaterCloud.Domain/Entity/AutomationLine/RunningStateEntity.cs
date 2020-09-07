using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.AutomationLine
{
    [TableAttribute("Sys_RunningState")]
    public class RunningStateEntity : IEntity<RunningStateEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string Picture_Tip { get; set; }
        public string Picture_Url { get; set; }
        public string Describe1 { get; set; }
        public string DescribeColor1 { get; set; }
        public string Describe2 { get; set; }
        public string DescribeColor2 { get; set; }
        public string Describe3 { get; set; }
        public string DescribeColor3 { get; set; }
        public string Describe4 { get; set; }
        public string DescribeColor4 { get; set; }
        public string Describe5 { get; set; }
        public string DescribeColor5 { get; set; }
        public string Describe6 { get; set; }
        public string DescribeColor6 { get; set; }
        public string Describe7 { get; set; }
        public string DescribeColor7 { get; set; }
        public string Describe8 { get; set; }
        public string DescribeColor8 { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
