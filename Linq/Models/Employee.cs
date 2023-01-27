using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Models
{
    public class Employee : Person
    {
        public string Profession { get; set; }
        public double Salary { get; set; }
        public int CompanyId { get; set; }
    }
}
