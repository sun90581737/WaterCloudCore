using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.OperationMonitoring;

namespace WaterCloud.Service.OperationMonitoring
{
    public class PHProgressAnalysisService : DataFilterService<PHProgressAnalysisEntity>, IDenpendency
    {
        public PHProgressAnalysisService(IDbContext context) : base(context)
        {
        }
        public async Task<List<PHProgressAnalysisEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
