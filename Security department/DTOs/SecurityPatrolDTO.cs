using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.DTOs
{
    public class SecurityPatrolDTO
    {
        public int PatrolId { get; set; }
        public int ContractId { get; set; }
        public DateTime DepartureDateTime { get; set; }
        public string CrewNumber { get; set; }
        public string CommanderName { get; set; }
        public string CallReason { get; set; }
        public List<StolenItemDTO> StolenItems { get; set; }
        public ArrestDetailsDTO ArrestDetails { get; set; }
    }
}
