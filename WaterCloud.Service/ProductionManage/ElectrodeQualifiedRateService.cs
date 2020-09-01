using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.ProductionManage;

namespace WaterCloud.Service.ProductionManage
{
    public class ElectrodeQualifiedRateService : DataFilterService<ElectrodeQualifiedRateEntity>, IDenpendency
    {
        public ElectrodeQualifiedRateService(IDbContext context) : base(context)
        {
        }
        public async Task<List<ElectrodeQualifiedRateEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
