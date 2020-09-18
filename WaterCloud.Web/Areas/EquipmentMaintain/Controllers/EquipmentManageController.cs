using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chloe;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using WaterCloud.Code;
using WaterCloud.Service.EquipmentMaintain;
using WaterCloud.Service.Infrastructure;

namespace WaterCloud.Web.Areas.EquipmentMaintain.Controllers
{
    [Area("EquipmentMaintain")]
    public class EquipmentManageController : ControllerBase
    {
        public EMEquipmentStatusService _esService { get; set; }
        public EMEquipmentListService _elService { get; set; }
        public EMMaintainPlanService _mpService { get; set; }
        public EMMaintainHistoryService _mhService { get; set; }
        public EMMaintainAnalysisService _maService { get; set; }
        public EMMaintainAnalysisReasonService _marService { get; set; }
        public EMMaintainRecordsService _mrService { get; set; }

        private readonly IEMMaintainAnalysisDepartmentService _MADservice;
        private readonly IDbContext _context;

        public EquipmentManageController(IDbContext context)
        {
            string dbType = GlobalContext.SystemConfig.DBProvider;
            _context = context;
            switch (dbType)
            {
                case Define.DBTYPE_SQLSERVER:
                    _MADservice = new EMMaintainAnalysisDepartmentService(context);
                    break;
                case Define.DBTYPE_MYSQL:
                    _MADservice = new EMMaintainAnalysisDepartmentService(context);
                    break;
            }
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataEMEquipmentStatus()
        {
            var data = await _esService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination, string keyword = "")
        {
            pagination.order = "desc";
            pagination.sort = "Number desc";
            var data = await _elService.GetList(pagination, keyword);
            return Success(pagination.records, data);
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataEMMaintainPlan(Pagination pagination, string keyvalue, string keyword = "")
        {
            pagination.order = "desc";
            pagination.sort = "EquipmentNumber desc";
            var data = await _mpService.GetList(pagination, keyvalue, keyword);
            return Success(pagination.records, data);
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataEMMaintainHistory(Pagination pagination, string keyvalue, string keyword = "")
        {
            pagination.order = "desc";
            pagination.sort = "EquipmentNumber desc";
            var data = await _mhService.GetList(pagination, keyvalue, keyword);
            return Success(pagination.records, data);
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataEMMaintainAnalysis()
        {
            var data = await _maService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataEMMaintainAnalysisDepartment(int keyValue)
        {
            var data = await _MADservice.GetTableFieldList(keyValue);
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataEMMaintainAnalysisReason()
        {
            var data = await _marService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJsonOne(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "RepairOrderNo desc";
            var data = await _mrService.GetList(pagination);
            return Success(pagination.records, data);
        }
    }
}
