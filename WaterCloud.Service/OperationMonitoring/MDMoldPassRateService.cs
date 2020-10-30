using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.OperationMonitoring;

namespace WaterCloud.Service.OperationMonitoring
{
    public class MDMoldPassRateService : DataFilterService<MDMoldPassRateEntity>, IDenpendency
    {
        public MDMoldPassRateService(IDbContext context) : base(context)
        {
        }
        public async Task<List<MDMoldPassRateEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
