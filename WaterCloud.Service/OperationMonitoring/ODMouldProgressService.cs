using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.OperationMonitoring;

namespace WaterCloud.Service.OperationMonitoring
{
    public class ODMouldProgressService : DataFilterService<ODMouldProgressEntity>, IDenpendency
    {
        public ODMouldProgressService(IDbContext context) : base(context)
        {
        }
        public async Task<List<ODMouldProgressEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
