using Security_department.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Mappers
{
    public static class PassportMapper
    {
        public static PassportDTO ToDto(IPassport passport)
        {
            if (passport == null) return null;

            return new PassportDTO
            {
                PassportNumber = passport.PassportNumber,
                IssuingAuthority = passport.IssuingAuthority,
                DateOfIssue = passport.DateOfIssue,
                DateOfExpiry = passport.DateOfExpiry
            };
        }

        public static Passport ToEntity(PassportDTO passportDto)
        {
            if (passportDto == null) return null;

            return new Passport(
                passportDto.PassportNumber,
                passportDto.IssuingAuthority,
                passportDto.DateOfIssue,
                passportDto.DateOfExpiry
            );
        }
    }
}
