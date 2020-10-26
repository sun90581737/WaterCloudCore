using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.OperationMonitoring;

namespace WaterCloud.Service.OperationMonitoring
{
    public class CustomerDetailsRateService : DataFilterService<CustomerDetailsRateEntity>, IDenpendency
    {
        public CustomerDetailsRateService(IDbContext context) : base(context)
        {
        }
        public async Task<List<CustomerDetailsRateEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
