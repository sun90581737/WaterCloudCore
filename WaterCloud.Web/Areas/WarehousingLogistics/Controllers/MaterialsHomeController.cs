using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using WaterCloud.Code;
using WaterCloud.Service.WarehousingLogistics;

namespace WaterCloud.Web.Areas.WarehousingLogistics.Controllers
{
    [Area("WarehousingLogistics")]
    public class MaterialsHomeController : ControllerBase
    {
        public MHInventoryProfileService _ipService { get; set; }
        public MHWorkpieceListService _wlService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataMHInventoryProfile()
        {
            var data = await _ipService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "MoldNumber desc";
            var data = await _wlService.GetList(pagination);
            return Success(pagination.records, data);
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJsonOne(Pagination pagination)
        {
            pagination.order = "desc";
            pagination.sort = "MoldNumber desc";
            var data = await _wlService.GetListOne(pagination);
            return Success(pagination.records, data);
        }
    }
}
