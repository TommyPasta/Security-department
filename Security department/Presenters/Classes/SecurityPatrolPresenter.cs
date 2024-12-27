using Security_department.Presenters.Interface;
using Security_department.Services.Interface;
using Security_department.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Presenters.Classes
{
    public class SecurityPatrolPresenter : ISecurityPatrolPresenter
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
            // Создаем новый объект SecurityPatrol на основе контракта из представления
            var patrol = new SecurityPatrol(_securityPatrolView.Contract)
            {
                CrewNumber = _securityPatrolView.CrewNumber,
                CommanderName = _securityPatrolView.CommanderName,
                CallReason = _securityPatrolView.CallReason
            };

            // Добавляем патруль в сервис
            _securityPatrolService.AddPatrol(patrol);
            patrol.ExecutePatrol(); // Выполняем патрулирование
        }

        public void AddStolenItem()
        {
            // Получаем данные о украденной вещи из представления
            var itemName = _securityPatrolView.StolenItemName;
            var estimatedValue = _securityPatrolView.StolenItemValue;

            // Добавляем украденную вещь в сервис
            _securityPatrolService.AddStolenItem(itemName, estimatedValue);
        }

        public void AddArrestDetails()
        {
            // Получаем данные о задержании из представления
            var documentNumber = _securityPatrolView.DocumentNumber;
            var issuingAuthority = _securityPatrolView.IssuingAuthority;
            var dateOfIssue = _securityPatrolView.DateOfIssue;

            // Добавляем сведения о задержании в сервис
            _securityPatrolService.AddArrestDetails(documentNumber, issuingAuthority, dateOfIssue);
        }
    }
}
