using Security_department.DTOs;
using Security_department.Mappers;
using Security_department.Presenters.Interface;
using Security_department.Services.Interface;
using Security_department.Views;
using System;
using System.Collections.Generic;

namespace Security_department.Presenters.Classes
{
    public class SecurityPatrolPresenter : ISecurityPatrolPresenter
    {
        private readonly ISecurityPatrolService _securityPatrolService;
        private readonly IContractService _contractService;
        private readonly ISecurityPatrolView _securityPatrolView;

        public SecurityPatrolPresenter(
            ISecurityPatrolService securityPatrolService,
            IContractService contractService,
            ISecurityPatrolView securityPatrolView)
        {
            _securityPatrolService = securityPatrolService;
            _contractService = contractService;
            _securityPatrolView = securityPatrolView;
        }

        public void ExecutePatrol(SecurityPatrolDTO patrolDto)
        {
            var contractDto = _contractService.GetContractById(patrolDto.ContractId);
            if (contractDto == null)
                throw new ArgumentException("Контракт не найден");

            var contract = ContractMapper.ToEntity(contractDto);
            var patrol = SecurityPatrolMapper.ToEntity(patrolDto, contract);

            _securityPatrolService.AddPatrol(patrol);
            patrol.ExecutePatrol();
        }

        public void AddStolenItem(StolenItemDTO stolenItemDto)
        {
            _securityPatrolService.AddStolenItem(stolenItemDto.ItemName, stolenItemDto.EstimatedValue);
        }

        public void AddArrestDetails(ArrestDetailsDTO arrestDetailsDto)
        {
            _securityPatrolService.AddArrestDetails(
                arrestDetailsDto.DocumentNumber,
                arrestDetailsDto.IssuingAuthority,
                arrestDetailsDto.DateOfIssue
            );
        }

        public List<SecurityPatrolDTO> GetAllPatrols()
        {
            var patrols = _securityPatrolService.GetAllPatrols();
            var patrolDtos = new List<SecurityPatrolDTO>();

            foreach (var patrol in patrols)
            {
                patrolDtos.Add(SecurityPatrolMapper.ToDto(patrol));
            }

            return patrolDtos;
        }
    }
}