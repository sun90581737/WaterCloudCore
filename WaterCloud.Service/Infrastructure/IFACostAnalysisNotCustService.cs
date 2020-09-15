using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.CostAnalysis;

namespace WaterCloud.Service.Infrastructure
{
    public interface IFACostAnalysisNotCustService
    {
        Task<List<FACostAnalysisNotCustEntity>> GetTableFieldList(string GetTime);
    }
}
