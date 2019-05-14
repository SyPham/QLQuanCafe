using QLQuanCafe.Data.Infrastructure;

namespace QLQuanCafe.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private QLQuanCafeDbContext dbContext;

        public QLQuanCafeDbContext Init()
        {
            return dbContext ?? (dbContext = new QLQuanCafeDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}