using QLQuanCafe.Data.Infrastructure;
using QLQuanCafe.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCafe.Data.Repositories
{
    public interface ITableRepository : IRepository<Table>
    {
        IEnumerable<Table> GetByAlias(string alias);
        IEnumerable<Table> GetAllByTag(string tag,int page, int pageSize, out int totalRow);
    }
    public class TableRepository : RepositoryBase<Table>,ITableRepository
    {
        public TableRepository(IDbFactory dbFactory) : base(dbFactory)
        {
            
        }

        public IEnumerable<Table> GetAllByTag(string tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Table> GetByAlias(string alias)
        {
            throw new NotImplementedException();
        }
    }
}

