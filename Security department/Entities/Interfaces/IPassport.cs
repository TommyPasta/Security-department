using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department
{
    public interface IPassport
    {
        string PassportNumber { get; }
        string IssuingAuthority { get; }
        DateTime DateOfIssue { get; }
        DateTime DateOfExpiry { get; }
    }
}
