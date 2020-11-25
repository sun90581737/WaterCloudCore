using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterCloud.Domain.Entity.TeamTask
{
    [TableAttribute("Sys_ADOutsourcingPartsList")]
    public class ADOutsourcingPartsListEntity : IEntity<ADOutsourcingPartsListEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string MoldNo { get; set; }
        public string WorkpieceNo { get; set; }
        public string WorkpieceName { get; set; }
        public string Material { get; set; }
        public string Hardness { get; set; }
        public string Specifications { get; set; }
        public DateTime? PlannedDeliveryDate { get; set; }
        public DateTime? ActualDeliveryDate { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
