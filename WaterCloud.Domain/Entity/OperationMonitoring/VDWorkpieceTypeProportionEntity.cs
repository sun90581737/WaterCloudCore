using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterCloud.Domain.Entity.OperationMonitoring
{
    [TableAttribute("Sys_VDWorkpieceTypeProportion")]
    public class VDWorkpieceTypeProportionEntity : IEntity<VDWorkpieceTypeProportionEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public DateTime? AcctDate { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
