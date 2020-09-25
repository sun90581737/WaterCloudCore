using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Chloe;
using Microsoft.AspNetCore.Mvc;
using Serenity;
using WaterCloud.Code;
using WaterCloud.Service.EmployeePerformance;
using WaterCloud.Service.Infrastructure;

namespace WaterCloud.Web.Areas.EmployeePerformance.Controllers
{
    [Area("EmployeePerformance")]
    public class EmployeeHomePageController : ControllerBase
    {
        public EHWorkRecordService _wrService { get; set; }
        private readonly IEHTotalWorkHoursService _TWHservice;
        private readonly IDbContext _context;
        public EHPassRateService _prService { get; set; }
        public EHMonthlyPerformanceService _mpService { get; set; }

        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetGridJson(Pagination pagination, string keyvalue)
        {
            pagination.order = "desc";
            pagination.sort = "WorkingProcedure desc";
            var data = await _wrService.GetList(pagination, keyvalue);
            return Success(pagination.records, data);
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetEHWorkRecord(string keyvalue)
        {
            var data = await _wrService.GetList(keyvalue);
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        public EmployeeHomePageController(IDbContext context)
        {
            string dbType = GlobalContext.SystemConfig.DBProvider;
            _context = context;
            switch (dbType)
            {
                case Define.DBTYPE_SQLSERVER:
                    _TWHservice = new EHTotalWorkHoursService(context);
                    break;
                case Define.DBTYPE_MYSQL:
                    _TWHservice = new EHTotalWorkHoursService(context);
                    break;
            }
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataEHTotalWorkHours(string keyValue)
        {
            var data = await _TWHservice.GetTableFieldList(keyValue);
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataEHPassRate(string keyvalue)
        {
            var data = await _prService.GetList(keyvalue);
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public async Task<ActionResult> GetDataEHMonthlyPerformance()
        {
            var data = await _mpService.GetList();
            data = data.Where(p => p.IsEffective == 1).ToList();
            return Content(data.ToJson());
        }

        public async Task<ActionResult> Image(string p)
        {
            //值为空或图片文件不存在
            if (string.IsNullOrEmpty(p) == true || !System.IO.File.Exists(p))
            {
                //默认图片
                // p = @"D:\GF01a.png";
            }
            //get image from database   
            byte[] image = GetBytesFromImage(p);
            return File(image, "image/jpeg");
            //return new FileContentResult(image, "image/jpeg");
        }

        public byte[] GetBytesFromImage(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            int length = (int)fs.Length;
            byte[] image = new byte[length];
            fs.Read(image, 0, length);
            fs.Close();
            return image;

        }
    }
}
