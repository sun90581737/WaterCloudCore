using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WaterCloud.Code;

namespace WaterCloud.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]

    public class SXHController : ControllerBase
    {
        [HttpPost]
        public TaskListResult TestLink([FromForm] TaskListTest param)
        {
            TaskListResult result = new TaskListResult();
            result.val = "success";
            if (param == null)
            {
                result.val = "不存在";
                return result;
            }
            try
            {
                result.val = param.val;
            }
            catch (Exception ex)
            {
                result.val = ex.Message;
                return result;
            }
            return result;
        }

        [HttpPost]
        public TaskListResult TestOne([FromForm] TaskListTest param)
        {
            TaskListResult result = new TaskListResult();
            result.val = "success";
            if (param == null)
            {
                result.val = "不存在";
                return result;
            }
            try
            {
                result.val = param.val;
            }
            catch (Exception ex)
            {
                result.val = ex.Message;
                return result;
            }
            return result;
        }
    }

    public class TaskListResult
    {
        [DataMember]
        public string val { get; set; }
    }
    [DataContract]
    public class TaskListTest
    {
        [DataMember]
        public string type { get; set; }
        [DataMember]
        public string val { get; set; }

        [DataMember]
        public TaskListResult data { get; set; }
    }
}
