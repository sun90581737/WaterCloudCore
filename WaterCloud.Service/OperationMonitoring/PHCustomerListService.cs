using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Code;
using WaterCloud.Domain.Entity.OperationMonitoring;

namespace WaterCloud.Service.OperationMonitoring
{
    public class PHCustomerListService : DataFilterService<PHCustomerListEntity>, IDenpendency
    {
        public PHCustomerListService(IDbContext context) : base(context)
        {
        }
        public async Task<List<PHCustomerListEntity>> GetList(Pagination pagination, string keyword = "")
        {
            ////获取数据权限
            //var list = GetDataPrivilege("u", className.Substring(0, className.Length - 7));

            //list = list.Where(t => t.IsEffective == 1);
            //return GetFieldsFilterData(await repository.OrderList(list, pagination), className.Substring(0, className.Length - 7));

            var list = repository.IQueryable();
            if (!string.IsNullOrEmpty(keyword))
            {
                list = list.Where(u => u.CustomerName.Contains(keyword) || u.CustomerCode.Contains(keyword) || u.CustomerContact.Contains(keyword) || u.LeadingCadre.Contains(keyword));
            }
            list = list.Where(t => t.IsEffective == 1);
            return await repository.OrderList(list, pagination);
        }
        public async Task<List<PHCustomerListEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
