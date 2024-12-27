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
    public class ObjectService : IObjectService
    {
        private readonly IObjectRepository _objectRepository;

        public ObjectService(IObjectRepository objectRepository)
        {
            _objectRepository = objectRepository;
        }

        public void AddObject(ObjectDTO objectDto)
        {
            var obj = new Object(
                objectDto.Id,
                objectDto.Address,
                objectDto.Floor,
                objectDto.EntranceCode,
                objectDto.HasEntranceCode,
                objectDto.HouseType,
                objectDto.TotalFloors,
                objectDto.DoorType,
                objectDto.BalconyType,
                objectDto.ApartmentPlan
            );

            _objectRepository.Add(obj); // Добавление объекта в репозиторий
        }

        public void RemoveObject(int id)
        {
            _objectRepository.Remove(id); // Удаление объекта по ID
        }

        public ObjectDTO GetObjectById(int id)
        {
            var obj = _objectRepository.GetById(id);
            return ObjectMapper.ToDto(obj); // Преобразование сущности в DTO
        }

        public List<ObjectDTO> GetAllObjects()
        {
            var objects = _objectRepository.GetAll();
            var objectDtos = new List<ObjectDTO>();

            foreach (var obj in objects)
            {
                objectDtos.Add(ObjectMapper.ToDto(obj)); // Преобразование сущности в DTO
            }

            return objectDtos;
        }

        public void UpdateObject(ObjectDTO objectDto) // Реализация метода
        {
            var obj = ObjectMapper.ToEntity(objectDto); // Преобразование DTO в сущность
            _objectRepository.Update(obj); // Обновление объекта в репозитории
        }
    }
}