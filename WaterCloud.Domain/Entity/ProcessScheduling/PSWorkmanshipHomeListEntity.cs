using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.ProcessScheduling
{
    [TableAttribute("Sys_PSWorkmanshipHomeList")]
    public class PSWorkmanshipHomeListEntity : IEntity<PSWorkmanshipHomeListEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public string id { get; set; }
        public string MoldNo { get; set; }
        public string TENo { get; set; }
        public string MoldType { get; set; }
        public string ModelProtection { get; set; }
        public string MoldState { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? TestDate { get; set; }
        public string PartNumber { get; set; }
        public string PartName { get; set; }
        public string Describe { get; set; }
        public string Type { get; set; }
        public int? Number { get; set; }
        public string MaterialScience { get; set; }
        public string Hardness { get; set; }
        public string Specifications { get; set; }
        public string Formwork { get; set; }
        public string ProductionDeliveryDate { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
