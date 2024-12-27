using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Security_department.Services.Interface;

namespace Security_department.Repositories.Classes
{
    using Security_department.Services.Interface;
    using Security_department.Views;

    public class SecurityPatrolPresenter
    {
        private readonly ISecurityPatrolService _securityPatrolService;
        private readonly ISecurityPatrolView _securityPatrolView;

        public SecurityPatrolPresenter(ISecurityPatrolService securityPatrolService, ISecurityPatrolView securityPatrolView)
        {
            _securityPatrolService = securityPatrolService;
            _securityPatrolView = securityPatrolView;
        }

        public void ExecutePatrol()
        {
            var patrol = new SecurityPatrol(_securityPatrolView.Contract);
            patrol.CrewNumber = _securityPatrolView.CrewNumber;
            patrol.CommanderName = _securityPatrolView.CommanderName;
            patrol.CallReason = _securityPatrolView.CallReason;

            _securityPatrolService.AddPatrol(patrol);
            patrol.ExecutePatrol();
        }

        public void AddStolenItem()
        {
            var itemName = _securityPatrolView.StolenItemName;
            var estimatedValue = _securityPatrolView.StolenItemValue;
            _securityPatrolService.AddStolenItem(itemName, estimatedValue);
        }

        public void AddArrestDetails()
        {
            var documentNumber = _securityPatrolView.DocumentNumber;
            var issuingAuthority = _securityPatrolView.IssuingAuthority;
            var dateOfIssue = _securityPatrolView.DateOfIssue;

            _securityPatrolService.AddArrestDetails(documentNumber, issuingAuthority, dateOfIssue);
        }
    }
}
