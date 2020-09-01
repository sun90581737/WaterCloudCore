using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Code;
using WaterCloud.Domain.Entity.ProductionManage;

namespace WaterCloud.Service.ProductionManage
{
    public class EHDelayMoldListService : DataFilterService<EHDelayMoldListEntity>, IDenpendency
    {
        public EHDelayMoldListService(IDbContext context) : base(context)
        {
            
        }
        //获取类名
        private string className = System.Reflection.MethodBase.GetCurrentMethod().DeclaringType.FullName.Split('.')[3];
        public async Task<List<EHDelayMoldListEntity>> GetList(Pagination pagination)
        {
            ////获取数据权限
            //var list = GetDataPrivilege("u", className.Substring(0, className.Length - 7));

            //list = list.Where(t => t.IsEffective == 1);
            //return GetFieldsFilterData(await repository.OrderList(list, pagination), className.Substring(0, className.Length - 7));

            var list = repository.IQueryable();
            return await repository.OrderList(list, pagination);
        }
        public async Task<List<EHDelayMoldListEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
