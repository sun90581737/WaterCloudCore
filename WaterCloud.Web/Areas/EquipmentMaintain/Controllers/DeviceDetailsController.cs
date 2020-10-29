using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using WaterCloud.Code;
using WaterCloud.Service.EquipmentMaintain;

namespace WaterCloud.Web.Areas.EquipmentMaintain.Controllers
{
    [Area("EquipmentMaintain")]
    public class DeviceDetailsController : ControllerBase
    {
        public DDDeviceInformationService _dlService { get; set; }
        public DDJiaDongRateTrendService _jdrtService { get; set; }
        public DDPassRateTrendService _prtService { get; set; }
        public DDEquipmentPartsListService _eplService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "Number desc";
            var data = await _dlService.GetList(pagination);
            return Success(pagination.records, data);
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDDJiaDongRateTrend()
        {
            var data = await _jdrtService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDDPassRateTrend(string keyvalue)
        {
            var data = await _prtService.GetList(keyvalue);
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJsonOne(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "MoldNo desc";
            var data = await _eplService.GetList(pagination);
            return Success(pagination.records, data);
        }
    }
}
