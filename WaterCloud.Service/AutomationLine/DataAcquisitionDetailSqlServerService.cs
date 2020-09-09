using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.DataBase;
using WaterCloud.Domain.Entity.AutomationLine;
using WaterCloud.Service.Infrastructure;

namespace WaterCloud.Service.AutomationLine
{
    public class DataAcquisitionDetailSqlServerService : RepositoryBase, IDataAcquisitionDetailService
    {
        public DataAcquisitionDetailSqlServerService(IDbContext context) : base(context)
        {

        }
        public async Task<List<DataAcquisitionDetailEntity>> GetTableFieldList(string ConfTime)
        {
            var Time = 0;
            if (string.IsNullOrEmpty(ConfTime))
            {
                Time = 0;
            }
            else
            {
                Time = Convert.ToInt32(ConfTime);
            }
            var GetDateTime = DateTime.Now.AddMinutes(-1);
            StringBuilder strSql = new StringBuilder();
            strSql.Append(@"SELECT * FROM	Sys_DataAcquisitionDetail WHERE RunTime IN(
            SELECT MIN(RunTime) FROM	Sys_DataAcquisitionDetail 
            where IsEffective=1 AND RunTime between @starttime and @endtime 
            GROUP BY  DeviceName)");
            var parameter = new List<DbParam>();
            parameter.Add(new DbParam("@starttime", GetDateTime.ToString()));
            parameter.Add(new DbParam("@endtime", GetDateTime.AddSeconds(Time).ToString()));
            var list = await FindList<DataAcquisitionDetailEntity>(strSql.ToString(), parameter.ToArray());
            return list;
        }
    }
}
