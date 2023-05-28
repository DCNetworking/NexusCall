using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using nexus_connect.Data.Entities;

namespace nexus_connect.Data
{
    public interface INexusConnectRepository
    {

        Task<IEnumerable<Client>> GetAllClientsAsync();
        Task<Client> GetClientByIdAsync(int id);
        Task<IEnumerable<Client>> GetClientsByStatusAsync(StatusType status);
        Task<IEnumerable<Client>> GetClientsByStatusAsync(int status);
    }
}