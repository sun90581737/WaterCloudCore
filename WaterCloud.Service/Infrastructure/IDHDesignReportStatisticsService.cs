using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.MouldDesign;

namespace WaterCloud.Service.Infrastructure
{
    public interface IDHDesignReportStatisticsService
    {
        Task<List<DHDesignReportStatisticsEntity>> GetTableFieldList(string GetTime);
    }
}
