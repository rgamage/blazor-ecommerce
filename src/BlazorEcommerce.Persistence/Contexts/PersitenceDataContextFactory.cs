using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BlazorEcommerce.Persistence.Contexts
{
    /// <summary>
    /// this is for the sole purpose of generating migrations at design time
    /// </summary>
    public class PersistenceDataContextFactory : IDesignTimeDbContextFactory<PersistenceDataContext>
    {
        public PersistenceDataContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PersistenceDataContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=blazorecommerce;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new PersistenceDataContext(optionsBuilder.Options);
        }
    }
}