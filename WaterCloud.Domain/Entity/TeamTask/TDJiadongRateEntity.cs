using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.TeamTask
{
    [TableAttribute("Sys_TDJiadongRate")]
    public class TDJiadongRateEntity : IEntity<TDJiadongRateEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
