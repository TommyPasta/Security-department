using Security_department.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Entities.Classes
{
    public class StolenItem : IStolenItem
    {
        public string ItemName { get; set; } // Название вещи
        public decimal EstimatedValue { get; set; } // Оценочная стоимость

        public StolenItem(string itemName, decimal estimatedValue)
        {
            ItemName = itemName;
            EstimatedValue = estimatedValue;
        }
    }
}
