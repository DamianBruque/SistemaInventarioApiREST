using Microsoft.EntityFrameworkCore;
using Models;
using System.Reflection;

namespace DataAccess;

public class ProjectContext : DbContext
{
    public ProjectContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(Environment.GetEnvironmentVariable("ConnectionString"),op =>
        {
            op.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
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
    public DbSet<UserEntity> Users { get; set; }
}
