using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.EquipmentMaintain;

namespace WaterCloud.Service.Infrastructure
{
    public interface IEOEquipmentJiaDongRateService
    {
        Task<List<EOEquipmentJiaDongRateEntity>> GetTableFieldList(string GetTime);
    }
}
