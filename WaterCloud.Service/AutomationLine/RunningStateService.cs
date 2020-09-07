using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.AutomationLine;

namespace WaterCloud.Service.AutomationLine
{
    public class RunningStateService : DataFilterService<RunningStateEntity>, IDenpendency
    {
        public RunningStateService(IDbContext context) : base(context)
        {
        }
        public async Task<List<RunningStateEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
