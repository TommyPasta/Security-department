using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.DTOs
{
    public class ArrestDetailsDTO
    {
        public string DocumentNumber { get; set; }
        public string IssuingAuthority { get; set; }
        public DateTime DateOfIssue { get; set; }
    }
}
