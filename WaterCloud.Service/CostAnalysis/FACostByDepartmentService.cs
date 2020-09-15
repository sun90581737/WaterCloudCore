using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.DataBase;
using WaterCloud.Domain.Entity.CostAnalysis;
using WaterCloud.Service.Infrastructure;

namespace WaterCloud.Service.CostAnalysis
{
    public class FACostByDepartmentService : RepositoryBase, IFACostByDepartmentService
    {
        public FACostByDepartmentService(IDbContext context) : base(context)
        {
        }
        public async Task<List<FACostByDepartmentEntity>> GetTableFieldList(string GetTime)
        {
            StringBuilder strSql = new StringBuilder();
            var parameter = new List<DbParam>();
            if (string.IsNullOrEmpty(GetTime))
            {
                strSql.Append(@"SELECT Name,SUM(Cost) Cost FROM	Sys_FACostByDepartment WHERE 1=1 GROUP BY Name ");
                parameter.Add(new DbParam("", ""));
            }
            else
            {
                var starttime = GetTime.Substring(0, 10);
                var endtime = GetTime.Remove(0, 13);

                strSql.Append(@"SELECT Name, SUM(Cost) Cost FROM Sys_FACostByDepartment WHERE AcctDate between @starttime AND @endtime GROUP BY Name");

                parameter.Add(new DbParam("@starttime", starttime.ToString()));
                parameter.Add(new DbParam("@endtime", endtime.ToString()));

            }
            var list = await FindList<FACostByDepartmentEntity>(strSql.ToString(), parameter.ToArray());
            return list;
        }
    }
}
