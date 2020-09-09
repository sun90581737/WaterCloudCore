using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.OperationMonitoring;

namespace WaterCloud.Service.OperationMonitoring
{
    public class PMHomeMoldProgressService : DataFilterService<PMHomeMoldProgressEntity>, IDenpendency
    {
        public PMHomeMoldProgressService(IDbContext context) : base(context)
        {
        }
        public async Task<List<PMHomeMoldProgressEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
