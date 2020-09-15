using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Code;
using WaterCloud.Domain.Entity.CostAnalysis;

namespace WaterCloud.Service.CostAnalysis
{
    public class FACostComparisonService : DataFilterService<FACostComparisonEntity>, IDenpendency
    {
        public FACostComparisonService(IDbContext context) : base(context)
        {
        }
        public async Task<List<FACostComparisonEntity>> GetList(Pagination pagination, string keyword = "")
        {
            ////获取数据权限
            //var list = GetDataPrivilege("u", className.Substring(0, className.Length - 7));

            //list = list.Where(t => t.IsEffective == 1);
            //return GetFieldsFilterData(await repository.OrderList(list, pagination), className.Substring(0, className.Length - 7));

            var list = repository.IQueryable();
            if (!string.IsNullOrEmpty(keyword))
            {
                list = list.Where(u => u.Customer.Contains(keyword) || u.MoldNo.Contains(keyword) || u.MoldName.Contains(keyword) ||  u.QuotationStaff.Contains(keyword));
            }
            list = list.Where(t => t.IsEffective == 1);
            return await repository.OrderList(list, pagination);
        }
        public async Task<List<FACostComparisonEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
