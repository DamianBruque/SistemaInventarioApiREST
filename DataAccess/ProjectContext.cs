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
        optionsBuilder.UseSqlite("Data Source=database.db");
        base.OnConfiguring(optionsBuilder);
    }
    

    public DbSet<UserEntity> Users { get; set; }
}
