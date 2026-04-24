using Security_department.DTOs;
using System.Collections.Generic;

namespace Security_department.Presenters.Interface
{
    public interface ISecurityPatrolPresenter
    {
        void ExecutePatrol(SecurityPatrolDTO patrolDto);
        void AddStolenItem(StolenItemDTO stolenItemDto);
        void AddArrestDetails(ArrestDetailsDTO arrestDetailsDto);
        List<SecurityPatrolDTO> GetAllPatrols();
    }
}