using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.CostAnalysis
{
    [TableAttribute("Sys_FACostByDepartment")]
    public class FACostByDepartmentEntity : IEntity<FACostByDepartmentEntity>
    {
        public string Name { get; set; }
        public double Cost { get; set; }
        public DateTime? AcctDate { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
