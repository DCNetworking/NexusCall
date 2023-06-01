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
    public DbSet<UserClient> UserClient { get; set; }
    public DbSet<Ticket> Ticket { get; set; }
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
                Status = Data.StatusType.Active,
                ColorAccent = "rgb(50, 17, 69)"
            },
             new Client()
             {
                 Id = 2,
                 Name = "TDJ Developer",
                 CreatedTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() - 1000,
                 LastChangeTime = 0,
                 LocalUrl = "tdj",
                 Status = Data.StatusType.Active,
                 ColorAccent = "rgb(146,201,3)"
             }
        );
        modelBuilder.Entity<UserClient>().HasData(
            new UserClient()
            {
                Id = 1,
                Uid = "53c8d500-2936-4aa6-8d38-f3b03c34c903",
                AccessGivenUid = "53c8d500-2936-4aa6-8d38-f3b03c34c903",
                ClientId = 1,
                CreatedTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                LastChangeTimestamp = 0,
                Status = Data.StatusType.Active,
                BannedTimestamp = 0,
                AccessPermission = Data.PermissionType.Operator
            },
            new UserClient()
            {
                Id = 2,
                Uid = "53c8d500-2936-4aa6-8d38-f3b03c34c903",
                AccessGivenUid = "53c8d500-2936-4aa6-8d38-f3b03c34c903",
                ClientId = 2,
                CreatedTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                LastChangeTimestamp = 0,
                Status = Data.StatusType.Active,
                BannedTimestamp = 0,
                AccessPermission = Data.PermissionType.Administrator
            }
        );
        modelBuilder.Entity<Ticket>().HasData(
            new Ticket()
            {
                Id = 1,
                TicketCreatedTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                TicketEndTime = 0,
                TicketLastChangeTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds(),
                ClientId = 1,
                TicketCaseType = Data.TicketCaseType.AccountAccess
            },
            new Ticket()
            {
                Id = 2,
                TicketCreatedTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() - 1800,
                TicketEndTime = 0,
                TicketLastChangeTime = DateTimeOffset.UtcNow.ToUnixTimeSeconds() - 1800,
                ClientId = 1,
                TicketCaseType = Data.TicketCaseType.BillingInquiry
            }
        );

    }
}

