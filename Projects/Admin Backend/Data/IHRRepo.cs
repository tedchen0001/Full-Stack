using System.Collections.Generic;
using Admin_Backend.Models;

namespace Admin_Backend.Data
{
    public interface IHRRepo
    {
        IEnumerable<Employee> GetAllEmpInfo();
    }
}