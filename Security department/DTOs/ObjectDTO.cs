using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.DTOs
{
    public class ObjectDTO
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int Floor { get; set; }
        public string EntranceCode { get; set; } // Кодовый замок на подъезде
        public bool HasEntranceCode { get; set; } // Есть/нет кодовый замок
        public string HouseType { get; set; } // Тип дома (кирпичный, панельный)
        public int TotalFloors { get; set; } // Количество этажей
        public string DoorType { get; set; } // Тип входной двери (метал, дерево)
        public string BalconyType { get; set; } // Тип балкона (отдельный, совмещенный, отсутствует)
        public string ApartmentPlan { get; set; } // План квартиры
    }
}
