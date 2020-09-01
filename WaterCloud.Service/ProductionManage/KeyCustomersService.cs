using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.ProductionManage;

namespace WaterCloud.Service.ProductionManage
{
    public class KeyCustomersService : DataFilterService<KeyCustomersEntity>, IDenpendency
    {
        public KeyCustomersService(IDbContext context) : base(context)
        {
        }
        public async Task<List<KeyCustomersEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
