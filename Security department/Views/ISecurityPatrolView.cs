using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Views
{
    public interface ISecurityPatrolView
    {
        Contract Contract { get; } // Связанный контракт
        string CrewNumber { get; set; } // Номер экипажа
        string CommanderName { get; set; } // Имя командира
        string CallReason { get; set; } // Причина вызова
        string StolenItemName { get; } // Название украденной вещи
        decimal StolenItemValue { get; } // Оценочная стоимость украденной вещи
        string DocumentNumber { get; } // Номер документа о задержании
        string IssuingAuthority { get; } // Орган, выдавший документ
        DateTime DateOfIssue { get; } // Дата выдачи документа

        void ShowMessage(string message); // Метод для отображения сообщений
        void ClearFields(); // Метод для очистки полей ввода
    }
}
