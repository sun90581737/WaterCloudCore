using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.OperationMonitoring;

namespace WaterCloud.Service.OperationMonitoring
{
    public class PMHomeJiadongRateService : DataFilterService<PMHomeJiadongRateEntity>, IDenpendency
    {
        public PMHomeJiadongRateService(IDbContext context) : base(context)
        {
        }
        public async Task<List<PMHomeJiadongRateEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
