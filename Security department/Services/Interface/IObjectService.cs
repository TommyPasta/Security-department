using Security_department.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Services.Interface
{
    public interface IObjectService
    {
        void AddObject(ObjectDTO objectDto);
        void RemoveObject(int id);
        ObjectDTO GetObjectById(int id);
        List<ObjectDTO> GetAllObjects();
    }
}
