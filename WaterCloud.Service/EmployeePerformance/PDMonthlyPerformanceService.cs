using Chloe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.DataBase;
using WaterCloud.Domain.Entity.EmployeePerformance;
using WaterCloud.Service.Infrastructure;

namespace WaterCloud.Service.EmployeePerformance
{
    public class PDMonthlyPerformanceService : RepositoryBase, IPDMonthlyPerformanceService
    {
        public PDMonthlyPerformanceService(IDbContext context) : base(context)
        {
        }
        public async Task<List<PDMonthlyPerformanceEntity>> GetTableFieldList(string GetTime)
        {
            StringBuilder strSql = new StringBuilder();
            var parameter = new List<DbParam>();
            if (string.IsNullOrEmpty(GetTime))
            {
                strSql.Append(@"SELECT DeviceType, DeviceName, SUM(Number)Number FROM	Sys_PDMonthlyPerformance WHERE IsEffective=1  GROUP BY DeviceType, DeviceName ORDER BY DeviceType ASC");
                parameter.Add(new DbParam("", ""));
            }
            else
            {
                strSql.Append(@"SELECT DeviceType, DeviceName, SUM(Number)Number FROM	Sys_PDMonthlyPerformance WHERE IsEffective=1 AND AcctDate like @GetTime  GROUP BY DeviceType, DeviceName ORDER BY DeviceType ASC");

                parameter.Add(new DbParam("@GetTime", GetTime.ToString() + "%"));

            }
            var list = await FindList<PDMonthlyPerformanceEntity>(strSql.ToString(), parameter.ToArray());
            return list;
        }
    }
}
