using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.TeamTask;

namespace WaterCloud.Service.TeamTask
{
    public class TDDepartmentQualifiedRateService : DataFilterService<TDDepartmentQualifiedRateEntity>, IDenpendency
    {
        public TDDepartmentQualifiedRateService(IDbContext context) : base(context)
        {
        }
        public async Task<List<TDDepartmentQualifiedRateEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
