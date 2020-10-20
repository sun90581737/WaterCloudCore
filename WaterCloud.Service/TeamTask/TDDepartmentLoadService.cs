using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.TeamTask;

namespace WaterCloud.Service.TeamTask
{
    public class TDDepartmentLoadService : DataFilterService<TDDepartmentLoadEntity>, IDenpendency
    {
        public TDDepartmentLoadService(IDbContext context) : base(context)
        {
        }
        public async Task<List<TDDepartmentLoadEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
