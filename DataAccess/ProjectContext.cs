using Microsoft.EntityFrameworkCore;
using Models;

namespace DataAccess;

public class ProjectContext : DbContext
{
    public ProjectContext(DbContextOptions<ProjectContext> options) : base(options)
    {

    }
    public ProjectContext()
    {

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlite("Data Source=database.db");
        optionsBuilder.UseOracle(connectionString: Environment.GetEnvironmentVariable("UdemyWebApiOracle"));
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<UserEntity>().ToTable("user");
        modelBuilder.Entity<RoleEntity>().ToTable("role");
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<UserEntity> Users { get; set; }
    public DbSet<RoleEntity> Roles { get; set; }
}
