using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.TeamTask
{
    [TableAttribute("Sys_FitterHomepageList")]
    public class FitterHomepageListEntity : IEntity<FitterHomepageListEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string ProductName { get; set; }
        public string MoldNumber { get; set; }
        public DateTime? ReceivingDate { get; set; }
        public DateTime? CustomerDelivery { get; set; }
        public string MoldType { get; set; }
        public DateTime? PlannedDeliveryDate { get; set; }
        public string MachineTonnage { get; set; }
        public string IsSlider { get; set; }
        public string ProductSize { get; set; }
        public string RunnerSystem { get; set; }
        public string Fitter { get; set; }
        public string MoldStatus { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
