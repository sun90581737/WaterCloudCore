using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WaterCloud.Code;
using WaterCloud.Service.EmployeePerformance;

namespace WaterCloud.Web.Areas.EmployeePerformance.Controllers
{
    [Area("EmployeePerformance")]
    public class TeamLeaderHomepageController : ControllerBase
    {
        public TLHTotalManHoursService _tmhService { get; set; }
        public TLHPassRateService _prService { get; set; }
        public TLHAttendanceRateService _arService { get; set; }
        public TLHTeamPerformanceService _tpService { get; set; }
        public TLHTeamTaskService _ttService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetTLHTotalManHours()
        {
            var data = await _tmhService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetTLHPassRate()
        {
            var data = await _prService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetTLHAttendanceRate()
        {
            var data = await _arService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetTLHTeamPerformance()
        {
            var data = await _tpService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "MoldNo desc";
            var data = await _ttService.GetList(pagination);
            return Success(pagination.records, data);
        }
    }
}
