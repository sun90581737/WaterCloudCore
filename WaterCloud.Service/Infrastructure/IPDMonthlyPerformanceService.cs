using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.EmployeePerformance;

namespace WaterCloud.Service.Infrastructure
{
    public interface IPDMonthlyPerformanceService
    {
        Task<List<PDMonthlyPerformanceEntity>> GetTableFieldList(string GetTime);
    }
}
