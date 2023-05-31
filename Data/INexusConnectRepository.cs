using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using nexus_connect.Data.Entities;
using nexus_connect.ViewModels;

namespace nexus_connect.Data
{
    public interface INexusConnectRepository
    {

        Task<IEnumerable<Client>> GetAllClientsAsync();
        Task<Client> GetClientByIdAsync(int id);
        Task<IEnumerable<Client>> GetClientsByStatusAsync(StatusType status);
        Task<IEnumerable<Client>> GetClientsByStatusAsync(int status);
        Task<IEnumerable<Client>> GetUserClients(string Uid);
        Task<IEnumerable<UserClientViewModel>> GetUserClientsView(string Uid);
    }
}