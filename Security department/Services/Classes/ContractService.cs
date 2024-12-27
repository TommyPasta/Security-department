using Security_department.DTOs;
using Security_department.Mappers;
using Security_department.Repositories.Interfaces;
using Security_department.Services.Interface;
using System.Collections.Generic;

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
                ObjectMapper.ToEntity(contractDto.Object), // Преобразование DTO объекта в сущность
                contractDto.StartDate,
                contractDto.EndDate,
                contractDto.Penalty,
                contractDto.InterestRate,
                contractDto.AdditionalConditions,
                contractDto.PaymentAmount
            );

            _contractRepository.Add(contract); // Добавление контракта в репозиторий
        }

        public void RemoveContract(int id)
        {
            _contractRepository.Remove(id); // Удаление контракта по ID
        }

        public ContractDTO GetContractById(int id)
        {
            var contract = _contractRepository.GetById(id);
            if (contract == null) return null;

            return new ContractDTO
            {
                Id = contract.Id,
                ClientId = contract.ClientId,
                Object = ObjectMapper.ToDto((Object)contract.Object), // Преобразование сущности объекта в DTO
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
                    Object = ObjectMapper.ToDto((Object)contract.Object), // Преобразование сущности объекта в DTO
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