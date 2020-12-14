using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Code;
using WaterCloud.DataBase;
using WaterCloud.Domain.Entity.AutomationLine;

namespace WaterCloud.Service.AutomationLine
{
    public class RunningStateService : DataFilterService<RunningStateEntity>, IDenpendency
    {
        private IRepositoryBase<RunningStateEntity> repository;
        public RunningStateService(IDbContext context) : base(context)
        {
            // repository = new SRepositoryBase<RunningStateEntity>(context);
            repository = new RepositoryBase<RunningStateEntity>(GlobalContext.SystemConfig.DBConnectionStringSubDatabase, GlobalContext.SystemConfig.DBProvider);
        }
        public async Task<List<RunningStateEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
