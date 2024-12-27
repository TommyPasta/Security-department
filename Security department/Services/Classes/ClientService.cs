using Security_department.DTOs;
using Security_department.Repositories.Interfaces;
using Security_department.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Services.Classes
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public void AddClient(ClientDTO clientDto)
        {
            var client = new Client(clientDto.Id, clientDto.FirstName, clientDto.SecondName, clientDto.Surname, clientDto.Address, clientDto.Phone,
                new Passport(clientDto.Passport.PassportNumber, clientDto.Passport.IssuingAuthority, clientDto.Passport.DateOfIssue, clientDto.Passport.DateOfExpiry));
            _clientRepository.Add(client);
        }

        public void RemoveClient(int id)
        {
            _clientRepository.Remove(id);
        }

        public ClientDTO GetClientById(int id)
        {
            var client = _clientRepository.GetById(id);
            if (client == null) return null;

            return new ClientDTO
            {
                Id = client.Id,
                FirstName = client.FirstName,
                SecondName = client.SecondName,
                Surname = client.Surname,
                Address = client.Address,
                Phone = client.Phone,
                Passport = new PassportDTO
                {
                    PassportNumber = client.Passport.PassportNumber,
                    IssuingAuthority = client.Passport.IssuingAuthority,
                    DateOfIssue = client.Passport.DateOfIssue,
                    DateOfExpiry = client.Passport.DateOfExpiry
                }
            };
        }

        public List<ClientDTO> GetAllClients()
        {
            var clients = _clientRepository.GetAll();
            var clientDtos = new List<ClientDTO>();

            foreach (var client in clients)
            {
                clientDtos.Add(new ClientDTO
                {
                    Id = client.Id,
                    FirstName = client.FirstName,
                    SecondName = client.SecondName,
                    Surname = client.Surname,
                    Address = client.Address,
                    Phone = client.Phone,
                    Passport = new PassportDTO
                    {
                        PassportNumber = client.Passport.PassportNumber,
                        IssuingAuthority = client.Passport.IssuingAuthority,
                        DateOfIssue = client.Passport.DateOfIssue,
                        DateOfExpiry = client.Passport.DateOfExpiry
                    }
                });
            }

            return clientDtos;
        }
    }
}
