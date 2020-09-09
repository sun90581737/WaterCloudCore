using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.OperationMonitoring
{
    [TableAttribute("Sys_PMHomeMoldProgress")]
    public class PMHomeMoldProgressEntity : IEntity<PMHomeMoldProgressEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int id { get; set; }
        public string ProgressStatus { get; set; }
        public int Cost { get; set; }
        public string Display { get; set; }
        public DateTime CreationTime { get; set; }
        public int IsEffective { get; set; }
    }
}
