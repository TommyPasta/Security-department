using System;
using System.ComponentModel;

namespace Security_department
{
    public class Contract : IContract
    {
        public int Id { get; private set; }
        public int ClientId { get; private set; }
        public IObject Object { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public int Penalty { get; private set; }
        public float InterestRate { get; private set; }
        public string AdditionalConditions { get; private set; }
        public float PaymentAmount { get; private set; }

        public Contract(int id, int clientId, IObject obj, DateTime startDate, DateTime endDate, int penalty, float interestRate, string additionalConditions, float paymentAmount)
        {
            Id = id;
            ClientId = clientId;
            Object = obj;
            StartDate = startDate;
            EndDate = endDate;
            Penalty = penalty;
            InterestRate = interestRate;
            AdditionalConditions = additionalConditions;
            PaymentAmount = paymentAmount;
        }

        public void ChangeConditions(string newConditions)
        {
            AdditionalConditions = newConditions;
        }

        public void ExtendContract(DateTime newEndDate)
        {
            if (newEndDate <= EndDate)
                throw new ArgumentException("Новая дата окончания должна быть позже текущей даты окончания.");
            EndDate = newEndDate;
        }

        public void TerminateContract()
        {
            EndDate = DateTime.Now;
        }
    }
}