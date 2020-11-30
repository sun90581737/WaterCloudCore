using Chloe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.OperationMonitoring;

namespace WaterCloud.Service.OperationMonitoring
{
    public class VDQualifizierteVerarbeitungsrateService : DataFilterService<VDQualifizierteVerarbeitungsrateEntity>, IDenpendency
    {
        public VDQualifizierteVerarbeitungsrateService(IDbContext context) : base(context)
        {
        }
        public async Task<List<VDQualifizierteVerarbeitungsrateEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
