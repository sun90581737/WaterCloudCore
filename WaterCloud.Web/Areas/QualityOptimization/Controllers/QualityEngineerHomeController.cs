using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WaterCloud.Code;
using WaterCloud.Service.QualityOptimization;

namespace WaterCloud.Web.Areas.QualityOptimization.Controllers
{
    [Area("QualityOptimization")]
    public class QualityEngineerHomeController : ControllerBase
    {

        public QEHAbnormalProportionService _apService { get; set; }
        public QEHAbnormalStatisticsService _asService { get; set; }
        public QEHAbnormalRatioService _arService { get; set; }
        public QEHAnomaliesNumberService _anService { get; set; }
        public QEHAnomaliesListService _alService { get; set; }


        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataQEHAbnormalProportion()
        {
            var data = await _apService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination, string keyvalue)
        {
            pagination.order = "desc";
            pagination.sort = "MouldNo desc";
            var data = await _asService.GetList(pagination, keyvalue);
            return Success(pagination.records, data);
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataQEHAbnormalRatio()
        {
            var data = await _arService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataQEHAnomaliesNumber()
        {
            var data = await _anService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJsonOne(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "AbnormalOrderNumber desc";
            var data = await _alService.GetList(pagination);
            return Success(pagination.records, data);
        }
    }
}
