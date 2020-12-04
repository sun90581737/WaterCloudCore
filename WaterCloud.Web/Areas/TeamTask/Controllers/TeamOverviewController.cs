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
    public class TeamOverviewController : ControllerBase
    {
        public TODepartmentJiaDongRateService _djrService { get; set; }

        public TOTeamLoadRateService _tlrService { get; set; }

        public TOTeamOverviewListService _tolService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetTODepartmentJiaDongRate()
        {
            var data = await _djrService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetTOTeamLoadRate()
        {
            var data = await _tlrService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "TeamName desc";
            var data = await _tolService.GetList(pagination);
            return Success(pagination.records, data);
        }
    }
}
