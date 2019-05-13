using QLQuanCafe.Data.Infrastructure;
using QLQuanCafe.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLQuanCafe.Data.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetByAlias(string alias);
    }
    public class UserRepository : RepositoryBase<User>
    {

        public UserRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }

    }
}

