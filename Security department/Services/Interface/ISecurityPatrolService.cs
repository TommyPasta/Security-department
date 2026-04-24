using System;
using System.Collections.Generic;

namespace Security_department.Services.Interface
{
    public interface ISecurityPatrolService
    {
        void AddPatrol(SecurityPatrol patrol);
        void AddStolenItem(string itemName, decimal estimatedValue);
        void AddArrestDetails(string documentNumber, string issuingAuthority, DateTime dateOfIssue);
        List<SecurityPatrol> GetAllPatrols();
    }
}