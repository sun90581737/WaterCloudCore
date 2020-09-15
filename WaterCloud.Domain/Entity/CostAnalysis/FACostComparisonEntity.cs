using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.CostAnalysis
{
    [TableAttribute("Sys_FACostComparison")]
    public class FACostComparisonEntity : IEntity<FACostComparisonEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string Customer { get; set; }
        public string MoldNo { get; set; }
        public string MoldName { get; set; }
        public DateTime? ReceivingDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public double QuotedPrice { get; set; }
        public string QuotationStaff { get; set; }
        public double ProcessEstimation { get; set; }
        public double ActualCost { get; set; }
        public string DifferenceAmount { get; set; }
        public string DifferenceRatio { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
