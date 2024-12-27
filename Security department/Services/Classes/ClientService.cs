using Security_department.DTOs;
using Security_department.Mappers;
using Security_department.Repositories.Interfaces;
using Security_department.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public List<ClientDTO> GetAllClients()
        {
            var clients = _clientRepository.GetAll();
            var clientDtos = new List<ClientDTO>();

            foreach (var client in clients)
            {
                clientDtos.Add(ClientMapper.ToDto(client)); // Преобразование сущности в DTO
            }

            return clientDtos;
        }

        public void AddClient(ClientDTO clientDto)
        {
            var client = ClientMapper.ToEntity(clientDto); // Преобразование DTO в сущность
            _clientRepository.Add(client); // Добавление клиента в репозиторий
        }

        public void RemoveClient(int id)
        {
            _clientRepository.Remove(id); // Удаление клиента по ID
        }

        public void UpdateClient(Client client)
        {
            var existingClient = _clientRepository.GetById(client.Id);
            if (existingClient == null)
            {
                throw new ArgumentException("Клиент не найден.");
            }

            // Обновление данных клиента
            existingClient.Update(client.FirstName, client.SecondName, client.Surname, client.Address, client.Phone, client.Passport);
            _clientRepository.Update(existingClient); // Сохранение изменений в репозитории
        }
    }
}