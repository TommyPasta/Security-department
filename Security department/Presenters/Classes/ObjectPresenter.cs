using Security_department.DTOs;
using Security_department.Presenters.Interface;
using Security_department.Services.Interface;
using Security_department.Views;
using System.Collections.Generic;

namespace Security_department.Presenters
{
    public class ObjectPresenter : IObjectPresenter
    {
        private readonly IObjectService _objectService;

        public ObjectPresenter(IObjectService objectService)
        {
            _objectService = objectService;
        }

        public List<ObjectDTO> LoadObjects() // Метод теперь возвращает список объектов
        {
            return _objectService.GetAllObjects(); // Получаем все объекты из сервиса
        }

        public void AddObject(ObjectDTO objectDto)
        {
            _objectService.AddObject(objectDto);
        }

        public void RemoveObject(int id)
        {
            _objectService.RemoveObject(id);
        }

        public void UpdateObject(ObjectDTO objectDto)
        {
            _objectService.UpdateObject(objectDto);
        }

    }
}