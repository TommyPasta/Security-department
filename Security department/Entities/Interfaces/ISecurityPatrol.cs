using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Entities.Interfaces
{
    public interface ISecurityPatrol
    {
        void ExecutePatrol(); // Метод для выполнения патрулирования
        void AddStolenItem(string itemName, decimal estimatedValue); // Метод для добавления украденной вещи
        void AddArrestDetails(string documentNumber, string issuingAuthority, DateTime dateOfIssue); // Метод для добавления сведений о задержании
    }
}
