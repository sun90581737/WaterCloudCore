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
    public class MQMouldListService : DataFilterService<MQMouldListEntity>, IDenpendency
    {
        public MQMouldListService(IDbContext context) : base(context)
        {
        }
        public async Task<List<MQMouldListEntity>> GetList(Pagination pagination, string keyvalue, string keyword = "")
        {
            ////获取数据权限
            //var list = GetDataPrivilege("u", className.Substring(0, className.Length - 7));

            //list = list.Where(t => t.IsEffective == 1);
            //return GetFieldsFilterData(await repository.OrderList(list, pagination), className.Substring(0, className.Length - 7));

            var list = repository.IQueryable();
            if (!string.IsNullOrEmpty(keyword))
            {
                list = list.Where(u => u.MoldNo.Contains(keyword) || u.PartNumber.Contains(keyword) || u.PlannedEquipment.Contains(keyword) || u.Customer.Contains(keyword));
            }
            if (!string.IsNullOrEmpty(keyvalue))
            {
                //var starttime = keyvalue.Substring(0, 10);
                //var endtime = keyvalue.Remove(0, 13);

                DateTime startTime = keyvalue.Substring(0, 10).ToDate();
                DateTime endTime = keyvalue.Remove(0, 13).ToDate().AddDays(1);

                list = list.Where(t => t.StartTime >= startTime && t.ENDTime <= endTime);
            }
            list = list.Where(t => t.IsEffective == 1);
            return await repository.OrderList(list, pagination);
        }
    }
}
