using Security_department.DTOs;
using System.Collections.Generic;

namespace Security_department.Presenters.Interface
{
    public interface IObjectPresenter
    {
        List<ObjectDTO> LoadObjects(); // Метод возвращает список объектов
        void AddObject(ObjectDTO objectDto);
        void RemoveObject(int id);
        void UpdateObject(ObjectDTO objectDto);
    }
}