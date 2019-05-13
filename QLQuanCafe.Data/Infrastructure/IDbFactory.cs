using System;

namespace QLQuanCafe.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        QLQuanCafeDbContext Init();
    }
}