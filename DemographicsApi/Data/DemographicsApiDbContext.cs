namespace DemographicsApi.Data
{
    using DemographicsApi.Data.Models;
    using Microsoft.EntityFrameworkCore;

    public class DemographicsApiDbContext : DbContext
    {

        public DemographicsApiDbContext(DbContextOptions<DemographicsApiDbContext> options)
            :base(options)
        {
                    
        }

        public DbSet<State> States { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


    }
}
