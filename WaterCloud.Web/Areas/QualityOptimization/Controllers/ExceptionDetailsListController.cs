using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WaterCloud.Code;
using WaterCloud.Service.QualityOptimization;

namespace WaterCloud.Web.Areas.QualityOptimization.Controllers
{
    [Area("QualityOptimization")]
    public class ExceptionDetailsListController : ControllerBase
    {
        public QOExceptionDetailsListService _edlService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "ExceptionNumber desc";
            var data = await _edlService.GetList(pagination);
            return Success(pagination.records, data);
        }
    }
}
