using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.EquipmentMaintain;

namespace WaterCloud.Service.EquipmentMaintain
{
    public class EMMaintainAnalysisReasonService : DataFilterService<EMMaintainAnalysisReasonEntity>, IDenpendency
    {
        public EMMaintainAnalysisReasonService(IDbContext context) : base(context)
        {
        }
        public async Task<List<EMMaintainAnalysisReasonEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
