using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.EmployeePerformance;

namespace WaterCloud.Service.Infrastructure
{
    public interface IPDMonthlyPerformanceComparisonService
    {
        Task<List<PDMonthlyPerformanceComparisonEntity>> GetTableFieldList(string GetTime, string GetType);
    }
}
