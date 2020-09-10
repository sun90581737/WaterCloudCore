using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.QualityOptimization
{
    [TableAttribute("Sys_QualityOInspectionPlan")]
    public class QualityOInspectionPlanEntity : IEntity<QualityOInspectionPlanEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int id { get; set; }
        public string MoldNumber { get; set; }
        public string Edition { get; set; }
        public string PartNumber { get; set; }
        public string InspectionProcess { get; set; }
        public string LastProcess { get; set; }
        public DateTime Start_Time { get; set; }
        public DateTime END_Time { get; set; }
        public string Colour { get; set; }
        public DateTime CreationTime { get; set; }
        public int IsEffective { get; set; }
    }
}
