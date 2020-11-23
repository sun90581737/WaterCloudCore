using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.TeamTask;

namespace WaterCloud.Service.TeamTask
{
    public class TOTeamLoadRateService : DataFilterService<TOTeamLoadRateEntity>, IDenpendency
    {
        public TOTeamLoadRateService(IDbContext context) : base(context)
        {
        }
        public async Task<List<TOTeamLoadRateEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
