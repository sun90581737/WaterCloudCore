using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterCloud.Domain.Entity.ProductionManage
{
    [TableAttribute("Sys_MQVersionList")]
    public class MQVersionListEntity:IEntity<MQVersionListEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string MoldNo { get; set; }
        public string Customer { get; set; }
        public string MoldType { get; set; }
        public DateTime? MoldOpeningDate { get; set; }
        public DateTime? MoldTestDate { get; set; }
        public string PersonInCharge { get; set; }
        public string MachineTonnage { get; set; }
        public string MoldTestTimes { get; set; }
        public string FitterLeader { get; set; }
        public string FitterInCharge { get; set; }
        public string IsApproval { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
