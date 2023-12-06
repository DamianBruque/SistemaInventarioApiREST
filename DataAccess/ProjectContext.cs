using Microsoft.EntityFrameworkCore;
using Models.Entities;
using System.Reflection;

namespace DataAccess
{
    public class ProjectContext : DbContext
    {
        public ProjectContext()
        {
            Database.EnsureCreated();
            //Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("ConnectionString"),op =>
            {
                op.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                //op.MigrationsHistoryTable("MigrationHistory");
            });
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserEntity>().ToTable("user");
            modelBuilder.Entity<UserEntity>(entity =>
            {
                entity.HasKey(e => e.UserId);
            });
        }
    }
}
