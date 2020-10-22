using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.WarehousingLogistics;

namespace WaterCloud.Service.Infrastructure
{
    public interface ISDDeliveryPassRateService
    {
        Task<List<SDDeliveryPassRateEntity>> GetTableFieldList(string GetTime);
    }
}
