using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chloe;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using WaterCloud.Code;
using WaterCloud.Service.Infrastructure;
using WaterCloud.Service.MouldDesign;

namespace WaterCloud.Web.Areas.MouldDesign.Controllers
{
    [Area("MouldDesign")]
    public class DesignHomeController : ControllerBase
    {
        public DHDesignTaskListService _dtlService { get; set; }
        private readonly IDHDesignReportStatisticsService _DRSservice;
        private readonly IDHDesignComparisonService _DCservice;
        private readonly IDHWorkloadAnalysisService _WAservice;
        private readonly IDbContext _context;

        public DesignHomeController(IDbContext context)
        {
            string dbType = GlobalContext.SystemConfig.DBProvider;
            _context = context;
            switch (dbType)
            {
                case Define.DBTYPE_SQLSERVER:
                    _DRSservice = new DHDesignReportStatisticsService(context);
                    _DCservice=new DHDesignComparisonService(context);
                    _WAservice = new DHWorkloadAnalysisService(context);
                    break;
                case Define.DBTYPE_MYSQL:
                    _DRSservice = new DHDesignReportStatisticsService(context);
                    _DCservice = new DHDesignComparisonService(context);
                    _WAservice = new DHWorkloadAnalysisService(context);
                    break;
            }
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataDHDesignReportStatistics(string keyValue)
        {
            var data = await _DRSservice.GetTableFieldList(keyValue);
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataDHDesignComparison(string keyValue)
        {
            var data = await _DCservice.GetTableFieldList(keyValue);
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataDHWorkloadAnalysis(string keyValue)
        {
            var data = await _WAservice.GetTableFieldList(keyValue);
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination, string keyvalue)
        {
            pagination.order = "desc";
            pagination.sort = "ModuleNumber desc";
            var data = await _dtlService.GetList(pagination, keyvalue);
            return Success(pagination.records, data);
        }
    }
}
