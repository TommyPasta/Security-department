using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Views
{
    public interface IPassportView
    {
        string PassportNumber { get; set; }
        string IssuingAuthority { get; set; }
        DateTime DateOfIssue { get; set; }
        DateTime DateOfExpiry { get; set; }

        void ShowMessage(string message);
        void ClearFields();
    }
}
