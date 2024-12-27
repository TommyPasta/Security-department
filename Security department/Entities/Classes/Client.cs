using Security_department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Security_department
{
    public class Client : IClient
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string SecondName { get; private set; }
        public string Surname { get; private set; }
        public string Address { get; private set; }
        public string Phone { get; private set; }
        public IPassport Passport { get; private set; }

        private List<IContract> contracts;

        public Client(int id, string firstName, string secondName, string surname, string address, string phone, IPassport passport)
        {
            if (id <= 0)
                throw new ArgumentException("ID должен быть положительным целым числом.");
            if (string.IsNullOrWhiteSpace(firstName))
                throw new ArgumentException("Имя не может быть пустым.");
            if (string.IsNullOrWhiteSpace(secondName))
                throw new ArgumentException("Фамилия не может быть пустой.");
            if (string.IsNullOrWhiteSpace(surname))
                throw new ArgumentException("Отчество не может быть пустым.");
            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("Адрес не может быть пустым.");
            if (string.IsNullOrWhiteSpace(phone))
                throw new ArgumentException("Телефон не может быть пустым.");
            if (passport == null)
                throw new ArgumentNullException(nameof(passport), "Паспорт не может быть null.");

            Id = id;
            FirstName = firstName;
            SecondName = secondName;
            Surname = surname;
            Address = address;
            Phone = phone;
            Passport = passport;
            contracts = new List<IContract>();
        }

        public void AddContract(IContract contract)
        {
            if (contract == null)
                throw new ArgumentNullException(nameof(contract), "Договор не может быть null.");
            contracts.Add(contract);
        }

        public void RemoveContract(IContract contract)
        {
            if (contract == null)
                throw new ArgumentNullException(nameof(contract), "Договор не может быть null.");
            contracts.Remove(contract);
        }

        public List<IContract> GetContracts()
        {
            return contracts;
        }

        public override string ToString()
        {
            return $"Клиент ID: {Id}, ФИО: {FirstName} {SecondName} {Surname}, Адрес: {Address}, Телефон: {Phone}, Паспорт: {Passport.PassportNumber}";
        }
    }
}
