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
    public class PDMonthlyPerformanceComparisonService : RepositoryBase, IPDMonthlyPerformanceComparisonService
    {
        public PDMonthlyPerformanceComparisonService(IDbContext context) : base(context)
        {
        }
        public async Task<List<PDMonthlyPerformanceComparisonEntity>> GetTableFieldList(string GetTime,string GetType)
        {
            StringBuilder strSql = new StringBuilder();
            var parameter = new List<DbParam>();
            if (string.IsNullOrEmpty(GetTime) && string.IsNullOrEmpty(GetType))
            {
                strSql.Append(@"SELECT DeviceType, DeviceName, SUM(Number)Number,Type FROM	Sys_PDMonthlyPerformanceComparison WHERE IsEffective=1  GROUP BY DeviceType, DeviceName,Type ORDER BY DeviceType ASC");
                parameter.Add(new DbParam("",""));
            }
            else if (string.IsNullOrEmpty(GetTime) && !string.IsNullOrEmpty(GetType))
            {
                strSql.Append(@"SELECT DeviceType, DeviceName, SUM(Number)Number,Type FROM	Sys_PDMonthlyPerformanceComparison WHERE IsEffective=1 AND Type=@GetType  GROUP BY DeviceType, DeviceName,Type ORDER BY DeviceType ASC");
                parameter.Add(new DbParam("@GetType", GetType.ToString()));
            }
            else if (!string.IsNullOrEmpty(GetTime) && string.IsNullOrEmpty(GetType))
            {
                strSql.Append(@"SELECT DeviceType, DeviceName, SUM(Number)Number,Type FROM	Sys_PDMonthlyPerformanceComparison WHERE IsEffective=1 AND AcctDate like @GetTime  GROUP BY DeviceType, DeviceName,Type ORDER BY DeviceType ASC");
                parameter.Add(new DbParam("@GetTime", GetTime.ToString() + "%"));
            }
            else 
            {
                strSql.Append(@"SELECT DeviceType, DeviceName, SUM(Number)Number,Type FROM	Sys_PDMonthlyPerformanceComparison WHERE IsEffective=1 AND Type=@GetType AND AcctDate like @GetTime  GROUP BY DeviceType, DeviceName,Type ORDER BY DeviceType ASC");

                parameter.Add(new DbParam("@GetType", GetType.ToString()));
                parameter.Add(new DbParam("@GetTime", GetTime.ToString() + "%"));
            }
            var list = await FindList<PDMonthlyPerformanceComparisonEntity>(strSql.ToString(), parameter.ToArray());
            return list;
        }
    }
}
