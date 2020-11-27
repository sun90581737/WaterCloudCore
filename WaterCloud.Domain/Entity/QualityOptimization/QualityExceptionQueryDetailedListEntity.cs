using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterCloud.Domain.Entity.QualityOptimization
{
    [TableAttribute("Sys_QualityExceptionQueryDetailedList")]
    public class QualityExceptionQueryDetailedListEntity:IEntity<QualityExceptionQueryDetailedListEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public int? SubID { get; set; }
        public string QualityNo { get; set; }
        public string MoldNo { get; set; }
        public string WorkpieceNo { get; set; }
        public string WorkpieceName { get; set; }
        public string ProcessingProcedure { get; set; }
        public string ResponsibleDepartment { get; set; }
        public string PersonLiable { get; set; }
        public string QualityInspectionType { get; set; }
        public string TestContent { get; set; }
        public string DetectionResult { get; set; }
        public string Judge { get; set; }
        public string ExceptionType { get; set; }
        public string ProcessingResults { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
