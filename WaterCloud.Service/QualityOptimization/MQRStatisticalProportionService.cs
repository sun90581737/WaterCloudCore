using Chloe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.QualityOptimization;

namespace WaterCloud.Service.QualityOptimization
{
    public class MQRStatisticalProportionService : DataFilterService<MQRStatisticalProportionEntity>, IDenpendency
    {
        public MQRStatisticalProportionService(IDbContext context) : base(context)
        {
        }
        public async Task<List<MQRStatisticalProportionEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
