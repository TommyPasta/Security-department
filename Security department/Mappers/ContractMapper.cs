using Security_department.DTOs;
using System;

namespace Security_department.Mappers
{
    public static class ContractMapper
    {
        public static ContractDTO ToDto(Contract contract)
        {
            if (contract == null) return null;

            return new ContractDTO
            {
                Id = contract.Id,
                ClientId = contract.ClientId,
                Object = ObjectMapper.ToDto((Object)contract.Object),
                StartDate = contract.StartDate,
                EndDate = contract.EndDate,
                Penalty = contract.Penalty,
                InterestRate = contract.InterestRate,
                AdditionalConditions = contract.AdditionalConditions,
                PaymentAmount = contract.PaymentAmount
            };
        }

        public static Contract ToEntity(ContractDTO contractDto)
        {
            if (contractDto == null) return null;

            return new Contract(
                contractDto.Id,
                contractDto.ClientId,
                ObjectMapper.ToEntity(contractDto.Object),
                contractDto.StartDate,
                contractDto.EndDate,
                contractDto.Penalty,
                contractDto.InterestRate,
                contractDto.AdditionalConditions,
                contractDto.PaymentAmount
            );
        }
    }
}