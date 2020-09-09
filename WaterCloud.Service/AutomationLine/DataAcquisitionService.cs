using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.AutomationLine;

namespace WaterCloud.Service.AutomationLine
{
    public class DataAcquisitionService : DataFilterService<DataAcquisitionEntity>, IDenpendency
    {
        public DataAcquisitionService(IDbContext context) : base(context)
        {
        }
        public async Task<List<DataAcquisitionEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
