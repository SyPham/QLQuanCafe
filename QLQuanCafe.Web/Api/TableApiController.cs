using AutoMapper;
using QLQuanCafe.Model.Model;
using QLQuanCafe.Service;
using QLQuanCafe.Web.Infrastructure.Core;
using QLQuanCafe.Web.Infrastructure.Extensions;
using QLQuanCafe.Web.Models;
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
        [Route("getall")]
        public HttpResponseMessage Get(HttpRequestMessage request)
        {
            return CreateHttpResponse(request, () =>
            {
                var listTable = _tableService.GetAll();

                var listTableVm = Mapper.Map<List<TableViewModel>>(listTable);

                HttpResponseMessage response = request.CreateResponse(HttpStatusCode.OK, listTableVm);

                return response;
            });
        }
        [Route("add")]
        public HttpResponseMessage Post(HttpRequestMessage request, TableViewModel tableViewModel)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    Table newTable = new Table();
                    newTable.UpdateTable(tableViewModel);

                  var table= _tableService.Add(newTable);
                    _tableService.SaveChange();

                    response = request.CreateResponse(HttpStatusCode.Created, table);

                }
                return response;
            });
        }

        [Route("update")]
        public HttpResponseMessage Put(HttpRequestMessage request, TableViewModel tableVm)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    var tableDb = _tableService.GetById(tableVm.ID);
                    tableDb.UpdateTable(tableVm);
                    _tableService.Update(tableDb);
                    _tableService.SaveChange();

                    response = request.CreateResponse(HttpStatusCode.OK);

                }
                return response;
            });
        }

        public HttpResponseMessage Delete(HttpRequestMessage request, int id)
        {
            return CreateHttpResponse(request, () =>
            {
                HttpResponseMessage response = null;
                if (ModelState.IsValid)
                {
                    request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
                }
                else
                {
                    _tableService.Delete(id);
                    _tableService.SaveChange();

                    response = request.CreateResponse(HttpStatusCode.OK);

                }
                return response;
            });
        }
    }
}
