using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.TeamTask
{
    [TableAttribute("Sys_TOTeamOverviewList")]
    public class TOTeamOverviewListEntity : IEntity<TOTeamOverviewListEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string TeamName { get; set; }
        public string Personnel { get; set; }
        public string Equipment { get; set; }
        public int? JDongRate { get; set; }
        public double ProcessLoad { get; set; }
        public double PassRate { get; set; }
        public string TreatMachining { get; set; }
        public string Processing { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
