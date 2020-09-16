using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.ProcessScheduling;

namespace WaterCloud.Service.ProcessScheduling
{
    public class SHDepartmentLoadService : DataFilterService<SHDepartmentLoadEntity>, IDenpendency
    {
        public SHDepartmentLoadService(IDbContext context) : base(context)
        {
        }
        public async Task<List<SHDepartmentLoadEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
