using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace fshop.Models
{
    public class datacontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings1.json");
            var configuration = builder.Build();
            optionBuilder.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);

        }
        public DbSet<product> product { get; set; }
        
    }
}
