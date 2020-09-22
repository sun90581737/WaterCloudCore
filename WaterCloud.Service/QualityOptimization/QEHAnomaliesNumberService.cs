using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.QualityOptimization;

namespace WaterCloud.Service.QualityOptimization
{
    public class QEHAnomaliesNumberService : DataFilterService<QEHAnomaliesNumberEntity>, IDenpendency
    {
        public QEHAnomaliesNumberService(IDbContext context) : base(context)
        {
        }
        public async Task<List<QEHAnomaliesNumberEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
