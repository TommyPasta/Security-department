using Security_department.DTOs;
using System;
using System.Collections.Generic;

namespace Security_department.Views
{
    public interface ISecurityPatrolView
    {
        Contract Contract { get; } // Связанный контракт
        string CrewNumber { get; set; }
        string CommanderName { get; set; }
        string CallReason { get; set; }
        DateTime DepartureDateTime { get; set; }
        string StolenItemName { get; }
        decimal StolenItemValue { get; }
        string DocumentNumber { get; }
        string IssuingAuthority { get; }
        DateTime DateOfIssue { get; }

        void ShowMessage(string message);
        void ClearFields();
        void LoadPatrols(List<SecurityPatrolDTO> patrols);
    }
}