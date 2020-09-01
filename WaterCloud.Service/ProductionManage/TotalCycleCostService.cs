using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.ProductionManage;

namespace WaterCloud.Service.ProductionManage
{
    public class TotalCycleCostService : DataFilterService<TotalCycleCostEntity>, IDenpendency
    {
        public TotalCycleCostService(IDbContext context) : base(context)
        {
        }
        public async Task<List<TotalCycleCostEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
