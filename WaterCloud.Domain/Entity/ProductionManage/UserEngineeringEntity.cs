using Chloe.Annotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace WaterCloud.Domain.Entity.ProductionManage
{
    [TableAttribute("Sys_UserEngineering")]
    public class UserEngineeringEntity : IEntity<UserEngineeringEntity>
    {
        [ColumnAttribute("id", IsPrimaryKey = true)]
        public int? id { get; set; }
        public string Account { get; set; }
        //public string RealName { get; set; }
        public int? CustomerAmount { get; set; }
        public string CustomerAmountColor { get; set; }
        public int? DeliveryCompletionRate { get; set; }
        public string DeliveryCompletionRateColor { get; set; }
        public int? OnTimeDeliveryMold { get; set; }
        public string OnTimeDeliveryMoldColor { get; set; }
        public int? LateDeliveryMold { get; set; }
        public string LateDeliveryMoldColor { get; set; }
        public int? MoldInProcess { get; set; }
        public string MoldInProcessColor { get; set; }
        public int? NormalProgress { get; set; }
        public string NormalProgressColor { get; set; }
        public int? ScheduleDelay { get; set; }
        public string ScheduleDelayColor { get; set; }
        public bool? IsManage { get; set; }
        public DateTime? CreationTime { get; set; }
        public int? IsEffective { get; set; }
    }
}
