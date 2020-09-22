using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.QualityOptimization
{
    [TableAttribute("Sys_QEHAnomaliesList")]
    public class QEHAnomaliesListEntity : IEntity<QEHAnomaliesListEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string AbnormalOrderNumber { get; set; }
        public string ModuleNumber { get; set; }
        public string VersionNumber { get; set; }
        public string Workpiece { get; set; }
        public string WorkingProcedure { get; set; }
        public string AbnormalCauses { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
