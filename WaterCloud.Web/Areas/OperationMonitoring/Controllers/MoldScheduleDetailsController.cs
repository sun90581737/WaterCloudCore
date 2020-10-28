using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using WaterCloud.Service.OperationMonitoring;

namespace WaterCloud.Web.Areas.OperationMonitoring.Controllers
{
    [Area("OperationMonitoring")]
    public class MoldScheduleDetailsController : ControllerBase
    {
        public MSDCostRatioService _crService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataMSDCostRatio()
        {
            var data = await _crService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
    }
}
