using System;

namespace Security_department
{
    public class Object : IObject
    {
        public int Id { get; private set; }
        public string Address { get; private set; }
        public int Floor { get; private set; }
        public string EntranceCode { get; private set; } // Кодовый замок на подъезде
        public bool HasEntranceCode { get; private set; } // Есть/нет кодовый замок
        public string HouseType { get; private set; } // Тип дома (кирпичный, панельный)
        public int TotalFloors { get; private set; } // Количество этажей
        public string DoorType { get; private set; } // Тип входной двери (метал, дерево)
        public string BalconyType { get; private set; } // Тип балкона (отдельный, совмещенный, отсутствует)
        public string ApartmentPlan { get; private set; } // План квартиры

        public Object(int id, string address, int floor, string entranceCode, bool hasEntranceCode,
              string houseType, int totalFloors, string doorType, string balconyType,
              string apartmentPlan)
        {
            Id = id;
            Address = address;
            Floor = floor;
            EntranceCode = entranceCode;
            HasEntranceCode = hasEntranceCode;
            HouseType = houseType;
            TotalFloors = totalFloors;
            DoorType = doorType;
            BalconyType = balconyType;
            ApartmentPlan = apartmentPlan;
        }

        // Метод для обновления данных объекта
        public void Update(string address, int floor, string entranceCode, bool hasEntranceCode,
                           string houseType, int totalFloors, string doorType, string balconyType,
                           string apartmentPlan)
        {
            Address = address;
            Floor = floor;
            EntranceCode = entranceCode;
            HasEntranceCode = hasEntranceCode;
            HouseType = houseType;
            TotalFloors = totalFloors;
            DoorType = doorType;
            BalconyType = balconyType;
            ApartmentPlan = apartmentPlan;
        }
    }
}