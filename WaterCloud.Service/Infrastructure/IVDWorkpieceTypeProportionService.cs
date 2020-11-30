using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Domain.Entity.OperationMonitoring;

namespace WaterCloud.Service.Infrastructure
{
    public interface IVDWorkpieceTypeProportionService
    {
        Task<List<VDWorkpieceTypeProportionEntity>> GetTableFieldList(string GetTime);
    }
}
