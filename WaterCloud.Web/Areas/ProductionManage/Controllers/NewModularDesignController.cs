using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterCloud.Code;
using WaterCloud.Service.ProductionManage;

namespace WaterCloud.Web.Areas.ProductionManage.Controllers
{
    [Area("ProductionManage")]
    public class NewModularDesignController : ControllerBase
    {
        public MQDesignChangeDetailsService _dcdDervice { get; set; }
        public MQVersionListService _vlService { get; set; }
        public MQProcessingCostService _pcService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination, string keyvalue)
        {
            pagination.order = "desc";
            pagination.sort = "MoldNo desc";
            var data = await _dcdDervice.GetList(pagination, keyvalue);
            return Success(pagination.records, data);
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJsonTwo(Pagination pagination, string keyvalue)
        {
            pagination.order = "desc";
            pagination.sort = "MoldNo desc";
            var data = await _vlService.GetList(pagination, keyvalue);
            return Success(pagination.records, data);
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJsonThree(Pagination pagination, string keyvalue)
        {
            pagination.order = "desc";
            pagination.sort = "WorkingGroup desc";
            var data = await _pcService.GetList(pagination, keyvalue);
            return Success(pagination.records, data);
        }
    }
}
