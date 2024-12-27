using Security_department.DTOs;
using Security_department.Repositories.Interfaces;
using Security_department.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Services.Classes
{
    public class ContractService : IContractService
    {
        private readonly IContractRepository _contractRepository;

        public ContractService(IContractRepository contractRepository)
        {
            _contractRepository = contractRepository;
        }

        public void AddContract(ContractDTO contractDto)
        {
            var contract = new Contract(
                contractDto.Id,
                contractDto.ClientId,
                new Object(contractDto.Object.Id, contractDto.Object.Address, contractDto.Object.Floor),
                contractDto.StartDate,
                contractDto.EndDate,
                contractDto.Penalty,
                contractDto.InterestRate,
                contractDto.AdditionalConditions,
                contractDto.PaymentAmount
            );
            _contractRepository.Add(contract);
        }

        public void RemoveContract(int id)
        {
            _contractRepository.Remove(id);
        }

        public ContractDTO GetContractById(int id)
        {
            var contract = _contractRepository.GetById(id);
            if (contract == null) return null;

            return new ContractDTO
            {
                Id = contract.Id,
                ClientId = contract.ClientId,
                Object = new ObjectDTO
                {
                    Id = contract.Object.Id,
                    Address = contract.Object.Address,
                    Floor = contract.Object.Floor
                },
                StartDate = contract.StartDate,
                EndDate = contract.EndDate,
                Penalty = contract.Penalty,
                InterestRate = contract.InterestRate,
                AdditionalConditions = contract.AdditionalConditions,
                PaymentAmount = contract.PaymentAmount
            };
        }

        public List<ContractDTO> GetAllContracts()
        {
            var contracts = _contractRepository.GetAll();
            var contractDtos = new List<ContractDTO>();

            foreach (var contract in contracts)
            {
                contractDtos.Add(new ContractDTO
                {
                    Id = contract.Id,
                    ClientId = contract.ClientId,
                    Object = new ObjectDTO
                    {
                        Id = contract.Object.Id,
                        Address = contract.Object.Address,
                        Floor = contract.Object.Floor
                    },
                    StartDate = contract.StartDate,
                    EndDate = contract.EndDate,
                    Penalty = contract.Penalty,
                    InterestRate = contract.InterestRate,
                    AdditionalConditions = contract.AdditionalConditions,
                    PaymentAmount = contract.PaymentAmount
                });
            }

            return contractDtos;
        }
    }
}
