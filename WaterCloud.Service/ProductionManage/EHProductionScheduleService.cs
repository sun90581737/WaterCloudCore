using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.ProductionManage;

namespace WaterCloud.Service.ProductionManage
{
    public class EHProductionScheduleService : DataFilterService<EHProductionScheduleEntity>, IDenpendency
    {
        public EHProductionScheduleService(IDbContext context) : base(context)
        {
        }
        public async Task<List<EHProductionScheduleEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
