using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WaterCloud.Code;
using WaterCloud.Service.ProcessScheduling;

namespace WaterCloud.Web.Areas.ProcessScheduling.Controllers
{
    [Area("ProcessScheduling")]
    public class WorkpieceDetailsController : ControllerBase
    {
        public PSWorkpieceDetailsListService _wdlService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "MoldNo desc";
            var data = await _wdlService.GetList(pagination);
            return Success(pagination.records, data);
        }
    }
}
