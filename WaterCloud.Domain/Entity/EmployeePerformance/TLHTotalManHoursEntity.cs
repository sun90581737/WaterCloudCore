using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.EmployeePerformance
{
    [TableAttribute("Sys_TLHTotalManHours")]
    public class TLHTotalManHoursEntity : IEntity<TLHTotalManHoursEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string DeviceType { get; set; }
        public string DeviceName { get; set; }
        public int? Number { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
