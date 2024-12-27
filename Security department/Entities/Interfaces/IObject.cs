using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department
{
    public interface IObject
    {
        int Id { get; }
        string Address { get; }
        int Floor { get; }
    }
}
