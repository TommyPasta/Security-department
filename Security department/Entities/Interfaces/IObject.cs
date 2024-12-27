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
        string EntranceCode { get; }
        bool HasEntranceCode { get; }
        string HouseType { get; }
        int TotalFloors { get; }
        string DoorType { get; }
        string BalconyType { get; }
        string ApartmentPlan { get; }
    }
}
