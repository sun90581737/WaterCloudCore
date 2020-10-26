using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using WaterCloud.Code;
using WaterCloud.Service.OperationMonitoring;

namespace WaterCloud.Web.Areas.OperationMonitoring.Controllers
{
    [Area("OperationMonitoring")]
    public class CustomerDetailsController : ControllerBase
    {
        public CustomerDetailsRateService _cdrService { get; set; }
        public CustomerDetailsListService _crlService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetCustomerDetailsRate()
        {
            var data = await _cdrService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "CustomerName desc";
            var data = await _crlService.GetList(pagination);
            return Success(pagination.records, data);
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJsonKey(Pagination pagination, string keyvalue)
        {
            pagination.order = "desc";
            pagination.sort = "CustomerName desc";
            var data = await _crlService.GetListKey(pagination, keyvalue);
            return Success(pagination.records, data);
        }
    }
}
