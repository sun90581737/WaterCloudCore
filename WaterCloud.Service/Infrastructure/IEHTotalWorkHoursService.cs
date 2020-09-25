using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.EmployeePerformance;

namespace WaterCloud.Service.Infrastructure
{
    public interface IEHTotalWorkHoursService
    {
        Task<List<EHTotalWorkHoursEntity>> GetTableFieldList(string GetTime);
    }
}
