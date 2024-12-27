using Security_department.DTOs;
using Security_department.Repositories.Interfaces;
using Security_department.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Services.Classes
{
    public class PassportService : IPassportService
    {
        private readonly IPassportRepository _passportRepository;

        public PassportService(IPassportRepository passportRepository)
        {
            _passportRepository = passportRepository;
        }

        public void AddPassport(PassportDTO passportDto)
        {
            var passport = new Passport(
                passportDto.PassportNumber,
                passportDto.IssuingAuthority,
                passportDto.DateOfIssue,
                passportDto.DateOfExpiry
            );
            _passportRepository.Add(passport);
        }

        public void RemovePassport(string passportNumber)
        {
            _passportRepository.Remove(passportNumber);
        }

        public PassportDTO GetPassportByNumber(string passportNumber)
        {
            var passport = _passportRepository.GetByNumber(passportNumber);
            if (passport == null) return null;

            return new PassportDTO
            {
                PassportNumber = passport.PassportNumber,
                IssuingAuthority = passport.IssuingAuthority,
                DateOfIssue = passport.DateOfIssue,
                DateOfExpiry = passport.DateOfExpiry
            };
        }

        public List<PassportDTO> GetAllPassports()
        {
            var passports = _passportRepository.GetAll();
            var passportDtos = new List<PassportDTO>();

            foreach (var passport in passports)
            {
                passportDtos.Add(new PassportDTO
                {
                    PassportNumber = passport.PassportNumber,
                    IssuingAuthority = passport.IssuingAuthority,
                    DateOfIssue = passport.DateOfIssue,
                    DateOfExpiry = passport.DateOfExpiry
                });
            }

            return passportDtos;
        }
    }
}
