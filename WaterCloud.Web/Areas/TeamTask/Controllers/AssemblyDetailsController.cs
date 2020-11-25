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
    public class AssemblyDetailsController : ControllerBase
    {
        public ADAbnormalProportionService _apService { get; set; }
        public ADOutsourcingPartsListService _oplService { get; set; }
        public ADBillOfMaterialsService _bomService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJsonOne(Pagination pagination, string keyvalue)
        {
            pagination.order = "desc";
            pagination.sort = "WorkingProcedure desc";
            var data = await _apService.GetList(pagination, keyvalue);
            return Success(pagination.records, data);
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJsonTwo(Pagination pagination, string keyvalue)
        {
            pagination.order = "desc";
            pagination.sort = "MoldNo desc";
            var data = await _oplService.GetList(pagination, keyvalue);
            return Success(pagination.records, data);
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJsonWL(Pagination pagination, string keyvalue)
        {
            pagination.order = "desc";
            pagination.sort = "MoldNo desc";
            var data = await _bomService.GetListWL(pagination, keyvalue);
            return Success(pagination.records, data);
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJsonZZ(Pagination pagination, string keyvalue)
        {
            pagination.order = "desc";
            pagination.sort = "MoldNo desc";
            var data = await _bomService.GetListZZ(pagination, keyvalue);
            return Success(pagination.records, data);
        }
    }
}
