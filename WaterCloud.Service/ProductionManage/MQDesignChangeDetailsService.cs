using Chloe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Code;
using WaterCloud.Domain.Entity.ProductionManage;

namespace WaterCloud.Service.ProductionManage
{
    public class MQDesignChangeDetailsService : DataFilterService<MQDesignChangeDetailsEntity>, IDenpendency
    {
        public MQDesignChangeDetailsService(IDbContext context) : base(context)
        {
        }
        public async Task<List<MQDesignChangeDetailsEntity>> GetList(Pagination pagination, string keyvalue)
        {
            ////获取数据权限
            //var list = GetDataPrivilege("u", className.Substring(0, className.Length - 7));

            //list = list.Where(t => t.IsEffective == 1);
            //return GetFieldsFilterData(await repository.OrderList(list, pagination), className.Substring(0, className.Length - 7));

            var list = repository.IQueryable();
            if (!string.IsNullOrEmpty(keyvalue))
            {
                DateTime startTime = keyvalue.Substring(0, 10).ToDate();
                DateTime endTime = keyvalue.Remove(0, 13).ToDate();

                list = list.Where(t => t.DCTime >= startTime && t.DCTime <= endTime);
            }
            list = list.Where(t => t.IsEffective == 1);
            return await repository.OrderList(list, pagination);
        }
    }
}
