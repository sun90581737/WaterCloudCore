using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.OperationMonitoring
{
    [TableAttribute("Sys_PMHomeOutsourcingDetail")]
    public class PMHomeOutsourcingDetailEntity : IEntity<PMHomeOutsourcingDetailEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int id { get; set; }
        public string ModuleNumber { get; set; }
        public string WorkpieceNo { get; set; }
        public string WorkingProcedure { get; set; }
        public string Supplier { get; set; }
        public DateTime PlannedDeliveryDate { get; set; }
        public int DaysOfExtension { get; set; }
        public string DaysOfExtensionColor { get; set; }
        public string OrderStatus { get; set; }
        public DateTime CreationTime { get; set; }
        public int IsEffective { get; set; }
    }
}
