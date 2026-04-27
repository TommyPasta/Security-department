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
            if (patrol == null) return null;

            var dto = new SecurityPatrolDTO
            {
                PatrolId = patrol.PatrolId,
                ContractId = patrol.Contract?.Id ?? 0,
                DepartureDateTime = patrol.DepartureDateTime,
                CrewNumber = patrol.CrewNumber,
                CommanderName = patrol.CommanderName,
                CallReason = patrol.CallReason,

                // Безопасное преобразование списка украденных вещей
                StolenItems = new List<StolenItemDTO>()  // Всегда создаём пустой список
            };

            // Если есть украденные вещи — добавляем их
            if (patrol.StolenItems != null)
            {
                foreach (var item in patrol.StolenItems)
                {
                    if (item != null)
                    {
                        dto.StolenItems.Add(new StolenItemDTO
                        {
                            ItemName = item.ItemName ?? "",
                            EstimatedValue = item.EstimatedValue
                        });
                    }
                }
            }

            // Безопасное преобразование сведений о задержании
            if (patrol.ArrestDetails != null)
            {
                dto.ArrestDetails = new ArrestDetailsDTO
                {
                    DocumentNumber = patrol.ArrestDetails.DocumentNumber ?? "",
                    IssuingAuthority = patrol.ArrestDetails.IssuingAuthority ?? "",
                    DateOfIssue = patrol.ArrestDetails.DateOfIssue
                };
            }
            else
            {
                dto.ArrestDetails = null;
            }

            return dto;
        }

        public static SecurityPatrol ToEntity(SecurityPatrolDTO dto, Contract contract)
        {
            if (dto == null) return null;

            var patrol = new SecurityPatrol(contract)
            {
                PatrolId = dto.PatrolId,
                DepartureDateTime = dto.DepartureDateTime,
                CrewNumber = dto.CrewNumber ?? "",
                CommanderName = dto.CommanderName ?? "",
                CallReason = dto.CallReason ?? "",
                StolenItems = new List<StolenItem>()  // Всегда создаём пустой список
            };

            // Безопасно добавляем украденные вещи
            if (dto.StolenItems != null)
            {
                foreach (var itemDto in dto.StolenItems)
                {
                    if (itemDto != null)
                    {
                        var stolenItem = new StolenItem(
                            itemDto.ItemName ?? "",
                            itemDto.EstimatedValue
                        );
                        patrol.StolenItems.Add(stolenItem);
                    }
                }
            }

            // Безопасно добавляем сведения о задержании
            if (dto.ArrestDetails != null)
            {
                patrol.AddArrestDetails(
                    dto.ArrestDetails.DocumentNumber ?? "",
                    dto.ArrestDetails.IssuingAuthority ?? "",
                    dto.ArrestDetails.DateOfIssue
                );
            }

            return patrol;
        }
    }
}