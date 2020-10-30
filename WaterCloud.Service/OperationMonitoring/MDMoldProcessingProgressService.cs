using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.OperationMonitoring;

namespace WaterCloud.Service.OperationMonitoring
{
    public class MDMoldProcessingProgressService : DataFilterService<MDMoldProcessingProgressEntity>, IDenpendency
    {
        public MDMoldProcessingProgressService(IDbContext context) : base(context)
        {
        }
        public async Task<List<MDMoldProcessingProgressEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
