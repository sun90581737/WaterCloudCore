using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.TeamTask;

namespace WaterCloud.Service.TeamTask
{
    public class TODepartmentJiaDongRateService : DataFilterService<TODepartmentJiaDongRateEntity>, IDenpendency
    {
        public TODepartmentJiaDongRateService(IDbContext context) : base(context)
        {
        }
        public async Task<List<TODepartmentJiaDongRateEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
