using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using WaterCloud.Service.AutomationLine;

namespace WaterCloud.Web.Areas.AutomationLine.Controllers
{
    [Area("AutomationLine")]
    public class DataAcquisitionController : ControllerBase
    {
        public DataAcquisitionService _daService { get; set; }
        public DataAcquisitionDetailService _dadService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataAcquisition()
        {
            var data = await _daService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataAcquisitionDetail()
        {
            var data = await _dadService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
    }
}
