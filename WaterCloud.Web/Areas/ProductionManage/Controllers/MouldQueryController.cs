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
    public class MouldQueryController : ControllerBase
    {
        public MQMouldListService _mlService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetMQMouldList(Pagination pagination, string keyvalue, string keyword = "")
        {
            pagination.order = "desc";
            pagination.sort = "MoldNo desc";
            var data = await _mlService.GetList(pagination, keyvalue, keyword);
            return Success(pagination.records, data);
        }
    }
}
