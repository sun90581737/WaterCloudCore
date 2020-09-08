using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.OperationMonitoring
{
    [TableAttribute("Sys_PMHomeCapacityLoad")]
    public class PMHomeCapacityLoadEntity : IEntity<PMHomeCapacityLoadEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int id { get; set; }
        public string DeviceType { get; set; }
        public string DeviceName { get; set; }
        public int Number { get; set; }
        //public int PrType { get; set; }
        public string Colour { get; set; }
        public DateTime? AcctDate { get; set; }
        public DateTime CreationTime { get; set; }
        public int IsEffective { get; set; }
    }
}
