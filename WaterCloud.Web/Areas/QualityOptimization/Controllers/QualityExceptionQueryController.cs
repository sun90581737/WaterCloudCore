using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WaterCloud.Code;
using WaterCloud.Service.QualityOptimization;

namespace WaterCloud.Web.Areas.QualityOptimization.Controllers
{
    [Area("QualityOptimization")]
    public class QualityExceptionQueryController : ControllerBase
    {
        public QualityExceptionQueryListService _qlService { get; set; }
        public QualityExceptionQueryDetailedListService _qdlService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "Department desc";
            var data = await _qlService.GetList(pagination);
            return Success(pagination.records, data);
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJsonKey(Pagination pagination, string keyvalue)
        {
            pagination.order = "desc";
            pagination.sort = "QualityNo desc";
            var data = await _qdlService.GetListKey(pagination, keyvalue);
            return Success(pagination.records, data);
        }
    }
}
