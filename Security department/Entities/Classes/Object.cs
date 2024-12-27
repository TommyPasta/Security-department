using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department
{
    public class Object : IObject
    {
        public int Id { get; private set; }
        public string Address { get; private set; }
        public int Floor { get; private set; }
        public Object(int id, string address, int floor)
        {
            if (id <= 0)
                throw new ArgumentException("ID должен быть положительным целым числом.");
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("Адрес не может быть пустым.");
            if (floor < 0)
                throw new ArgumentException("Этаж не может быть отрицательным.");

            Id = id;
            Address = address;
            Floor = floor;
        }
    }
}
