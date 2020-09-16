using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using WaterCloud.Code;
using WaterCloud.Service.ProcessScheduling;

namespace WaterCloud.Web.Areas.ProcessScheduling.Controllers
{
    [Area("ProcessScheduling")]
    public class SchedulingHomeController : ControllerBase
    {
        public SHDepartmentLoadService _dlService { get; set; }
        public SHToScheduleListService _slService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataSHDepartmentLoad()
        {
            var data = await _dlService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "MoldNumber desc";
            var data = await _slService.GetList(pagination);
            return Success(pagination.records, data);
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJsonOne(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "MoldNumber desc";
            var data = await _slService.GetListOne(pagination);
            return Success(pagination.records, data);
        }
    }
}
