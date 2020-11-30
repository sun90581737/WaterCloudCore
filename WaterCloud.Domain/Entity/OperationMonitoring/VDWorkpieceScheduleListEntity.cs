using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterCloud.Domain.Entity.OperationMonitoring
{
    [TableAttribute("Sys_VDWorkpieceScheduleList")]
    public class VDWorkpieceScheduleListEntity : IEntity<VDWorkpieceScheduleListEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string MoldNo { get; set; }
        public string PartNumber { get; set; }
        public string PlannedEquipment { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? ENDTime { get; set; }
        public DateTime? LatestStartTime { get; set; }
        public string WorkingHours { get; set; }
        public string Customer { get; set; }
        public string EarlyWarning { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
