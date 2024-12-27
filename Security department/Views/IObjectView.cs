using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security_department.Views
{
    public interface IObjectView
    {
        int Id { get; set; }
        string Address { get; set; }
        int Floor { get; set; }

        void ShowMessage(string message);
        void ClearFields();
    }
}
