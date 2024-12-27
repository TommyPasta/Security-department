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
        int Id { get; set; }
        int ClientId { get; set; }
        ObjectDTO Object { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        int Penalty { get; set; }
        float InterestRate { get; set; }
        string AdditionalConditions { get; set; }
        float PaymentAmount { get; set; }

        void ShowMessage(string message);
        void ClearFields();
    }
}
