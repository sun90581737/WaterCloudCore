using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.OperationMonitoring;

namespace WaterCloud.Service.OperationMonitoring
{
    public class PMHomeCapacityLoadService : DataFilterService<PMHomeCapacityLoadEntity>, IDenpendency
    {
        public PMHomeCapacityLoadService(IDbContext context) : base(context)
        {
        }
        public async Task<List<PMHomeCapacityLoadEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
