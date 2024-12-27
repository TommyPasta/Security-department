using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Repositories.Interfaces
{
    public interface IPassportRepository
    {
        void Add(Passport passport);
        void Remove(string passportNumber);
        Passport GetByNumber(string passportNumber);
        List<Passport> GetAll();
    }
}
