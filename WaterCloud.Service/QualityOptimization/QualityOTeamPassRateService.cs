using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.QualityOptimization;

namespace WaterCloud.Service.QualityOptimization
{
    public class QualityOTeamPassRateService : DataFilterService<QualityOTeamPassRateEntity>, IDenpendency
    {
        public QualityOTeamPassRateService(IDbContext context) : base(context)
        {
        }
        public async Task<List<QualityOTeamPassRateEntity>> GetList()
        {
            return repository.IQueryable().ToList();
        }
    }
}
