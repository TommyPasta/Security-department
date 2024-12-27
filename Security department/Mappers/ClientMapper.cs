using Security_department.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Mappers
{
    public static class ClientMapper
    {
        public static ClientDTO ToDto(Client client)
        {
            if (client == null) return null;

            return new ClientDTO
            {
                Id = client.Id,
                FirstName = client.FirstName,
                SecondName = client.SecondName,
                Surname = client.Surname,
                Address = client.Address,
                Phone = client.Phone,
                Passport = PassportMapper.ToDto(client.Passport)
            };
        }

        public static Client ToEntity(ClientDTO clientDto)
        {
            if (clientDto == null) return null;

            return new Client(
                clientDto.Id,
                clientDto.FirstName,
                clientDto.SecondName,
                clientDto.Surname,
                clientDto.Address,
                clientDto.Phone,
                PassportMapper.ToEntity(clientDto.Passport)
            );
        }
    }
}
