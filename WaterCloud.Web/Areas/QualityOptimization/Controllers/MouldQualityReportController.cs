using Chloe;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterCloud.Code;
using WaterCloud.Service.Infrastructure;
using WaterCloud.Service.QualityOptimization;

namespace WaterCloud.Web.Areas.QualityOptimization.Controllers
{
    [Area("QualityOptimization")]
    public class MouldQualityReportController : ControllerBase
    {
        public MQRStatisticalProportionService _spService { get; set; }
        private readonly IMQRNumberOfAnomaliesService _ROAservice;
        private readonly IDbContext _context;
        public MQRAbnormalCostStatisticsService _acsService { get; set; }


        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetMQRStatisticalProportion(string keyvalue)
        {
            var data = await _spService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            if (!string.IsNullOrEmpty(keyvalue))
            {
                data = data.Where(p => p.Type == keyvalue).ToList();
            }
            return Content(data.ToJson());
        }
        public MouldQualityReportController(IDbContext context)
        {
            string dbType = GlobalContext.SystemConfig.DBProvider;
            _context = context;
            switch (dbType)
            {
                case Define.DBTYPE_SQLSERVER:
                    _ROAservice = new MQRNumberOfAnomaliesService(context);
                    break;
                case Define.DBTYPE_MYSQL:
                    _ROAservice = new MQRNumberOfAnomaliesService(context);
                    break;
            }
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataMQRNumberOfAnomalies(string keyValue)
        {
            var data = await _ROAservice.GetTableFieldList(keyValue);
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "MoldNo desc";
            var data = await _acsService.GetList(pagination);
            return Success(pagination.records, data);
        }

    }
}
