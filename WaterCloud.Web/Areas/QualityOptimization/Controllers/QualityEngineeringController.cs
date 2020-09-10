using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using WaterCloud.Code;
using WaterCloud.Service.QualityOptimization;

namespace WaterCloud.Web.Areas.QualityOptimization.Controllers
{
    [Area("QualityOptimization")]
    public class QualityEngineeringController : ControllerBase
    {
        public QualityOInspectionPlanService _qoipService { get; set; }
        public QualityOTeamPassRateService _qotrService { get; set; }
        public QualityOExceptionalResultsService _qoerService { get; set; }
        public QualityOExceptionalDetailService _qoedService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJsonOn(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "MoldNumber desc";
            var data = await _qoipService.GetList(pagination);
            return Success(pagination.records, data);
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataQualityOTeamPassRate()
        {
            var data = await _qotrService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataQualityOExceptionalResults()
        {
            var data = await _qoerService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "ProjectNo desc";
            var data = await _qoedService.GetList(pagination);
            return Success(pagination.records, data);
        }
    }
}
