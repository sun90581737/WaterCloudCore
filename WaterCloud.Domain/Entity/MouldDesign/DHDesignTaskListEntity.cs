using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.MouldDesign
{
    [TableAttribute("Sys_DHDesignTaskList")]
    public class DHDesignTaskListEntity : IEntity<DHDesignTaskListEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string ModuleNumber { get; set; }
        public string VersionNumber { get; set; }
        public DateTime? PlanStartTime { get; set; }
        public DateTime? PlanEndTime { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
