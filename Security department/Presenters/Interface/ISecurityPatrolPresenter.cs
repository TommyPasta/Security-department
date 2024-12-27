using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Presenters.Interface
{
    public interface ISecurityPatrolPresenter
    {
        void ExecutePatrol(); // Метод для выполнения патрулирования
        void AddStolenItem(); // Метод для добавления украденной вещи
        void AddArrestDetails(); // Метод для добавления сведений о задержании
    }
}
