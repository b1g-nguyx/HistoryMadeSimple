using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HistoyMadeSimple_DBAcess
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<HistoryMadeSimpleContext>
    {
        public HistoryMadeSimpleContext CreateDbContext(string[] args)
        {

            var basePath = Path.Combine(Directory.GetCurrentDirectory(), "../HistoryMadeSimple");

            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<HistoryMadeSimpleContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new HistoryMadeSimpleContext(optionsBuilder.Options);

        }
    }
}
