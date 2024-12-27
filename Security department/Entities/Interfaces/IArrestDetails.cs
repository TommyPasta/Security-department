using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Entities.Interfaces
{
    public interface IArrestDetails
    {
        string DocumentNumber { get; set; } // Номер документа
        string IssuingAuthority { get; set; } // Орган, выдавший документ
        DateTime DateOfIssue { get; set; } // Дата выдачи документа
    }
}
