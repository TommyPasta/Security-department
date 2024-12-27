using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department
{
    public class Passport : IPassport
    {
        public string PassportNumber { get; private set; }
        public string IssuingAuthority { get; private set; }
        public DateTime DateOfIssue { get; private set; }
        public DateTime DateOfExpiry { get; private set; }

        public Passport(string passportNumber, string issuingAuthority, DateTime dateOfIssue, DateTime dateOfExpiry)
        {
            if (string.IsNullOrWhiteSpace(passportNumber))
                throw new ArgumentException("Номер паспорта не может быть пустым.");
            if (dateOfExpiry <= dateOfIssue)
                throw new ArgumentException("Дата окончания действия паспорта должна быть позже даты выдачи.");

            PassportNumber = passportNumber;
            IssuingAuthority = issuingAuthority;
            DateOfIssue = dateOfIssue;
            DateOfExpiry = dateOfExpiry;
        }

        public bool IsValid()
        {
            return DateTime.Now < DateOfExpiry;
        }

    }
}
