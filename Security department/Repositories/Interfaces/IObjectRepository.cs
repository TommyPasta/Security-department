using System.Collections.Generic;

namespace Security_department.Repositories.Interfaces
{
    public interface IObjectRepository
    {
        void Add(Object obj);
        void Remove(int id);
        Object GetById(int id);
        List<Object> GetAll();
        void Update(Object obj);
    }
}