using System.Collections.Generic;
using System.Linq;
using Admin_Backend.Models;
using DI.Data;

namespace Admin_Backend.Data
{
    public class SqlEmployeeRepo : IHRRepo
    {
        private readonly HRContext _context;

        public SqlEmployeeRepo(HRContext context)
        {
            _context = context;
        }
        public IEnumerable<Employee> GetAllEmpInfo()
        {
            return _context.Employee.ToList();
        }
    }
}