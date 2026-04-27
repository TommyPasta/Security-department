using Security_department.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Presenters.Interface
{
    public interface IContractPresenter
    {
        void LoadContracts();
        void AddContract(ContractDTO contractDto);
        void RemoveContract(int id);
        void UpdateContract(ContractDTO contractDto);
        List<ContractDTO> GetAllContracts();  // Добавляем этот метод
    }
}