using Security_department.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Services.Interface
{
    public interface IContractService
    {
        void AddContract(ContractDTO contractDto);
        void RemoveContract(int id);
        ContractDTO GetContractById(int id);
        List<ContractDTO> GetAllContracts();
    }
}
