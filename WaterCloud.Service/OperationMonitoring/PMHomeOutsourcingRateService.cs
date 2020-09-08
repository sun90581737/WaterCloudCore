using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.OperationMonitoring;

namespace WaterCloud.Service.OperationMonitoring
{
    public class PMHomeOutsourcingRateService : DataFilterService<PMHomeOutsourcingRateEntity>, IDenpendency
    {
        public PMHomeOutsourcingRateService(IDbContext context) : base(context)
        {
        }
        public async Task<List<PMHomeOutsourcingRateEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
