using Chloe;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterCloud.Code;
using WaterCloud.Service.Infrastructure;
using WaterCloud.Service.OperationMonitoring;

namespace WaterCloud.Web.Areas.OperationMonitoring.Controllers
{
    [Area("OperationMonitoring")]
    public class VersionDetailsController : ControllerBase
    {
        public VDQualifizierteVerarbeitungsrateService _qvService { get; set; }
        public VDKostenDerVerarbeitungService _kdvService { get; set; }

        private readonly IVDWorkpieceTypeProportionService _WTPservice;
        private readonly IDbContext _context;
        public VersionDetailsController(IDbContext context)
        {
            string dbType = GlobalContext.SystemConfig.DBProvider;
            _context = context;
            switch (dbType)
            {
                case Define.DBTYPE_SQLSERVER:
                    _WTPservice = new VDWorkpieceTypeProportionService(context);
                    break;
                case Define.DBTYPE_MYSQL:
                    _WTPservice = new VDWorkpieceTypeProportionService(context);
                    break;
            }
        }
        public VDWorkpieceScheduleListService _wslService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetVDQualifizierteOne()
        {
            var data = await _qvService.GetList();
            data = data.Where(p => p.IsEffective == 1 && p.Type == "HGL").ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetVDQualifizierteTwo()
        {
            var data = await _qvService.GetList();
            data = data.Where(p => p.IsEffective == 1 && p.Type == "JD").ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "ModuleNumber desc";
            var data = await _kdvService.GetList(pagination);
            return Success(pagination.records, data);
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetVDWorkpieceTypeProportion(string keyValue)
        {
            var data = await _WTPservice.GetTableFieldList(keyValue);
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJsonOne(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "MoldNo desc";
            var data = await _wslService.GetList(pagination);
            return Success(pagination.records, data);
        }
    }
}
