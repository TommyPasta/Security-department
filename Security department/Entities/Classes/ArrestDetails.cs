using Security_department.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Entities.Classes
{
    public class ArrestDetails : IArrestDetails
    {
        public string DocumentNumber { get; set; } // Номер документа
        public string IssuingAuthority { get; set; } // Орган, выдавший документ
        public DateTime DateOfIssue { get; set; } // Дата выдачи документа

        public ArrestDetails(string documentNumber, string issuingAuthority, DateTime dateOfIssue)
        {
            DocumentNumber = documentNumber;
            IssuingAuthority = issuingAuthority;
            DateOfIssue = dateOfIssue;
        }
    }
}
