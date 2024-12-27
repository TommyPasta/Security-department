using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.DTOs
{
    public class ContractDTO
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public ObjectDTO Object { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Penalty { get; set; }
        public float InterestRate { get; set; }
        public string AdditionalConditions { get; set; }
        public float PaymentAmount { get; set; }
    }
}
