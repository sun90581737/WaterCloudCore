using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.TeamTask;

namespace WaterCloud.Service.TeamTask
{
    public class TDJiadongRateService : DataFilterService<TDJiadongRateEntity>, IDenpendency
    {
        public TDJiadongRateService(IDbContext context) : base(context)
        {
        }
        public async Task<List<TDJiadongRateEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
