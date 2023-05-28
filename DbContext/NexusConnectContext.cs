namespace nexus_connect.DbContext;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using nexus_connect.Data.Entities;
public class NexusConnectContext : IdentityDbContext<StoreUser>
{
    public DbSet<Client> Client { get; set; }

    public NexusConnectContext(DbContextOptions<NexusConnectContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>().HasData(
            new Client()
            {
                Id = 1,
                Name = "E-Bay",
                CreatedTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                LastChangeTime = 0,
                LocalUrl = "ebay",
                Status = Data.StatusType.Active
            }
        );
        base.OnModelCreating(modelBuilder);
    }
}

