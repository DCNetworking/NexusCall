using System.Data.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using nexus_connect.Data.Entities;
using nexus_connect.DbContext;
using nexus_connect.ViewModels;

namespace nexus_connect.Data
{
    public class NexusConnectRepository : INexusConnectRepository
    {
        readonly NexusConnectContext _ctx;
        public NexusConnectRepository(NexusConnectContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<IEnumerable<Client>> GetAllClientsAsync()
        {
            return await _ctx.Client.OrderByDescending(p => p.CreatedTime).ToListAsync();
        }
        public async Task<Client> GetClientByIdAsync(int id)
        {
            return await _ctx.Client.FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task<IEnumerable<Client>> GetClientsByStatusAsync(StatusType status)
        {
            return await _ctx.Client.Where(p => p.Status == status).ToListAsync();
        }
        public async Task<IEnumerable<Client>> GetClientsByStatusAsync(int status)
        {
            return await _ctx.Client.Where(p => p.Status.GetHashCode() == status).ToListAsync();
        }
        public async Task<IEnumerable<Client>> GetUserClients(string Uid)
        {

            var clients = await _ctx.Client
           .Join(
               _ctx.UserClient,
               client => client.Id,
               userClient => userClient.ClientId,
               (client, userClient) => new { Client = client, UserClient = userClient }
           )
           .Where(joinResult => joinResult.UserClient.Uid == Uid && joinResult.UserClient.Status == Data.StatusType.Active)
           .Select(joinResult => joinResult.Client)
           .ToListAsync();
            return clients;
        }
        public async Task<IEnumerable<UserClientViewModel>> GetUserClientsView(string Uid)
        {

            List<UserClientViewModel>? clients = await _ctx.Client
           .Join(
               _ctx.UserClient,
               client => client.Id,
               userClient => userClient.ClientId,
               (client, userClient) => new { Client = client, UserClient = userClient }
           )
           .Where(joinResult => joinResult.UserClient.Uid == Uid && joinResult.UserClient.Status == Data.StatusType.Active)
           .Select(joinResult => new ViewModels.UserClientViewModel
           {
               CreatedTimestamp = joinResult.UserClient.CreatedTimestamp,
               LastChangeTimestamp = joinResult.UserClient.LastChangeTimestamp,
               AccessPermission = joinResult.UserClient.AccessPermission,
               Name = joinResult.Client.Name,
               Id = joinResult.Client.Id,
               ColorAccent = joinResult.Client.ColorAccent
           })
           .ToListAsync();
            return clients;
        }
    }
}