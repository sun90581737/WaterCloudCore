using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterCloud.Code;
using WaterCloud.Service.TeamTask;

namespace WaterCloud.Web.Areas.TeamTask.Controllers
{
    [Area("TeamTask")]
    public class FitterHomeController : ControllerBase
    {
        public FitterHomepageListService _fhlService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination, string keyvalue)
        {
            pagination.order = "desc";
            pagination.sort = "ProductName ASC";
            var data = await _fhlService.GetList(pagination, keyvalue);
            return Success(pagination.records, data);
        }
    }
}
