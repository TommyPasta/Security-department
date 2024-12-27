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
    public class ObjectService : IObjectService
    {
        private readonly IObjectRepository _objectRepository;

        public ObjectService(IObjectRepository objectRepository)
        {
            _objectRepository = objectRepository;
        }

        public void AddObject(ObjectDTO objectDto)
        {
            var obj = new Object(objectDto.Id, objectDto.Address, objectDto.Floor);
            _objectRepository.Add(obj);
        }

        public void RemoveObject(int id)
        {
            _objectRepository.Remove(id);
        }

        public ObjectDTO GetObjectById(int id)
        {
            var obj = _objectRepository.GetById(id);
            if (obj == null) return null;

            return new ObjectDTO
            {
                Id = obj.Id,
                Address = obj.Address,
                Floor = obj.Floor
            };
        }

        public List<ObjectDTO> GetAllObjects()
        {
            var objects = _objectRepository.GetAll();
            var objectDtos = new List<ObjectDTO>();

            foreach (var obj in objects)
            {
                objectDtos.Add(new ObjectDTO
                {
                    Id = obj.Id,
                    Address = obj.Address,
                    Floor = obj.Floor
                });
            }

            return objectDtos;
        }
    }
}
