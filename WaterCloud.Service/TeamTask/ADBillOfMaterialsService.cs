using Chloe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Code;
using WaterCloud.Domain.Entity.TeamTask;

namespace WaterCloud.Service.TeamTask
{
    public class ADBillOfMaterialsService : DataFilterService<ADBillOfMaterialsEntity>, IDenpendency
    {
        public ADBillOfMaterialsService(IDbContext context) : base(context)
        {
        }
        public async Task<List<ADBillOfMaterialsEntity>> GetListWL(Pagination pagination, string keyvalue)
        {
            ////获取数据权限
            //var list = GetDataPrivilege("u", className.Substring(0, className.Length - 7));

            //list = list.Where(t => t.IsEffective == 1);
            //return GetFieldsFilterData(await repository.OrderList(list, pagination), className.Substring(0, className.Length - 7));

            var list = repository.IQueryable();
            if (!string.IsNullOrEmpty(keyvalue))
            {
                DateTime startTime = keyvalue.Substring(0, 10).ToDate();
                DateTime endTime = keyvalue.Remove(0, 13).ToDate().AddDays(0);

                list = list.Where(t => t.ReceivingTime >= startTime && t.ReceivingTime <= endTime);
            }
            list = list.Where(t => t.IsEffective == 1 && t.TableType == "WL");
            return await repository.OrderList(list, pagination);
        }
        public async Task<List<ADBillOfMaterialsEntity>> GetListZZ(Pagination pagination, string keyvalue)
        {
            ////获取数据权限
            //var list = GetDataPrivilege("u", className.Substring(0, className.Length - 7));

            //list = list.Where(t => t.IsEffective == 1);
            //return GetFieldsFilterData(await repository.OrderList(list, pagination), className.Substring(0, className.Length - 7));

            var list = repository.IQueryable();
            if (!string.IsNullOrEmpty(keyvalue))
            {
                DateTime startTime = keyvalue.Substring(0, 10).ToDate();
                DateTime endTime = keyvalue.Remove(0, 13).ToDate().AddDays(0);

                list = list.Where(t => t.ReceivingTime >= startTime && t.ReceivingTime <= endTime);
            }
            list = list.Where(t => t.IsEffective == 1 && t.TableType == "ZZ");
            return await repository.OrderList(list, pagination);
        }
    }
}
