using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using WaterCloud.Service.ProcessScheduling;

namespace WaterCloud.Web.Areas.ProcessScheduling.Controllers
{
    [Area("ProcessScheduling")]
    public class ProcessDetailsController : ControllerBase
    {
        public PSProcessDetailsListService _pdlService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetPSProcessDetailsList()
        {
            var data = await _pdlService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
    }
}
