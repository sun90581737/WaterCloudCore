﻿using Chloe;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WaterCloud.Code;
using WaterCloud.Domain.Entity.ProcessScheduling;

namespace WaterCloud.Service.ProcessScheduling
{
    public class PSWorkpieceDetailsListService : DataFilterService<PSWorkpieceDetailsListEntity>, IDenpendency
    {
        public PSWorkpieceDetailsListService(IDbContext context) : base(context)
        {
        }
        public async Task<List<PSWorkpieceDetailsListEntity>> GetList(Pagination pagination)
        {
            ////获取数据权限
            //var list = GetDataPrivilege("u", className.Substring(0, className.Length - 7));

            //list = list.Where(t => t.IsEffective == 1);
            //return GetFieldsFilterData(await repository.OrderList(list, pagination), className.Substring(0, className.Length - 7));

            var list = repository.IQueryable();
            list = list.Where(t => t.IsEffective == 1);
            return await repository.OrderList(list, pagination);
        }
    }
}