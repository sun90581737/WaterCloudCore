using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.ProcessScheduling;

namespace WaterCloud.Service.ProcessScheduling
{
    public class PSProcessDetailsListService : DataFilterService<PSProcessDetailsListEntity>, IDenpendency
    {
        public PSProcessDetailsListService(IDbContext context) : base(context)
        {
        }
        public async Task<List<PSProcessDetailsListEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
