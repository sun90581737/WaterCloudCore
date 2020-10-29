using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.EquipmentMaintain;

namespace WaterCloud.Service.EquipmentMaintain
{
    public class DDJiaDongRateTrendService : DataFilterService<DDJiaDongRateTrendEntity>, IDenpendency
    {
        public DDJiaDongRateTrendService(IDbContext context) : base(context)
        {
        }
        public async Task<List<DDJiaDongRateTrendEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
