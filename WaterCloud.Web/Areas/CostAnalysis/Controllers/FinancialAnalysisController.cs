using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chloe;
using Microsoft.AspNetCore.Mvc;
using WaterCloud.Code;
using WaterCloud.Service.CostAnalysis;
using WaterCloud.Service.Infrastructure;

namespace WaterCloud.Web.Areas.CostAnalysis.Controllers
{
    [Area("CostAnalysis")]
    public class FinancialAnalysisController : ControllerBase
    {
        private readonly IFATotalCycleCostService _service;
        private readonly IFACostByDepartmentService _Coservice;
        private readonly IFACostAnalysisService _Anaservice;
        private readonly IFACostAnalysisNotCustService _ANCservice;
        private readonly IDbContext _context;
        public FACostShareService _faCSService { get; set; }
        public FACostComparisonService _faCCService { get; set; }

        public FinancialAnalysisController(IDbContext context)
        {
            string dbType = GlobalContext.SystemConfig.DBProvider;
            _context = context;
            switch (dbType)
            {
                case Define.DBTYPE_SQLSERVER:
                    _service = new FATotalCycleCostService(context);
                    _Coservice= new FACostByDepartmentService(context);
                    _Anaservice= new FACostAnalysisService(context);
                    _ANCservice=new FACostAnalysisNotCustService(context);
                    break;
                case Define.DBTYPE_MYSQL:
                    _service = new FATotalCycleCostService(context);
                    _Coservice= new FACostByDepartmentService(context);
                    _Anaservice = new FACostAnalysisService(context);
                    _ANCservice = new FACostAnalysisNotCustService(context);
                    break;
            }
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataFATotalCycleCost(string keyValue)
        {
            var data = await _service.GetTableFieldList(keyValue);
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataFACostByDepartment(string keyValue)
        {
            var data = await _Coservice.GetTableFieldList(keyValue);
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataFACostAnalysis(string keyValue)
        {
            var data = await _Anaservice.GetTableFieldList(keyValue);
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataFACostAnalysisNotCust(string keyValue)
        {
            var data = await _ANCservice.GetTableFieldList(keyValue);
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetFACostShare()
        {
            var data = await _faCSService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination, string keyword = "")
        {
            pagination.order = "desc";
            pagination.sort = "MoldNo desc";
            var data = await _faCCService.GetList(pagination, keyword);
            return Success(pagination.records, data);
        }
    } 
}
