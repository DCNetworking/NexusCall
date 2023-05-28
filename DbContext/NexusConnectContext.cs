using System;
using System.Data;
namespace nexus_connect.DbContext;

using Microsoft.AspNetCore.Identity;
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
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Client>().HasData(
            new Client()
            {
                Id = 1,
                Name = "E-Bay",
                CreatedTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                LastChangeTime = 0,
                LocalUrl = "ebay",
                Status = Data.StatusType.Active
            },
             new Client()
             {
                 Id = 2,
                 Name = "TDJ Developer",
                 CreatedTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() - 1000,
                 LastChangeTime = 0,
                 LocalUrl = "tdj",
                 Status = Data.StatusType.Active
             }
        );
        modelBuilder.Entity<Ticket>().HasData(
            new Ticket()
            {
                Id = 1,
                TicketCreatedTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                TicketEndTime = 0,
                TicketLastChangeTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                Cid = 1,
                TicketCaseType = Data.TicketCaseType.AccountAccess
            },
            new Ticket()
            {
                Id = 2,
                TicketCreatedTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() - 1800,
                TicketEndTime = 0,
                TicketLastChangeTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() - 1800,
                Cid = 1,
                TicketCaseType = Data.TicketCaseType.BillingInquiry
            }
        );

    }
}

