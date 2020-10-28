using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.OperationMonitoring;

namespace WaterCloud.Service.OperationMonitoring
{
    public class MSDCostRatioService : DataFilterService<MSDCostRatioEntity>, IDenpendency
    {
        public MSDCostRatioService(IDbContext context) : base(context)
        {
        }
        public async Task<List<MSDCostRatioEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
