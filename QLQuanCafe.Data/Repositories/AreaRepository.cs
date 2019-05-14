using QLQuanCafe.Data.Infrastructure;
using QLQuanCafe.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCafe.Data.Repositories
{
    public interface IAreaRepository : IRepository<Area>
    {
        IEnumerable<Area> GetByAlias(string alias);
        IEnumerable<Area> GetAllByTag(int areaID,int page, int pageSize, out int totalRow);
    }
    public class AreaRepository : RepositoryBase<Area>,IAreaRepository
    {
        public AreaRepository(IDbFactory dbFactory) : base(dbFactory)
        {
           
        }

        public IEnumerable<Area> GetAllByTag(int areaID, int pageIndex, int pageSize, out int totalRow)
        {
            var query = from a in DbContext.Areas
                        join t in DbContext.Tables
                        on a.ID equals t.AreaID
                        where t.AreaID == areaID && t.Status
                        orderby a.CreateDate descending
                        select a;
            totalRow = query.Count();
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return query;
        }

        public IEnumerable<Area> GetByAlias(string alias)
        {
            throw new NotImplementedException();
        }
    }
}

