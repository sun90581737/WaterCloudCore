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
    public class RunningStateController : ControllerBase
    {
        public RunningStateService _stateService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetRunningState()
        {
            var data = await _stateService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
    }
}
