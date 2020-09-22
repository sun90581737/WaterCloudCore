using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.QualityOptimization
{
    [TableAttribute("Sys_QEHAbnormalStatistics")]
    public class QEHAbnormalStatisticsEntity : IEntity<QEHAbnormalStatisticsEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string MouldNo { get; set; }
        public string ModuleNumber { get; set; }
        public string PartNumber { get; set; }
        public string AbnormalJobNumber { get; set; }
        public string TreatmentMethod { get; set; }
        public DateTime? AcctDate { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
