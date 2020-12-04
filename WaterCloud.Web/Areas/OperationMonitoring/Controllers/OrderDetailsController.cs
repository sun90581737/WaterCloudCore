using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chloe;
using Microsoft.AspNetCore.Mvc;
using WaterCloud.Code;
using WaterCloud.Service.Infrastructure;
using WaterCloud.Service.OperationMonitoring;

namespace WaterCloud.Web.Areas.OperationMonitoring.Controllers
{
    [Area("OperationMonitoring")]
    public class OrderDetailsController : ControllerBase
    {
        private readonly IODDeliveryCompletionRateService _DCRservice;
        private readonly IODOrderStatusService _OSservice;
        private readonly IODDeliveryRatioService _DRservice;
        private readonly IDbContext _context;

        public ODMouldProgressService _ODmpService { get; set; }
        public ODDelayMoldListService _ODdmlService { get; set; }
        public ODMouldListService _ODmlService { get; set; }

        public OrderDetailsController(IDbContext context)
        {
            string dbType = GlobalContext.SystemConfig.DBProvider;
            _context = context;
            switch (dbType)
            {
                case Define.DBTYPE_SQLSERVER:
                    _DCRservice = new ODDeliveryCompletionRateService(context);
                    _OSservice = new ODOrderStatusService(context);
                    _DRservice = new ODDeliveryRatioService(context);
                    break;
                case Define.DBTYPE_MYSQL:
                    _DCRservice = new ODDeliveryCompletionRateService(context);
                    _OSservice = new ODOrderStatusService(context);
                    _DRservice = new ODDeliveryRatioService(context);
                    break;
            }
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataODDeliveryCompletionRate(string keyValue)
        {
            var data = await _DCRservice.GetTableFieldList(keyValue);
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataODMouldProgress()
        {
            var data = await _ODmpService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "MoldNo desc";
            var data = await _ODdmlService.GetList(pagination);
            return Success(pagination.records, data);
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataODOrderStatus(string keyValue)
        {
            var data = await _OSservice.GetTableFieldList(keyValue);
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataODDeliveryRatio(string keyValue)
        {
            var data = await _DRservice.GetTableFieldList(keyValue);
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJsonOne(Pagination pagination, string keyvalue)
        {
            pagination.order = "desc";
            pagination.sort = "WorkingProcedure desc";
            var data = await _ODmlService.GetList(pagination, keyvalue);
            return Success(pagination.records, data);
        }
    }
}
