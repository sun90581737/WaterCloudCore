using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using WaterCloud.Service.OperationMonitoring;

namespace WaterCloud.Web.Areas.ProductionManage.Controllers
{
    [Area("ProductionManage")]
    public class ProductionManageHomeController : ControllerBase
    {
        public PMHomeDepartmentQualityStatisticsService _pdqsService { get; set; }


        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataDepartmentQualityStatistics()
        {
            var data = await _pdqsService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
    }
}
