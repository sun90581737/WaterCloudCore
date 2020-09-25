using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.EmployeePerformance;

namespace WaterCloud.Service.EmployeePerformance
{
    public class EHMonthlyPerformanceService : DataFilterService<EHMonthlyPerformanceEntity>, IDenpendency
    {
        public EHMonthlyPerformanceService(IDbContext context) : base(context)
        {
        }
        public async Task<List<EHMonthlyPerformanceEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
