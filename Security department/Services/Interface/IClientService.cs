using Security_department.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Services.Interface
{
    public interface IClientService
    {
        void AddClient(ClientDTO clientDto);
        void RemoveClient(int id);
        ClientDTO GetClientById(int id);
        List<ClientDTO> GetAllClients();
    }
}
