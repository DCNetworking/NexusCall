using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using nexus_connect.Data.Entities;
using nexus_connect.DbContext;

namespace nexus_connect.Data
{
    public class NexusConnectRepository
    {
        readonly NexusConnectContext _ctx;
        public NexusConnectRepository(NexusConnectContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<IEnumerable<Client>> GetAllClientsAsync()
        {
            return await _ctx.Client.OrderBy(p => p.CreatedTime).ToListAsync();
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
    }
}