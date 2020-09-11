using WaterCloud.Service.SystemOrganize;
using WaterCloud.Code;
using WaterCloud.Domain.SystemOrganize;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WaterCloud.Domain.SystemSecurity;
using WaterCloud.Service;
using WaterCloud.Service.SystemSecurity;
using System;
using Serenity;
using System.Threading.Tasks;
using WaterCloud.Service.SystemManage;
using WaterCloud.Service.ProductionManage;

namespace WaterCloud.Web.Areas.OperationMonitoring.Controllers
{
    [Area("OperationMonitoring")]
    public class EngineeringHomepageController : ControllerBase
    {
        public UserEngineeringService _ueService { get; set; }
        public EHNumberMoldsDeliveredService _EHnmdService { get; set; }
        public EHDeliveryCompletionRateService _EHdcrService { get; set; }
        public EHProductionScheduleService _EHpsService { get; set; }
        public EHDelayMoldListService _EHdmlService { get; set; }
        public CustomerListDetailService _cldService { get; set; }


        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataUserEngineeringList()
        {
            var data = await _ueService.GetList();
            data = data.Where(p => p.IsEffective == 1 && p.IsManage == true).ToList();
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataUserEngineeringListStaff()
        {
            var temp = OperatorProvider.Provider.GetCurrent();
            var data = await _ueService.GetList();
            data = data.Where(p => p.IsEffective == 1 && p.IsManage == false && p.Account == temp.UserCode).ToList();
            foreach (var item in data)
            {
                item.Account = temp.UserName;
            }
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataEHNumberMoldsDelivered()
        {
            var data = await _EHnmdService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }


        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataEHDeliveryCompletionRate()
        {
            var data = await _EHdcrService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataEHProductionSchedule()
        {
            var data = await _EHpsService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "MoldNo desc";
            var data = await _EHdmlService.GetList(pagination);
            return Success(pagination.records, data);
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJsonOn(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "MoldNo desc";
            var data = await _cldService.GetList(pagination);
            return Success(pagination.records, data);
        }
    }
}
