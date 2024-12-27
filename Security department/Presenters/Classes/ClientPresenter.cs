using Security_department.DTOs;
using Security_department.Mappers;
using Security_department.Presenters.Interface;
using Security_department.Services.Interface;
using Security_department.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Presenters.Classes
{
    public class ClientPresenter : IClientPresenter
    {
        private readonly IClientService _clientService;
        private readonly IClientView _clientView;

        public ClientPresenter(IClientService clientService, IClientView clientView)
        {
            _clientService = clientService;
            _clientView = clientView;
        }

        public void LoadClients()
        {
            var clients = _clientService.GetAllClients();
            _clientView.ClearClientList();

            foreach (var client in clients)
            {
                _clientView.AddClientToList(client);
            }
        }

        public void AddClient(ClientDTO clientDto)
        {
            _clientService.AddClient(clientDto);
            LoadClients();
        }

        public void RemoveClient(int id)
        {
            _clientService.RemoveClient(id); 
            LoadClients(); 
        }

        public void UpdateClient(ClientDTO clientDto)
        {
            var client = ClientMapper.ToEntity(clientDto);
            _clientService.UpdateClient(client); 
            LoadClients(); 
        }
        public List<ClientDTO> GetAllClients()
        {
            return _clientService.GetAllClients();
        }
    }
}
