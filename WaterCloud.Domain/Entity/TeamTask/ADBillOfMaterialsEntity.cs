using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterCloud.Domain.Entity.TeamTask
{
    [TableAttribute("Sys_ADBillOfMaterials")]
    public class ADBillOfMaterialsEntity : IEntity<ADBillOfMaterialsEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string MoldNo { get; set; }
        public string TENo { get; set; }
        public string PartNumber { get; set; }
        public string PartName { get; set; }
        public string Type { get; set; }
        public int? Number { get; set; }
        public string Brand { get; set; }
        public string Material { get; set; }
        public string Hardness { get; set; }
        public string Specifications { get; set; }
        public string Receiver { get; set; }
        public DateTime? ReceivingTime { get; set; }
        public string TableType { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
