using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Code;
using WaterCloud.Domain.Entity.EquipmentMaintain;

namespace WaterCloud.Service.EquipmentMaintain
{
    public class DDPassRateTrendService : DataFilterService<DDPassRateTrendEntity>, IDenpendency
    {
        public DDPassRateTrendService(IDbContext context) : base(context)
        {
        }
        public async Task<List<DDPassRateTrendEntity>> GetList(string keyvalue)
        {
            var list = repository.IQueryable();
            if (!string.IsNullOrEmpty(keyvalue))
            {
                DateTime startTime = keyvalue.Substring(0, 10).ToDate();
                DateTime endTime = keyvalue.Remove(0, 13).ToDate();

                list = list.Where(t => t.AcctDate >= startTime && t.AcctDate <= endTime);
            }
            return list.ToList();
        }
    }
}
