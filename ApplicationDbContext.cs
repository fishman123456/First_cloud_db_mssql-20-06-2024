using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudSqlServer_App
{
    internal class ApplicationDbContext : DbContext
    {
        public DbSet<Entity> Entities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string useConnection = ConfigurationManager.AppSettings["UseConnection"] ?? "DefaultConnection";
            string connectionString = ConfigurationManager.ConnectionStrings[useConnection].ConnectionString;
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
