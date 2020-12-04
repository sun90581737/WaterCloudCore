using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WaterCloud.Code;
using WaterCloud.Service.OperationMonitoring;

namespace WaterCloud.Web.Areas.OperationMonitoring.Controllers
{
    [Area("OperationMonitoring")]
    public class PlanHomeController : ControllerBase
    {
        public PHProgressAnalysisService _paService { get; set; }
        public PHCustomerListService _clService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataPHProgressAnalysis()
        {
            var data = await _paService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination, string keyword = "")
        {
            pagination.order = "desc";
            pagination.sort = "CustomerName desc";
            var data = await _clService.GetList(pagination, keyword);
            return Success(pagination.records, data);
        }
    }
}
