using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLQuanCafe.Model;
using QLQuanCafe.Model.Model;

namespace QLQuanCafe.Data
{
    public class QLQuanCafeDbContext : DbContext
    {
        public QLQuanCafeDbContext() : base("QLQuanCafeConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserPermision> UserPermisions { get; set; }
        public DbSet<Permision> Permisions { get; set; }
        public DbSet<PermisionDetail> PermisionDetails { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<GroupItem> GroupItems { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillDetail> BillDetails { get; set; }
        public DbSet<Bonus> Bonus { get; set; }



        protected override void OnModelCreating(DbModelBuilder builder)
        {
            //builder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId });
            //builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
        }
    }
}
