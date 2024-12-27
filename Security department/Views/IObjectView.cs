using Security_department.DTOs;

namespace Security_department.Views
{
    public interface IObjectView
    {
        int Id { get; set; }
        string Address { get; set; }
        int Floor { get; set; }
        string EntranceCode { get; set; } // Кодовый замок на подъезде
        bool HasEntranceCode { get; set; } // Есть/нет кодовый замок
        string HouseType { get; set; } // Тип дома
        int TotalFloors { get; set; } // Количество этажей
        string DoorType { get; set; } // Тип входной двери
        string BalconyType { get; set; } // Тип балкона
        string ApartmentPlan { get; set; } // План квартиры

        void ShowMessage(string message);
        void ClearFields();
        void LoadObjects(); // Метод для загрузки объектов в представление
        void AddObjectToList(ObjectDTO objectDto); // Метод для добавления объекта в список
        void ClearObjectList(); // Метод для очистки списка объектов
    }
}