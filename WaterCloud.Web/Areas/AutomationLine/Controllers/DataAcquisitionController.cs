using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chloe;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using WaterCloud.Code;
using WaterCloud.Service.AutomationLine;
using WaterCloud.Service.Infrastructure;

namespace WaterCloud.Web.Areas.AutomationLine.Controllers
{
    [Area("AutomationLine")]
    public class DataAcquisitionController : ControllerBase
    {
        private readonly IDataAcquisitionDetailService _service;
        private readonly IDbContext _context;
        public DataAcquisitionService _daService { get; set; }

        public DataAcquisitionController(IDbContext context)
        {
            string dbType = GlobalContext.SystemConfig.DBProvider;
            _context = context;
            switch (dbType)
            {
                case Define.DBTYPE_SQLSERVER:
                    _service = new DataAcquisitionDetailSqlServerService(context);
                    break;
                case Define.DBTYPE_MYSQL:
                    _service = new DataAcquisitionDetailMySqlService(context);
                    break;
                //case Define.DBTYPE_ORACLE:
                //    _service = new DatabaseTableOracleService(context);
                //    break;
                default:
                    _service = new DataAcquisitionDetailMySqlService(context);
                    break;
            }
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataAcquisition()
        {
            var data = await _daService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataAcquisitionDetail()
        {
            //自动化线 - 数据采集 - 页面部分数据刷新频率
            //当前时间匹配数据可以浮动5秒内的数据取第一条: 按秒计算
            var ConfTime = "5";
            var data = await _service.GetTableFieldList(ConfTime);
            return Content(data.ToJson());
        }
    }
}
