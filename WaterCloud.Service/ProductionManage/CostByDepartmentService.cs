using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.ProductionManage;

namespace WaterCloud.Service.ProductionManage
{
    public class CostByDepartmentService : DataFilterService<CostByDepartmentEntity>, IDenpendency
    {
        public CostByDepartmentService(IDbContext context) : base(context)
        {
        }
        public async Task<List<CostByDepartmentEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
