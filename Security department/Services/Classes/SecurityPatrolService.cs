using Security_department.Repositories.Interfaces;
using Security_department.Services.Interface;
using System;
using System.Collections.Generic;

namespace Security_department.Services.Classes
{
    public class SecurityPatrolService : ISecurityPatrolService
    {
        private readonly ISecurityPatrolRepository _securityPatrolRepository;
        private SecurityPatrol _currentPatrol;

        public SecurityPatrolService(ISecurityPatrolRepository securityPatrolRepository)
        {
            _securityPatrolRepository = securityPatrolRepository;
        }

        public void AddPatrol(SecurityPatrol patrol)
        {
            _currentPatrol = patrol;
            _securityPatrolRepository.AddPatrol(patrol);
        }

        public void AddStolenItem(string itemName, decimal estimatedValue)
        {
            if (_currentPatrol != null)
            {
                _currentPatrol.AddStolenItem(itemName, estimatedValue);
            }
        }

        public void AddArrestDetails(string documentNumber, string issuingAuthority, DateTime dateOfIssue)
        {
            if (_currentPatrol != null)
            {
                _currentPatrol.AddArrestDetails(documentNumber, issuingAuthority, dateOfIssue);
            }
        }

        public List<SecurityPatrol> GetAllPatrols()
        {
            return _securityPatrolRepository.GetAllPatrols();
        }
    }
}