using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.TeamTask;

namespace WaterCloud.Service.TeamTask
{
    public class TDJiadongRateTrendService : DataFilterService<TDJiadongRateTrendEntity>, IDenpendency
    {
        public TDJiadongRateTrendService(IDbContext context) : base(context)
        {
        }
        public async Task<List<TDJiadongRateTrendEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
