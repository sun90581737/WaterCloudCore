using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.ProductionManage;

namespace WaterCloud.Service.ProductionManage
{
    public class BOCapacityLoadService : DataFilterService<BOCapacityLoadEntity>, IDenpendency
    {
        public BOCapacityLoadService(IDbContext context) : base(context)
        {
        }
        public async Task<List<BOCapacityLoadEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
