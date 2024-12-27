using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Repositories.Interfaces
{
    public interface ISecurityPatrolRepository
    {
        void AddPatrol(SecurityPatrol patrol);
        List<SecurityPatrol> GetAllPatrols();
        SecurityPatrol GetPatrolById(int id);
    }
}
