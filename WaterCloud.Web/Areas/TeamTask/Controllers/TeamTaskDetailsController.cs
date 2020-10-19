using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WaterCloud.Code;
using WaterCloud.Service.TeamTask;

namespace WaterCloud.Web.Areas.TeamTask.Controllers
{
    [Area("TeamTask")]
    public class TeamTaskDetailsController : ControllerBase
    {
        public TeamTaskDetailsListService _ttdlService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "MoldNo desc";
            var data = await _ttdlService.GetList(pagination);
            return Success(pagination.records, data);
        }
    }
}
