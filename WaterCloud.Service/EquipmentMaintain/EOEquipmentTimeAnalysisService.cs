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
    public class EOEquipmentTimeAnalysisService : RepositoryBase, IEOEquipmentTimeAnalysisService
    {
        public EOEquipmentTimeAnalysisService(IDbContext context) : base(context)
        {
        }
        public async Task<List<EOEquipmentTimeAnalysisEntity>> GetTableFieldList(string GetTime)
        {
            StringBuilder strSql = new StringBuilder();
            var parameter = new List<DbParam>();
            if (string.IsNullOrEmpty(GetTime))
            {
                strSql.Append(@"SELECT DeviceType, DeviceName, SUM(Number)Number FROM	Sys_EOEquipmentTimeAnalysis WHERE IsEffective=1  GROUP BY DeviceType, DeviceName ORDER BY DeviceType ASC");
                parameter.Add(new DbParam("", ""));
            }
            else
            {
                var starttime = GetTime.Substring(0, 10);
                var endtime = GetTime.Remove(0, 13);

                strSql.Append(@"SELECT DeviceType, DeviceName, SUM(Number)Number FROM	Sys_EOEquipmentTimeAnalysis
                WHERE IsEffective=1 AND AcctDate between @starttime AND @endtime  GROUP BY DeviceType, DeviceName ORDER BY DeviceType ASC");

                parameter.Add(new DbParam("@starttime", starttime.ToString()));
                parameter.Add(new DbParam("@endtime", endtime.ToString()));

            }
            var list = await FindList<EOEquipmentTimeAnalysisEntity>(strSql.ToString(), parameter.ToArray());
            return list;
        }
    }
}
