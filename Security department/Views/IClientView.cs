using Security_department.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Views
{
    public interface IClientView
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string SecondName { get; set; }
        string Surname { get; set; }
        string Address { get; set; }
        string Phone { get; set; }
        PassportDTO Passport { get; set; }

        void ShowMessage(string message);
        void ClearFields();
    }
}
