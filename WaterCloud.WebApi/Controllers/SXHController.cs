using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
                LogHelper.Write(ex.Message);
                return result;
            }
            return result;
        }

        [HttpPost]
        public async Task<DataAcquisitionResult> TestOne([FromForm] TaskListAPIParameterB param)
        {
            DataAcquisitionResult result = new DataAcquisitionResult();
            result.code = "1000";
            result.msg = "success";
            if (!VerifyMiddleSign(param.operator_name, param.operator_time, param.sign))
            {
                // LogHelper.Info(string.Format("operator_name{0},operation_time{1},sign{2}", param.operator_name, param.operator_time, param.sign));
                result.msg = "签名错误";
                result.code = "1040";
                LogHelper.Write(result.msg);
                return result;
            }
            List<TaskListBDTO> dto = new List<TaskListBDTO>();
            try
            {
                dto = Deserialize<List<TaskListBDTO>>(param.strdata);
                foreach (var item in dto)
                {
                    
                }
            }
            catch (Exception ex)
            {
                result.msg = ex.Message;
                result.code = "1060";
                LogHelper.Write(result.msg);
                return result;
            }
            return result;
        }



        public static bool VerifyMiddleSign(string customerId, string timeStamp, string dataSign)
        {
            //Logger.Info("B2C.TMSService.WebApiBaseService.VerifyMiddleSign  " + string.Format("CustomerId{0} timeStamp {1} dataSign{2}", customerId, timeStamp, dataSign));

            try
            {
                bool rtn = false;

                var mySign = GenSign(customerId.ToString(), timeStamp);
                //TODO 如果timestamp差异超过5分钟验证失败
                var serverTimeStamp = GenerateTimeStamp(DateTime.Now);
                long lServer, lClient;
                if (!long.TryParse(timeStamp, out lClient))
                {
                   // LogHelper.Error(string.Format("时间戳格式错误{0}", timeStamp));
                    return false;
                }
                if (!long.TryParse(serverTimeStamp, out lServer))
                {
                    //LogHelper.Error(string.Format("时间戳格式错误{0}", serverTimeStamp));
                    return false;
                }
                if (Math.Abs(lServer - lClient) > 300)
                {
                    //LogHelper.Error(string.Format("客户端与服务器的时间戳相差超过5分钟{0} {1}", timeStamp, serverTimeStamp));
                    return false;
                }

                rtn = string.Compare(mySign, dataSign, true) == 0;
                return rtn;
            }
            catch (Exception ex)
            {
                //LogHelper.Info(ex.Message);
                return false;
            }
        }
        public static string GenSign(string operatorName, string timeStamp)
        {
            string signStr = string.Format("{0}{1}", operatorName, timeStamp);
            return DESEncrypt.Encrypt(signStr);
        }
        public static string GenerateTimeStamp(DateTime dt)
        {
            // Default implementation of UNIX time of the current UTC time  
            TimeSpan ts = dt.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return Convert.ToInt64(ts.TotalSeconds).ToString();
        }
        public static T Deserialize<T>(string jsonValue)
        {
            return JsonConvert.DeserializeObject<T>(jsonValue);
        }
    }
    #region
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
    public class TaskListAPIParameterB
    {
        [DataMember]
        public string operator_name { get; set; }
        [DataMember]
        public string operator_time { get; set; }
        [DataMember]
        public string ip { get; set; }
        [DataMember]
        public string sign { get; set; }
        [DataMember]
        public string strdata { get; set; }

        [DataMember]
        public List<TaskListBDTO> data { get; set; }
    }
    public class TaskListBDTO
    {
        [DataMember]
        public int processid { get; set; }
    }
    public class DataAcquisitionResult
    {
        [DataMember]
        public string code { get; set; }
        [DataMember]
        public string msg { get; set; }
    }
    #endregion
    
}
