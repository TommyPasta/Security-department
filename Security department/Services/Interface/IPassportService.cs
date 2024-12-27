using Security_department.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Services.Interface
{
    public interface IPassportService
    {
        void AddPassport(PassportDTO passportDto);
        void RemovePassport(string passportNumber);
        PassportDTO GetPassportByNumber(string passportNumber);
        List<PassportDTO> GetAllPassports();
    }
}
