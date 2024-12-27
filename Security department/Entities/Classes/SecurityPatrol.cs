using Security_department.Entities.Classes;
using Security_department.Entities.Interfaces;
using System;
using System.Collections.Generic;

namespace Security_department
{
    public class SecurityPatrol : ISecurityPatrol
    {
        public int PatrolId { get; set; } // Идентификатор патруля
        public Contract Contract { get; set; } // Связанный контракт
        public DateTime DepartureDateTime { get; set; } // Дата и время выезда
        public string CrewNumber { get; set; } // Номер экипажа
        public string CommanderName { get; set; } // Имя командира
        public string CallReason { get; set; } // Причина вызова
        public List<StolenItem> StolenItems { get; set; } // Перечень украденных вещей
        public ArrestDetails ArrestDetails { get; set; } // Сведения о задержании

        public SecurityPatrol(Contract contract)
        {
            Contract = contract;
            DepartureDateTime = DateTime.Now; // Устанавливаем текущее время как время выезда
            StolenItems = new List<StolenItem>(); // Инициализация списка украденных вещей
        }

        // Метод для выполнения выезда на объект
        public void ExecutePatrol()
        {
            // Логика для выполнения патрулирования
            Console.WriteLine($"Выезд патруля на объект: {Contract.Object.Address}");
            Console.WriteLine($"Причина вызова: {CallReason}");
            Console.WriteLine($"Командир: {CommanderName}, Экипаж: {CrewNumber}");
            // Здесь можно добавить дополнительную логику, например, запись в журнал
        }

        public void AddStolenItem(string itemName, decimal estimatedValue)
        {
            // Создаем новый объект StolenItem и добавляем его в список
            var stolenItem = new StolenItem(itemName, estimatedValue);
            StolenItems.Add(stolenItem);
        }

        public void AddArrestDetails(string documentNumber, string issuingAuthority, DateTime dateOfIssue)
        {
            // Создаем новый объект ArrestDetails
            ArrestDetails = new ArrestDetails(documentNumber, issuingAuthority, dateOfIssue);
        }
    }
}