using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.AutomationLine;

namespace WaterCloud.Service.AutomationLine
{
    public class DataAcquisitionDetailService : DataFilterService<DataAcquisitionDetailEntity>, IDenpendency
    {
        public DataAcquisitionDetailService(IDbContext context) : base(context)
        {
        }
        public async Task<List<DataAcquisitionDetailEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
