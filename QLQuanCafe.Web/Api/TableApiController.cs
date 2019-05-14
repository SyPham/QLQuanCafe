using QLQuanCafe.Model.Model;
using QLQuanCafe.Service;
using QLQuanCafe.Web.Infrastructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QLQuanCafe.Web.Api
{
    public class TableApiController : ApiControllerBase
    {
        ITableService _tableService;

        public TableApiController(IErrorService errorService, ITableService tableService) : base(errorService)
        {
            this._tableService = tableService;
        }
       
    }
}
