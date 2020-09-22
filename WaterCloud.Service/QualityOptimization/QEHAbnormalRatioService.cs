using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.QualityOptimization;

namespace WaterCloud.Service.QualityOptimization
{
    public class QEHAbnormalRatioService : DataFilterService<QEHAbnormalRatioEntity>, IDenpendency
    {
        public QEHAbnormalRatioService(IDbContext context) : base(context)
        {
        }
        public async Task<List<QEHAbnormalRatioEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
