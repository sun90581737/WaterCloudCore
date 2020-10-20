using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using WaterCloud.Code;
using WaterCloud.Domain.Entity.TeamTask;
using WaterCloud.Service.TeamTask;

namespace WaterCloud.Web.Areas.TeamTask.Controllers
{
    [Area("TeamTask")]
    public class TeamDetailsController : ControllerBase
    {
        public TDDepartmentQualifiedRateService _dqrService { get; set; }
        public TDDepartmentLoadService _dlService { get; set; }
        public TDJiadongRateService _jrService { get; set; }


        public TDDepartmentTasksService _dtService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetTDDepartmentQualifiedRate()
        {
            var data = await _dqrService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetTDDepartmentLoad()
        {
            var data = await _dlService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetTDJiadongRate()
        {
            var data = await _jrService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }


        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJsonOne(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "RepairOrderNo desc";
            var data = await _dtService.GetList(pagination);
            return Success(pagination.records, data);
        }
    }
}
