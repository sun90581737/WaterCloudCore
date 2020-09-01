using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.ProductionManage;

namespace WaterCloud.Service.ProductionManage
{
    public class DepartmentQualifiedRateService : DataFilterService<DepartmentQualifiedRateEntity>, IDenpendency
    {
        public DepartmentQualifiedRateService(IDbContext context) : base(context)
        {
        }
        public async Task<List<DepartmentQualifiedRateEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
