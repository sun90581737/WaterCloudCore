using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.DataBase;
using WaterCloud.Domain.Entity.WarehousingLogistics;
using WaterCloud.Service.Infrastructure;

namespace WaterCloud.Service.WarehousingLogistics
{
    public class SDDeliveryPassRateService : RepositoryBase, ISDDeliveryPassRateService
    {
        public SDDeliveryPassRateService(IDbContext context) : base(context)
        {
        }
        public async Task<List<SDDeliveryPassRateEntity>> GetTableFieldList(string GetTime)
        {
            StringBuilder strSql = new StringBuilder();
            var parameter = new List<DbParam>();
            if (string.IsNullOrEmpty(GetTime))
            {
                strSql.Append(@"SELECT DeviceType, DeviceName, SUM(Number)Number FROM	Sys_SDDeliveryPassRate WHERE IsEffective=1  GROUP BY DeviceType, DeviceName,id ORDER BY id ASC");
                parameter.Add(new DbParam("", ""));
            }
            else
            {
                var starttime = GetTime.Substring(0, 10);
                var endtime = GetTime.Remove(0, 13);

                strSql.Append(@"SELECT DeviceType, DeviceName, SUM(Number)Number FROM	Sys_SDDeliveryPassRate
                WHERE IsEffective=1 AND AcctDate between @starttime AND @endtime  GROUP BY DeviceType, DeviceName,id ORDER BY id ASC");

                parameter.Add(new DbParam("@starttime", starttime.ToString()));
                parameter.Add(new DbParam("@endtime", endtime.ToString()));

            }
            var list = await FindList<SDDeliveryPassRateEntity>(strSql.ToString(), parameter.ToArray());
            return list;
        }
    }
}
