using Security_department.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Views
{
    public interface IContractView
    {
        int Id { get; }
        int ClientId { get; }
        int ObjectId { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        int Penalty { get; }
        float InterestRate { get; set; } // Добавлен сеттер
        string AdditionalConditions { get; }
        float PaymentAmount { get; }

        void LoadContracts(List<ContractDTO> contracts);
        void ClearFields();
        void ShowMessage(string message);
    }
}
