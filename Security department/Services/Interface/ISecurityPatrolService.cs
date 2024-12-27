using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Services.Interface
{
    public interface ISecurityPatrolService
    {
        void AddPatrol(SecurityPatrol patrol);
        void AddStolenItem(string itemName, decimal estimatedValue);
        void AddArrestDetails(string documentNumber, string issuingAuthority, DateTime dateOfIssue);
    }
}
