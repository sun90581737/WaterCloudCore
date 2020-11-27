using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterCloud.Domain.Entity.QualityOptimization
{
    [TableAttribute("Sys_QualityExceptionQueryList")]
    public class QualityExceptionQueryListEntity:IEntity<QualityExceptionQueryListEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public int? ParentId { get; set; }
        public string Department { get; set; }
        public string WorkingProcedure { get; set; }
        public int? Pending { get; set; }
        public int? TeCai { get; set; }
        public int? Rework { get; set; }
        public int? Repair { get; set; }
        public int? Scrap { get; set; }
        public int? Total { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
