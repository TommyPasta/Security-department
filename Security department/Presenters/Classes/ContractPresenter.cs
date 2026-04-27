using Security_department.DTOs;
using Security_department.Mappers;
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
        }

        public void LoadContracts()
        {
            var contracts = _contractService.GetAllContracts();
            _contractView.LoadContracts(contracts);
        }

        public void AddContract(ContractDTO contractDto)
        {
            _contractService.AddContract(contractDto);
            LoadContracts();
        }

        public void RemoveContract(int id)
        {
            _contractService.RemoveContract(id);
            LoadContracts();
        }

        public void UpdateContract(ContractDTO contractDto)
        {
            // Получаем существующий контракт
            var existingContract = _contractService.GetContractById(contractDto.Id);
            if (existingContract == null)
                throw new ArgumentException("Контракт не найден.");

            // Удаляем старый и добавляем новый (или можно реализовать Update в сервисе)
            _contractService.RemoveContract(contractDto.Id);
            _contractService.AddContract(contractDto);
            LoadContracts();
        }

        public List<ContractDTO> GetAllContracts()
        {
            return _contractService.GetAllContracts();
        }
    }
}