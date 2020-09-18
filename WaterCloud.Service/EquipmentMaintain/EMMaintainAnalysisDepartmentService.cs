using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Code;
using WaterCloud.DataBase;
using WaterCloud.Domain.Entity.EquipmentMaintain;
using WaterCloud.Service.Infrastructure;

namespace WaterCloud.Service.EquipmentMaintain
{
    public class EMMaintainAnalysisDepartmentService : RepositoryBase, IEMMaintainAnalysisDepartmentService
    {
        public EMMaintainAnalysisDepartmentService(IDbContext context) : base(context)
        {
        }
        public async Task<List<EMMaintainAnalysisDepartmentEntity>> GetTableFieldList(int GetTime)
        {
            StringBuilder strSql = new StringBuilder();
            var parameter = new List<DbParam>();

            DateTime startTime = DateTime.Now.ToString("yyyy-MM-dd").ToDate();
            DateTime endTime = DateTime.Now.ToString("yyyy-MM-dd").ToDate();
            switch (GetTime)
            {
                //1月  2季（3个月） 3半年  4年
                case 1:
                    startTime = startTime.AddMonths(-1);
                    break;
                case 2:
                    startTime = startTime.AddMonths(-3);
                    break;
                case 3:
                    startTime = startTime.AddMonths(-6);
                    break;
                case 4:
                    startTime = startTime.AddYears(-1);
                    break;
                default:
                    break;
            }
            strSql.Append(@"SELECT DeviceType,DeviceName,SUM(Number)Number  FROM	Sys_EMMaintainAnalysisDepartment  
                WHERE IsEffective=1 AND AcctDate BETWEEN @starttime AND @endtime GROUP BY DeviceType,DeviceName");

            parameter.Add(new DbParam("@starttime", startTime.ToString()));
            parameter.Add(new DbParam("@endtime", endTime.ToString()));

            var list = await FindList<EMMaintainAnalysisDepartmentEntity>(strSql.ToString(), parameter.ToArray());
            return list;
        }
    }
}
