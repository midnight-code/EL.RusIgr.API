using EL.RusIgr.API.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace EL.RusIgr.API.DataSql
{
    public class BaseContext : DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> opt) : base(opt) { }

        public DbSet<OtdelModel> Otdel { get; set; }
        public DbSet<TipOtdelaModel> TipOtdel { get; set; }
        public DbSet<KatalogModel> Katalog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
