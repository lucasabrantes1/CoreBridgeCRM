using CoreBridgeCRM.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreBridgeCRM.Infrastructure.DataAccess;
public class CoreBridgeCRMDbContext : DbContext
{
    public CoreBridgeCRMDbContext(DbContextOptions options) : base(options) { }

    public DbSet<Expense> Expenses { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.HasDefaultSchema("corebridgecrm");

        modelBuilder.Entity<Tag>().ToTable("Tags");
    }
}
