using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.EquipmentMaintain;

namespace WaterCloud.Service.Infrastructure
{
    public interface IEMMaintainAnalysisDepartmentService
    {
        Task<List<EMMaintainAnalysisDepartmentEntity>> GetTableFieldList(int GetTime);
    }
}
