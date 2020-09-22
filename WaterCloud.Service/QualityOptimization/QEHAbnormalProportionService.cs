using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.QualityOptimization;

namespace WaterCloud.Service.QualityOptimization
{
    public class QEHAbnormalProportionService : DataFilterService<QEHAbnormalProportionEntity>, IDenpendency
    {
        public QEHAbnormalProportionService(IDbContext context) : base(context)
        {
        }
        public async Task<List<QEHAbnormalProportionEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
