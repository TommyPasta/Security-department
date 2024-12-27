using Security_department.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Mappers
{
    public static class ObjectMapper
    {
        public static ObjectDTO ToDto(IObject obj)
        {
            if (obj == null) return null;

            return new ObjectDTO
            {
                Id = obj.Id,
                Address = obj.Address,
                Floor = obj.Floor
            };
        }

        public static Object ToEntity(ObjectDTO objectDto)
        {
            if (objectDto == null) return null;

            return new Object(objectDto.Id, objectDto.Address, objectDto.Floor);
        }
    }
}
