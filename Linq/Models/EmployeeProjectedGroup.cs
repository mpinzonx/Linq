using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Models
{
    public class EmployeeProjectedGroup
    {
        public string CompanyName { get; set; }
        public IEnumerable<Employee> Employees { get; set; }
    }
}
