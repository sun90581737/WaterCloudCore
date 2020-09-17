using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Chloe;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using WaterCloud.Code;
using WaterCloud.Service.EquipmentMaintain;

namespace WaterCloud.Web.Areas.EquipmentMaintain.Controllers
{
    [Area("EquipmentMaintain")]
    public class EquipmentManageController : ControllerBase
    {
        public EMEquipmentStatusService _esService { get; set; }
        public EMEquipmentListService _elService { get; set; }
        public EMMaintainPlanService _mpService { get; set; }
        public EMMaintainHistoryService _mhService { get; set; }

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
    }
}
