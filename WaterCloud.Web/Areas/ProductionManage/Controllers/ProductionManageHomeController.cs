using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using WaterCloud.Code;
using WaterCloud.Service.OperationMonitoring;

namespace WaterCloud.Web.Areas.ProductionManage.Controllers
{
    [Area("ProductionManage")]
    public class ProductionManageHomeController : ControllerBase
    {
        public PMHomeDepartmentQualityStatisticsService _pdqsService { get; set; }
        public PMHomeCapacityLoadService _clService { get; set; }
        public PMHomeOutsourcingRateService _orService { get; set; }
        public PMHomeOutsourcingDetailService _odService { get; set; }


        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataDepartmentQualityStatistics()
        {
            var data = await _pdqsService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataPMHomeCapacityLoad()
        {
            var data = await _clService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataPMHomeOutsourcingRate()
        {
            var data = await _orService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "PlannedDeliveryDate desc";
            var data = await _odService.GetList(pagination);
            return Success(pagination.records, data);
        }
    }
}
