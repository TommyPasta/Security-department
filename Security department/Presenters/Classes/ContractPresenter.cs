using Security_department.DTOs;
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
    public class ContractPresenter : IContractPresenter
    {
        private readonly IContractService _contractService;
        private readonly IContractView _contractView;

        public ContractPresenter(IContractService contractService, IContractView contractView)
        {
            _contractService = contractService;
            _contractView = contractView;

            // Подписка на события формы, если они есть
        }

        public void LoadContracts()
        {
            var contracts = _contractService.GetAllContracts();
            // Обновление формы с полученными данными
        }

        public void AddContract(ContractDTO contractDto)
        {
            _contractService.AddContract(contractDto);
            LoadContracts(); // Обновление списка договоров после добавления
        }

        public void RemoveContract(int id)
        {
            _contractService.RemoveContract(id);
            LoadContracts(); // Обновление списка договоров после удаления
        }

        public void UpdateContract(ContractDTO contractDto)
        {
            // Логика обновления договора
            LoadContracts(); // Обновление списка договоров после обновления
        }
    }
}
