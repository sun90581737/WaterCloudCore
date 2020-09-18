using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.EquipmentMaintain;

namespace WaterCloud.Service.EquipmentMaintain
{
    public class EMMaintainAnalysisService : DataFilterService<EMMaintainAnalysisEntity>, IDenpendency
    {
        public EMMaintainAnalysisService(IDbContext context) : base(context)
        {
        }
        public async Task<List<EMMaintainAnalysisEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
