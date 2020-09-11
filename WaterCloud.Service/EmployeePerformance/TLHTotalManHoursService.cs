using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.EmployeePerformance;

namespace WaterCloud.Service.EmployeePerformance
{
    public class TLHTotalManHoursService : DataFilterService<TLHTotalManHoursEntity>, IDenpendency
    {
        public TLHTotalManHoursService(IDbContext context) : base(context)
        {
        }
        public async Task<List<TLHTotalManHoursEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
