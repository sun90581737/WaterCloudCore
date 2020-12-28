using Chloe;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterCloud.Code;
using WaterCloud.Service.EquipmentMaintain;
using WaterCloud.Service.Infrastructure;

namespace WaterCloud.Web.Areas.EquipmentMaintain.Controllers
{
    [Area("EquipmentMaintain")]
    public class EquipmentOverviewController : ControllerBase
    {
        private readonly IEOJiaDongRateContrastService _JDRCservice;
        private readonly IEOEquipmentJiaDongRateService _EJDRservice;
        private readonly IEOEquipmentTimeAnalysisService _ETAsrvice;
        private readonly IDbContext _context;

        public EquipmentOverviewController(IDbContext context)
        {
            string dbType = GlobalContext.SystemConfig.DBProvider;
            _context = context;
            switch (dbType)
            {
                case Define.DBTYPE_SQLSERVER:
                    _JDRCservice = new EOJiaDongRateContrastService(context);
                    _EJDRservice = new EOEquipmentJiaDongRateService(context);
                    _ETAsrvice = new EOEquipmentTimeAnalysisService(context);
                    break;
                case Define.DBTYPE_MYSQL:
                    _JDRCservice = new EOJiaDongRateContrastService(context);
                    _EJDRservice = new EOEquipmentJiaDongRateService(context);
                    _ETAsrvice = new EOEquipmentTimeAnalysisService(context);
                    break;
            }
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDistinctType()
        {
            var data = await _JDRCservice.GetDistinctType();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetEOJiaDongRateContrast(string keyValue, string keyVue)
        {
            var data = await _JDRCservice.GetTableFieldList(keyValue, keyVue);
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetEOEquipmentJiaDongRate(string keyValue)
        {
            var data = await _EJDRservice.GetTableFieldList(keyValue);
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetEOEquipmentTimeAnalysis(string keyValue)
        {
            var data = await _ETAsrvice.GetTableFieldList(keyValue);
            return Content(data.ToJson());
        }

    }
}
