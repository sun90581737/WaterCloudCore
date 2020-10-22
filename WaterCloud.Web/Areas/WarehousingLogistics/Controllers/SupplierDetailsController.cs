using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chloe;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using WaterCloud.Code;
using WaterCloud.Service.Infrastructure;
using WaterCloud.Service.WarehousingLogistics;

namespace WaterCloud.Web.Areas.WarehousingLogistics.Controllers
{
    [Area("WarehousingLogistics")]
    public class SupplierDetailsController : ControllerBase
    {
        private readonly ISDDeliveryPassRateService _DPRservice;
        private readonly IDbContext _context;

        public SupplierDetailsController(IDbContext context)
        {
            string dbType = GlobalContext.SystemConfig.DBProvider;
            _context = context;
            switch (dbType)
            {
                case Define.DBTYPE_SQLSERVER:
                    _DPRservice = new SDDeliveryPassRateService(context);
                    break;
                case Define.DBTYPE_MYSQL:
                    _DPRservice = new SDDeliveryPassRateService(context);
                    break;
            }
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataSDDeliveryPassRate(string keyValue)
        {
            var data = await _DPRservice.GetTableFieldList(keyValue);
            return Content(data.ToJson());
        }
    }
}
