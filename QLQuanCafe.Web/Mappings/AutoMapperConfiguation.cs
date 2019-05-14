using AutoMapper;
using QLQuanCafe.Model.Model;
using QLQuanCafe.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace QLQuanCafe.Web.Mappings
{
    public class AutoMapperConfiguation
    {
        public static void Configure()
        {
            Mapper.CreateMap<Area, AreaViewModel>();

        }
    }
}