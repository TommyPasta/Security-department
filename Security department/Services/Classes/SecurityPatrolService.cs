using Security_department.Repositories.Interfaces;
using Security_department.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Services.Classes
{
    public class SecurityPatrolService : ISecurityPatrolService
    {
        private readonly ISecurityPatrolRepository _securityPatrolRepository;

        public SecurityPatrolService(ISecurityPatrolRepository securityPatrolRepository)
        {
            _securityPatrolRepository = securityPatrolRepository;
        }

        public void AddPatrol(SecurityPatrol patrol)
        {
            _securityPatrolRepository.AddPatrol(patrol);
        }

        public void AddStolenItem(string itemName, decimal estimatedValue)
        {
            // Логика для добавления украденной вещи
        }

        public void AddArrestDetails(string documentNumber, string issuingAuthority, DateTime dateOfIssue)
        {
            // Логика для добавления сведений о задержании
        }
    }
}
