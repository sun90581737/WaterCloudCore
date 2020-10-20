using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Code;
using WaterCloud.Domain.Entity.TeamTask;

namespace WaterCloud.Service.TeamTask
{
    public class TDDepartmentTasksService : DataFilterService<TDDepartmentTasksEntity>, IDenpendency
    {
        public TDDepartmentTasksService(IDbContext context) : base(context)
        {
        }
        public async Task<List<TDDepartmentTasksEntity>> GetList(Pagination pagination)
        {
            ////获取数据权限
            //var list = GetDataPrivilege("u", className.Substring(0, className.Length - 7));

            //list = list.Where(t => t.IsEffective == 1);
            //return GetFieldsFilterData(await repository.OrderList(list, pagination), className.Substring(0, className.Length - 7));

            var list = repository.IQueryable();
            list = list.Where(t => t.IsEffective == 1);
            return await repository.OrderList(list, pagination);
        }
        public async Task<List<TDDepartmentTasksEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
