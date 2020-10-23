using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.QualityOptimization
{
    [TableAttribute("Sys_QOExceptionDetailsList")]
    public class QOExceptionDetailsListEntity : IEntity<QOExceptionDetailsListEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string ExceptionNumber { get; set; }
        public string ExceptionModule { get; set; }
        public string FaultDescription { get; set; }
        public string Department { get; set; }
        public string ResponsibleProcess { get; set; }
        public string PersonLiable { get; set; }
        public string ResponsibleSupplier { get; set; }
        public string AnomalyTracking { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
