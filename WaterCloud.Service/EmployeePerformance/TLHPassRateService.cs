using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.EmployeePerformance;

namespace WaterCloud.Service.EmployeePerformance
{
    public class TLHPassRateService : DataFilterService<TLHPassRateEntity>, IDenpendency
    {
        public TLHPassRateService(IDbContext context) : base(context)
        {
        }
        public async Task<List<TLHPassRateEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
