using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.OperationMonitoring
{
    [TableAttribute("Sys_CustomerDetailsList")]
    public class CustomerDetailsListEntity : IEntity<CustomerDetailsListEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string CustomerName { get; set; }
        public string OrderNumber { get; set; }
        public string NumberOfOrders { get; set; }
        public string DieNumber { get; set; }
        public string ProjectLeader { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EstimatedEndTime { get; set; }
        public DateTime? ActualEndTime { get; set; }
        public string NewOldModel { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
