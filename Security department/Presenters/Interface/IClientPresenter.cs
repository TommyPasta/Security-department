using Security_department.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Presenters.Interface
{
    public interface IClientPresenter
    {
        void LoadClients();
        void AddClient(ClientDTO clientDto);
        void RemoveClient(int id);
        void UpdateClient(ClientDTO clientDto);
        List<ClientDTO> GetAllClients(); // Новый метод
    }
}
