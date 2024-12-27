using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Repositories.Interfaces
{
    public interface IObjectRepository
    {
        void Add(Object obj);
        void Remove(int id);
        Object GetById(int id);
        List<Object> GetAll();
    }
}
