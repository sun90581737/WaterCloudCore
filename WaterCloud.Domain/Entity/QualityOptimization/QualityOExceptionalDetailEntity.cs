using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.QualityOptimization
{
    [TableAttribute("Sys_QualityOExceptionalDetail")]
    public class QualityOExceptionalDetailEntity : IEntity<QualityOExceptionalDetailEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int id { get; set; }
        public string ProjectNo { get; set; }
        public string ModuleNumber { get; set; }
        public string WorkpieceNo { get; set; }
        public string ExceptionalProcedure { get; set; }
        public string TreatmentMethod { get; set; }
        public string Colour { get; set; }
        public DateTime CreationTime { get; set; }
        public int IsEffective { get; set; }
    }
}
