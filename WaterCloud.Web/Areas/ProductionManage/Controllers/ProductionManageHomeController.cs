using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WaterCloud.Code;
using WaterCloud.Service.OperationMonitoring;

namespace WaterCloud.Web.Areas.ProductionManage.Controllers
{
    [Area("ProductionManage")]
    public class ProductionManageHomeController : ControllerBase
    {
        public PMHomeMoldProgressService _mpService { get; set; }
        public PMHomeDelayMoldService _dmService { get; set; }
        public PMHomeCapacityLoadService _clService { get; set; }
        public PMHomeOutsourcingRateService _orService { get; set; }
        public PMHomeOutsourcingDetailService _odService { get; set; }
        public PMHomeJiadongRateService _jrService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataPMHomeMoldProgress()
        {
            var data = await _mpService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJsonOn(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "MoldNo desc";
            var data = await _dmService.GetList(pagination);
            return Success(pagination.records, data);
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
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataPMHomeJiadongRate()
        {
            var data = await _jrService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
    }
}
