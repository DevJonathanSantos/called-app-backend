using ChamadosSetor8.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChamadosSetor8.Infra.Data.Context;

public class Sector8CallsContext : DbContext
{
    public Sector8CallsContext(DbContextOptions<Sector8CallsContext> options) : base(options) 
    {
        DbInitializer.Initialize(this);
    }

    public DbSet<User> User { get; set; }
    public DbSet<Church> Church { get; set; }
    public DbSet<Department> Department { get; set; }
    public DbSet<Profile> Profile { get; set; }
    public DbSet<Group> Group { get; set; }
    //public DbSet<UserChurch> UserChurch { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(Sector8CallsContext).Assembly);
        base.OnModelCreating(modelBuilder);
    }
}
