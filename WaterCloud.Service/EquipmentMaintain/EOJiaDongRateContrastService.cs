using Chloe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.DataBase;
using WaterCloud.Domain.Entity.EquipmentMaintain;
using WaterCloud.Service.Infrastructure;

namespace WaterCloud.Service.EquipmentMaintain
{
    public class EOJiaDongRateContrastService : RepositoryBase, IEOJiaDongRateContrastService
    {
        public EOJiaDongRateContrastService(IDbContext context) : base(context)
        {
        }
        public async Task<List<EOJiaDongRateContrastEntity>> GetDistinctType()
        {
            StringBuilder strSql = new StringBuilder();
            var parameter = new List<DbParam>();
            strSql.Append(@"SELECT DISTINCT Type FROM	Sys_EOJiaDongRateContrast WHERE IsEffective=1 ORDER BY Type ASC");
            parameter.Add(new DbParam("", ""));
            var list = await FindList<EOJiaDongRateContrastEntity>(strSql.ToString(), parameter.ToArray());
            return list;
        }
        public async Task<List<EOJiaDongRateContrastEntity>> GetTableFieldList(string GetTime, string GetType)
        {
            StringBuilder strSql = new StringBuilder();
            var parameter = new List<DbParam>();
            if (string.IsNullOrEmpty(GetTime) && string.IsNullOrEmpty(GetType))
            {
                strSql.Append(@"SELECT DeviceType, DeviceName, SUM(Number)Number FROM	Sys_EOJiaDongRateContrast WHERE IsEffective=1  GROUP BY DeviceType, DeviceName ORDER BY DeviceType ASC");
                parameter.Add(new DbParam("", ""));
            }
            else if (string.IsNullOrEmpty(GetTime) && !string.IsNullOrEmpty(GetType))
            {
                strSql.Append(@"SELECT DeviceType, DeviceName, SUM(Number)Number,Type FROM	Sys_EOJiaDongRateContrast WHERE IsEffective=1 AND Type=@GetType  GROUP BY DeviceType, DeviceName,Type ORDER BY DeviceType ASC");
                parameter.Add(new DbParam("@GetType", GetType.ToString()));
            }
            else if (!string.IsNullOrEmpty(GetTime) && string.IsNullOrEmpty(GetType))
            {
                var starttime = GetTime.Substring(0, 10);
                var endtime = GetTime.Remove(0, 13);

                strSql.Append(@"SELECT DeviceType, DeviceName, SUM(Number)Number,Type FROM	Sys_EOJiaDongRateContrast WHERE IsEffective=1 AND AcctDate between @starttime AND @endtime  GROUP BY DeviceType, DeviceName,Type ORDER BY DeviceType ASC");

                parameter.Add(new DbParam("@starttime", starttime.ToString()));
                parameter.Add(new DbParam("@endtime", endtime.ToString()));
            }
            else if (!string.IsNullOrEmpty(GetTime) && !string.IsNullOrEmpty(GetType))
            {
                var starttime = GetTime.Substring(0, 10);
                var endtime = GetTime.Remove(0, 13);

                strSql.Append(@"SELECT DeviceType, DeviceName, SUM(Number)Number,Type FROM	Sys_EOJiaDongRateContrast WHERE IsEffective=1 AND Type=@GetType AND AcctDate between @starttime AND @endtime  GROUP BY DeviceType, DeviceName,Type ORDER BY DeviceType ASC");
                parameter.Add(new DbParam("@GetType", GetType.ToString()));
                parameter.Add(new DbParam("@starttime", starttime.ToString()));
                parameter.Add(new DbParam("@endtime", endtime.ToString()));
            }
            var list = await FindList<EOJiaDongRateContrastEntity>(strSql.ToString(), parameter.ToArray());
            return list;
        }
    }
}
