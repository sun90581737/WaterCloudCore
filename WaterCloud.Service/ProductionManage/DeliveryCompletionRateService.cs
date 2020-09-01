using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.ProductionManage;

namespace WaterCloud.Service.ProductionManage
{
    public class DeliveryCompletionRateService : DataFilterService<DeliveryCompletionRateEntity>, IDenpendency
    {
        public DeliveryCompletionRateService(IDbContext context) : base(context)
        {
        }
        public async Task<List<DeliveryCompletionRateEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
