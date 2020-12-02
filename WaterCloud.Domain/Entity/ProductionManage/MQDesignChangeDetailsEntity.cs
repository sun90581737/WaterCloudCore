using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterCloud.Domain.Entity.ProductionManage
{
    [TableAttribute("Sys_MQDesignChangeDetails")]
    public class MQDesignChangeDetailsEntity:IEntity<MQDesignChangeDetailsEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string MoldNo { get; set; }
        public string DCSource { get; set; }
        public string DCContent { get; set; }
        public DateTime? DCTime { get; set; }
        public string ChangeOrderNo { get; set; }
        public string ChangeDescription { get; set; }
        public string ReasonForChange { get; set; }
        public string RelatedTests { get; set; }
        public string ChangeType { get; set; }
        public DateTime? EstimatedTime { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
