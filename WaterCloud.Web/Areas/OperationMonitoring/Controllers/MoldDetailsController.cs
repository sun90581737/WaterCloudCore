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
    public class MoldDetailsController : ControllerBase
    {
        public MDMoldPassRateService _mprService { get; set; }
        public MDMoldProcessingProgressService _mppService { get; set; }
        public MDMoldProcessingListService _mplService { get; set; }

        private readonly IMDTotalMoldCostService _TMCservice;
        private readonly IMDWorkpieceTypeProportionService _WTPservice;
        private readonly IDbContext _context;

        public MoldDetailsController(IDbContext context)
        {
            string dbType = GlobalContext.SystemConfig.DBProvider;
            _context = context;
            switch (dbType)
            {
                case Define.DBTYPE_SQLSERVER:
                    _TMCservice = new MDTotalMoldCostService(context);
                    _WTPservice = new MDWorkpieceTypeProportionService(context);
                    break;
                case Define.DBTYPE_MYSQL:
                    _TMCservice = new MDTotalMoldCostService(context);
                    _WTPservice = new MDWorkpieceTypeProportionService(context);
                    break;
            }
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetMDMoldPassRate()
        {
            var data = await _mprService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetMDTotalMoldCost(string keyValue)
        {
            var data = await _TMCservice.GetTableFieldList(keyValue);
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetMDMoldProcessingProgress()
        {
            var data = await _mppService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "PlannedDeliveryDate desc";
            var data = await _mplService.GetList(pagination);
            return Success(pagination.records, data);
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetMDWorkpieceTypeProportion(string keyValue)
        {
            var data = await _WTPservice.GetTableFieldList(keyValue);
            return Content(data.ToJson());
        }
    }
}
