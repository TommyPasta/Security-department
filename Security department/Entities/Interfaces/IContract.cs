using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department
{
    public interface IContract
    {
        int Id { get; }
        int ClientId { get; }
        IObject Object { get; }
        DateTime StartDate { get; }
        DateTime EndDate { get; }
        int Penalty { get; }
        float InterestRate { get; }
        string AdditionalConditions { get; }
        float PaymentAmount { get; }

        void ChangeConditions(string newConditions);
        void ExtendContract(DateTime newEndDate);
        void TerminateContract();
    }
}
