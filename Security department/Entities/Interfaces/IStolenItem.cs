using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Entities.Interfaces
{
    public interface IStolenItem
    {
        string ItemName { get; set; } // Название вещи
        decimal EstimatedValue { get; set; } // Оценочная стоимость
    }
}
