﻿using QLQuanCafe.Data.Infrastructure;
using QLQuanCafe.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCafe.Data.Repositories
{
    public interface IErrorRepository : IRepository<Error>
    {
      
    }
    public class ErrorRepository : RepositoryBase<Error>,IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}

