using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.AutomationLine;

namespace WaterCloud.Service.Infrastructure
{
    public interface IDataAcquisitionDetailService
    {
        Task<List<DataAcquisitionDetailEntity>> GetTableFieldList(string ConfTime);
    }
}
