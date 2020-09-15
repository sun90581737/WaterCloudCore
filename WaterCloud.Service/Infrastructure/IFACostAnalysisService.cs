using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.CostAnalysis;

namespace WaterCloud.Service.Infrastructure
{
    public interface IFACostAnalysisService
    {
        Task<List<FACostAnalysisEntity>> GetTableFieldList(string GetTime);
    }
}
