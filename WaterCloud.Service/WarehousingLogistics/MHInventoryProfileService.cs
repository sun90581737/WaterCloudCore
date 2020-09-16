using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.WarehousingLogistics;

namespace WaterCloud.Service.WarehousingLogistics
{
    public class MHInventoryProfileService : DataFilterService<MHInventoryProfileEntity>, IDenpendency
    {
        public MHInventoryProfileService(IDbContext context) : base(context)
        {
        }
        public async Task<List<MHInventoryProfileEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
