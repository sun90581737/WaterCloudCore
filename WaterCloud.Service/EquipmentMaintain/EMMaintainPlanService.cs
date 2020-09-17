using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Code;
using WaterCloud.DataBase;
using WaterCloud.Domain.Entity.EquipmentMaintain;
using WaterCloud.Service.Infrastructure;

namespace WaterCloud.Service.EquipmentMaintain
{
    public class EMMaintainPlanService : DataFilterService<EMMaintainPlanEntity>, IDenpendency
    {
        public EMMaintainPlanService(IDbContext context) : base(context)
        {
        }
        public async Task<List<EMMaintainPlanEntity>> GetList(Pagination pagination, string keyvalue, string keyword = "")
        {
            ////获取数据权限
            //var list = GetDataPrivilege("u", className.Substring(0, className.Length - 7));

            //list = list.Where(t => t.IsEffective == 1);
            //return GetFieldsFilterData(await repository.OrderList(list, pagination), className.Substring(0, className.Length - 7));

            var list = repository.IQueryable();
            if (!string.IsNullOrEmpty(keyword))
            {
                list = list.Where(u => u.EquipmentNumber.Contains(keyword) || u.EquipmentName.Contains(keyword) || u.Department.Contains(keyword) || u.MaintainType.Contains(keyword));
            }
            if (!string.IsNullOrEmpty(keyvalue))
            {
                //var starttime = keyvalue.Substring(0, 10);
                //var endtime = keyvalue.Remove(0, 13);

                DateTime startTime = keyvalue.Substring(0, 10).ToDate();
                DateTime endTime = keyvalue.Remove(0, 13).ToDate();

                list = list.Where(t => t.PlanStartTime >= startTime && t.PlanEndTime <= endTime);
            }
            list = list.Where(t => t.IsEffective == 1);
            return await repository.OrderList(list, pagination);
        }
        public async Task<List<EMMaintainPlanEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
