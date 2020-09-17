using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.EquipmentMaintain;

namespace WaterCloud.Service.EquipmentMaintain
{
    public class EMEquipmentStatusService : DataFilterService<EMEquipmentStatusEntity>, IDenpendency
    {
        public EMEquipmentStatusService(IDbContext context) : base(context)
        {
        }
        public async Task<List<EMEquipmentStatusEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
