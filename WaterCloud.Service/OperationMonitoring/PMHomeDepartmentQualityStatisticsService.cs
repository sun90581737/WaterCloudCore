using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.OperationMonitoring;

namespace WaterCloud.Service.OperationMonitoring
{
    public class PMHomeDepartmentQualityStatisticsService : DataFilterService<PMHomeDepartmentQualityStatisticsEntity>, IDenpendency
    {
        public PMHomeDepartmentQualityStatisticsService(IDbContext context) : base(context)
        {
        }
        public async Task<List<PMHomeDepartmentQualityStatisticsEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
