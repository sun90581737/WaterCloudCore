using Chloe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.ProductionManage;

namespace WaterCloud.Service.ProductionManage
{
    public class EHNumberMoldsDeliveredService : DataFilterService<EHNumberMoldsDeliveredEntity>, IDenpendency
    {
        public EHNumberMoldsDeliveredService(IDbContext context) : base(context)
        {
        }

        public async Task<List<EHNumberMoldsDeliveredEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
