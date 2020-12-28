using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.EquipmentMaintain;

namespace WaterCloud.Service.Infrastructure
{
    public interface IEOJiaDongRateContrastService
    {
        Task<List<EOJiaDongRateContrastEntity>> GetDistinctType();
        Task<List<EOJiaDongRateContrastEntity>> GetTableFieldList(string GetTime, string GetType);
    }
}
