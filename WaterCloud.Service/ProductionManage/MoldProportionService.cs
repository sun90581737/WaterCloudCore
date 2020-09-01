using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.ProductionManage;

namespace WaterCloud.Service.ProductionManage
{
    public class MoldProportionService : DataFilterService<MoldProportionEntity>, IDenpendency
    {
        public MoldProportionService(IDbContext context) : base(context)
        {
        }
        public async Task<List<MoldProportionEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
