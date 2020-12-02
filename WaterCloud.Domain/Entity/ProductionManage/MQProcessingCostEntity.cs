using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterCloud.Domain.Entity.ProductionManage
{
    [TableAttribute("Sys_MQProcessingCost")]
    public class MQProcessingCostEntity:IEntity<MQProcessingCostEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string WorkingGroup { get; set; }
        public string ProcessName { get; set; }
        public string Operator { get; set; }
        public string MoldNo { get; set; }
        public string VersionNumber { get; set; }
        public string WorkpieceNumber { get; set; }
        public int? NumberOfWorkpieces { get; set; }
        public string PartName { get; set; }
        public string ProcessManHour { get; set; }
        public string ActualWorkingHours { get; set; }
        public string OutputHours { get; set; }
        public string ProcessingEfficiency { get; set; }
        public string AssignPersonnel { get; set; }
        public DateTime? AllocateTime { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
