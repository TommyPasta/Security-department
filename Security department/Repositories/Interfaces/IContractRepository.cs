using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Repositories.Interfaces
{
    public interface IContractRepository
    {
        void Add(Contract contract);
        void Remove(int id);
        Contract GetById(int id);
        List<Contract> GetAll();
    }
}
