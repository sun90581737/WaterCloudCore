using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.EmployeePerformance;

namespace WaterCloud.Service.EmployeePerformance
{
    public class TLHAttendanceRateService : DataFilterService<TLHAttendanceRateEntity>, IDenpendency
    {
        public TLHAttendanceRateService(IDbContext context) : base(context)
        {
        }
        public async Task<List<TLHAttendanceRateEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
