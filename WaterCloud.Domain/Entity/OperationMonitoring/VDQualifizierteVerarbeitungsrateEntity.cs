using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterCloud.Domain.Entity.OperationMonitoring
{
    [TableAttribute("Sys_VDQualifizierteVerarbeitungsrate")]
    public class VDQualifizierteVerarbeitungsrateEntity: IEntity<VDQualifizierteVerarbeitungsrateEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string DeviceType { get; set; }
        public string DeviceName { get; set; }
        public int? Number { get; set; }
        public string Type { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
