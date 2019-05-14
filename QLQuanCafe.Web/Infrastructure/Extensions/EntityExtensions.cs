using QLQuanCafe.Model.Model;
using QLQuanCafe.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QLQuanCafe.Web.Infrastructure.Extensions
{
    public static class EntityExtensions
    {
        public static void UpdateArea(this Area area, AreaViewModel areaViewModelVm)
        {
            area.ID = areaViewModelVm.ID;
            area.Name = areaViewModelVm.Name;
            area.Image = areaViewModelVm.Image;
            area.DateTime = areaViewModelVm.DateTime;
            area.CreateBy = areaViewModelVm.CreateBy;
            area.CreateDate = areaViewModelVm.CreateDate;
            area.UpdateDate = areaViewModelVm.UpdateDate;
            area.UpdataBy = areaViewModelVm.UpdataBy;
            area.Status = areaViewModelVm.Status;

        }
        public static void UpdateTable(this Table table, TableViewModel tableViewModelVm)
        {
            table.ID = tableViewModelVm.ID;
            table.Name = tableViewModelVm.Name;
            table.AreaID = tableViewModelVm.AreaID;
            table.DateTime = tableViewModelVm.DateTime;
            table.CreateBy = tableViewModelVm.CreateBy;
            table.CreateDate = tableViewModelVm.CreateDate;
            table.UpdateDate = tableViewModelVm.UpdateDate;
            table.UpdataBy = tableViewModelVm.UpdataBy;
            table.Status = tableViewModelVm.Status;
        }
    }
}