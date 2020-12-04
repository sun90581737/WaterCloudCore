

using Chloe;
using System.Collections.Generic;
using System.Threading.Tasks;
using WaterCloud.DataBase;
using WaterCloud.Domain.Entity.TeamTask;

namespace WaterCloud.Service.TeamTask
{
    public class TDDepartmentQualifiedRateService: IDenpendency
    {
        private IRepositoryBase<TDDepartmentQualifiedRateEntity> repository;
        private IRepositoryBase uniwork;
        public TDDepartmentQualifiedRateService(IDbContext context)
        {
            repository = new RepositoryBase<TDDepartmentQualifiedRateEntity>(context);
            uniwork = new RepositoryBase(context);
        }
        public async Task<List<TDDepartmentQualifiedRateEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
