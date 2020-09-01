using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.ProductionManage
{
    [TableAttribute("Sys_CustomerListDetail")]
    public class CustomerListDetailEntity : IEntity<CustomerListDetailEntity>
    {
        [ColumnAttribute("Id", IsPrimaryKey = true)]
        public int Id { get; set; }
        public int ListId { get; set; }
        public string MoldName { get; set; }
        public string MoldNo { get; set; }

        public string CustomerName { get; set; }
        public string ContactPerson { get; set; }

        public string TN { get; set; }
        public string MoldType { get; set; }
        public string MoldState { get; set; }
        //public string Priority { get; set; }	
        public DateTime MoldDate { get; set; }
        //public string MoldFactory { get; set; }	
        public string MoldMaterial { get; set; }
        public string Category { get; set; }
        public string Colour { get; set; }
        public DateTime CreationTime { get; set; }
        public int IsEffective { get; set; }
    }
}
