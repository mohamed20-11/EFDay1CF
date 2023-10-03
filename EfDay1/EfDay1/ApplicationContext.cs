//using EfDay1.Vendor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfDay1
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            var conf = new ConfigurationBuilder()
                .AddJsonFile("appSittings.json")
                .Build();
            var constr = conf.GetSection("constr").Value;
            optionsBuilder.UseSqlServer(constr);
        }
        public DbSet<Wallet> wallets { get; set; } = null!;

    }
}
//protected override void OnModelCreating(ModelBuilder builder)
//{
//    builder.Entity<Category>();
//}
//protected override void OnConfiguring(DbContextOptionsBuilder builder)
//{
//    builder.UseSqlServer("Data Source=DESKTOP-THUMH45;Initial Catalog=MaredDB Integrated Security=True;Trust Server Certificate=True;");
//}