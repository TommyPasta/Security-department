using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department
{
    public interface IClient
    {
        int Id { get; }
        string FirstName { get; }
        string SecondName { get; }
        string Surname { get; }
        string Address { get; }
        string Phone { get; }
        IPassport Passport { get; }
        void AddContract(IContract contract);
        void RemoveContract(IContract contract);
        List<IContract> GetContracts();
    }
}
