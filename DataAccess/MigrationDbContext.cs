using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class MigrationDbContext : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            //optBuilder.UseSqlServer("Server=(localdЬ)\\MSSQLLocalDB;Database=ShopFront"); 
            optBuilder.UseSqlServer("Server=DESKTOP-G5UDAJT\\SQLEXPRESS;Database=ShopFront;Trusted_Connection=True;");
            return new ApplicationDbContext(optBuilder.Options);
        }
    }
}
