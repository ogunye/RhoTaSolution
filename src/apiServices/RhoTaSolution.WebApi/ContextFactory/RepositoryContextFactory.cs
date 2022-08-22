using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using RhoTaSolution.Infrastructure.Persistence.ApplicationDBContext;

namespace RhoTaSolution.WebApi.ContextFactory
{
    public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
    {
        public RepositoryContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appSettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<RepositoryContext>()
                .UseSqlServer(configuration.GetConnectionString("sqlServerConnection"),
                b => b.MigrationsAssembly("RhoTaSolution.WebApi"));

            return new RepositoryContext(builder.Options);
        }
    }
}
