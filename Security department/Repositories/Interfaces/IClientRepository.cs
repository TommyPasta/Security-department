using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Repositories.Interfaces
{
    public interface IClientRepository
    {
        void Add(Client client);
        void Remove(int id);
        Client GetById(int id);
        List<Client> GetAll();
        void Update(Client client);
    }
}
