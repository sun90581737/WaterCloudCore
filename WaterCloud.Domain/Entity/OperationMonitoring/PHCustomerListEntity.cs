using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.OperationMonitoring
{
    [TableAttribute("Sys_PHCustomerList")]
    public class PHCustomerListEntity : IEntity<PHCustomerListEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string CustomerName { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerContact { get; set; }
        public string LeadingCadre { get; set; }
        public string DeliveryRate { get; set; }
        public int? MouldNumber { get; set; }
        public int? NormalMold { get; set; }
        public int? DelayMould { get; set; }
        public string Colour { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
