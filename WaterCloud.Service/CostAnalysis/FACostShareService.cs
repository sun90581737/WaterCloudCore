using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.CostAnalysis;

namespace WaterCloud.Service.CostAnalysis
{
    public class FACostShareService : DataFilterService<FACostShareEntity>, IDenpendency
    {
        public FACostShareService(IDbContext context) : base(context)
        {
        }
        public async Task<List<FACostShareEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
