using Chloe;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterCloud.Code;
using WaterCloud.Service.EmployeePerformance;
using WaterCloud.Service.Infrastructure;

namespace WaterCloud.Web.Areas.EmployeePerformance.Controllers
{
    [Area("EmployeePerformance")]
    public class PerformanceDetailsController : ControllerBase
    {
        private readonly IPDMonthlyPerformanceComparisonService _MPCservice;
        private readonly IPDMonthlyPerformanceService _MPservice;
        private readonly IDbContext _context;

        public PerformanceDetailsController(IDbContext context)
        {
            string dbType = GlobalContext.SystemConfig.DBProvider;
            _context = context;
            switch (dbType)
            {
                case Define.DBTYPE_SQLSERVER:
                    _MPCservice = new PDMonthlyPerformanceComparisonService(context);
                    _MPservice=new PDMonthlyPerformanceService(context);
                    break;
                case Define.DBTYPE_MYSQL:
                    _MPCservice = new PDMonthlyPerformanceComparisonService(context);
                    _MPservice = new PDMonthlyPerformanceService(context);
                    break;
            }
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetPDMonthlyPerformanceComparison(string keyValue,string keyVue)
        {
            var data = await _MPCservice.GetTableFieldList(keyValue, keyVue);
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetPDMonthlyPerformance(string keyValue)
        {
            var data = await _MPservice.GetTableFieldList(keyValue);
            return Content(data.ToJson());
        }
    }
}
