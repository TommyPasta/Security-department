using Security_department.DTOs;
using Security_department.Entities.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Mappers
{
    public static class SecurityPatrolMapper
    {
        public static SecurityPatrolDTO ToDto(SecurityPatrol patrol)
        {
            return new SecurityPatrolDTO
            {
                PatrolId = patrol.PatrolId,
                ContractId = patrol.Contract.Id,
                DepartureDateTime = patrol.DepartureDateTime,
                CrewNumber = patrol.CrewNumber,
                CommanderName = patrol.CommanderName,
                CallReason = patrol.CallReason,
                StolenItems = patrol.StolenItems.ConvertAll(item => new StolenItemDTO
                {
                    ItemName = item.ItemName,
                    EstimatedValue = item.EstimatedValue
                }),
                ArrestDetails = patrol.ArrestDetails != null ? new ArrestDetailsDTO
                {
                    DocumentNumber = patrol.ArrestDetails.DocumentNumber,
                    IssuingAuthority = patrol.ArrestDetails.IssuingAuthority,
                    DateOfIssue = patrol.ArrestDetails.DateOfIssue
                } : null
            };
        }

        public static SecurityPatrol ToEntity(SecurityPatrolDTO dto, Contract contract)
        {
            var patrol = new SecurityPatrol(contract)
            {
                PatrolId = dto.PatrolId,
                DepartureDateTime = dto.DepartureDateTime,
                CrewNumber = dto.CrewNumber,
                CommanderName = dto.CommanderName,
                CallReason = dto.CallReason,
                StolenItems = new List<StolenItem>() // Инициализируем список
            };

            // Заполняем список украденных вещей
            foreach (var itemDto in dto.StolenItems)
            {
                var stolenItem = new StolenItem(itemDto.ItemName, itemDto.EstimatedValue);
                patrol.StolenItems.Add(stolenItem);
            }

            // Проверяем, есть ли сведения о задержании
            if (dto.ArrestDetails != null)
            {
                patrol.AddArrestDetails(dto.ArrestDetails.DocumentNumber, dto.ArrestDetails.IssuingAuthority, dto.ArrestDetails.DateOfIssue);
            }

            return patrol;
        }
    }
}
