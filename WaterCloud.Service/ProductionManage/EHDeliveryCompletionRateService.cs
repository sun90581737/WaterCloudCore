using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.ProductionManage;

namespace WaterCloud.Service.ProductionManage
{
    public class EHDeliveryCompletionRateService : DataFilterService<EHDeliveryCompletionRateEntity>, IDenpendency
    {
        public EHDeliveryCompletionRateService(IDbContext context) : base(context)
        {
        }
        public async Task<List<EHDeliveryCompletionRateEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
