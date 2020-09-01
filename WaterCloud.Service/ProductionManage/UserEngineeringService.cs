using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.ProductionManage;

namespace WaterCloud.Service.ProductionManage
{
    public class UserEngineeringService : DataFilterService<UserEngineeringEntity>, IDenpendency
    {
        public UserEngineeringService(IDbContext context) : base(context)
        {
        }
        public async Task<List<UserEngineeringEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
