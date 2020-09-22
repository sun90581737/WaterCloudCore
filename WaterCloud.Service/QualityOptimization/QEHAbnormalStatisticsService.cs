using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Code;
using WaterCloud.Domain.Entity.QualityOptimization;

namespace WaterCloud.Service.QualityOptimization
{
    public class QEHAbnormalStatisticsService : DataFilterService<QEHAbnormalStatisticsEntity>, IDenpendency
    {
        public QEHAbnormalStatisticsService(IDbContext context) : base(context)
        {
        }
        public async Task<List<QEHAbnormalStatisticsEntity>> GetList(Pagination pagination, string keyvalue)
        {
            ////获取数据权限
            //var list = GetDataPrivilege("u", className.Substring(0, className.Length - 7));

            //list = list.Where(t => t.IsEffective == 1);
            //return GetFieldsFilterData(await repository.OrderList(list, pagination), className.Substring(0, className.Length - 7));

            var list = repository.IQueryable();
            if (!string.IsNullOrEmpty(keyvalue))
            {
                DateTime startTime = keyvalue.Substring(0, 10).ToDate();
                DateTime endTime = keyvalue.Remove(0, 13).ToDate();

                list = list.Where(t => t.AcctDate >= startTime && t.AcctDate <= endTime);
            }
            list = list.Where(t => t.IsEffective == 1);
            return await repository.OrderList(list, pagination);
        }
    }
}
