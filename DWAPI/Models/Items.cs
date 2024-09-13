using Microsoft.EntityFrameworkCore;

namespace DamnVulnerableApi.Models;

public class Items
{
    public long Id { get; set; }
    public string Name { get; set; }
    public bool IsComplete { get; set; }
}
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Items> TodoItems { get; set; }
}