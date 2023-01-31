using Linq.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class MethodSyntax
    {

        private List<Company> companies;
        private List<Employee> employees;
        private List<Employee> otherEmployees;

        public MethodSyntax()
        {

            companies = new List<Company>();

            companies.AddRange(new[]
            {
                new Company(){Id = 1, Name = "Amazon" },
                new Company(){Id = 2, Name = "Facebook" },
                new Company(){Id = 3, Name = "Microsoft" },
                new Company(){Id = 4, Name = "IBM" },
                new Company(){Id = 5, Name = "Google" }
            });

            employees = new List<Employee>();

            employees.AddRange(new Employee[]
            {
                new Employee(){ Id = 1, FirstName = "ariana", LastName = "zimmerman", Age = 25, Profession = "back-end developer", Salary = 2500, CompanyId = 1 },
                new Employee(){ Id = 2, FirstName = "jordan", LastName = "allen", Age = 19, Profession = "front-end developer", Salary = 2500, CompanyId = 2 },
                new Employee(){ Id = 3, FirstName = "madeline", LastName = "kelly", Age = 57, Profession = "devops engineer", Salary = 3000, CompanyId = 3 },
                new Employee(){ Id = 4, FirstName = "connor", LastName = "coleman", Age = 18, Profession = "software architect", Salary = 4000, CompanyId = 4 },
                new Employee(){ Id = 5, FirstName = "eva", LastName = "simpson", Age = 25, Profession = "information security engineer", Salary = 2800, CompanyId = 5 },
                new Employee(){ Id = 5, FirstName = "sofia", LastName = "smith", Age = 19, Profession = "front-end developer", Salary = 1500, CompanyId = 1 }
            });

            otherEmployees = new List<Employee>();

            otherEmployees.AddRange(new Employee[]
            {
                new Employee(){ Id = 1, FirstName = "violet", LastName = "jones", Age = 24, Profession = "back-end developer", Salary = 1000, CompanyId = 4 },
            });

        }


        public string Aggregate()
        {
            var result = companies
                .Select(x => x.Name)
                .Aggregate((c1, c2) => c1 + ", " + c2);

            return result;
        }

        public bool All()
        {
            var result = employees.All(x => x.Age >= 18);
            return result;
        }

        public bool Any()
        {
            var result = employees.Any(x => x.Age > 30);
            return result;
        }

        public double Average()
        {
            var result = employees.Average(x => x.Salary);
            return result;
        }

        public IEnumerable<Employee> Concat()
        {
            var result = employees.Concat(otherEmployees);
            return result;
        }

        public bool Contains()
        {
            List<string> animals = new List<string>() { "harpy eagle", "jaguar", "capybara", "wolf", "rabbit" };
            var result = animals.Contains("jaguar");
            return result;
        }

        public bool ContainsWithObjects()
        {
            var result = employees.Contains(new Employee() { Id = 1 }, new EmployeeComparer());
            return result;
        }

        public int Count()
        {
            var result = employees.Count();

            return result;
        }

        public IEnumerable<string> DefaultIfEmpty()
        {
            List<string> countries = new List<string>();
            var result = countries.DefaultIfEmpty("Panama");
            return result;
        }

        public IEnumerable<int> Distinct()
        {
            List<int> values = new List<int>() { 1, 2, 3, 4, 5, 5, 7, 5, 1, 9, };
            var result = values.Distinct();
            return result;
        }

        public IEnumerable<Employee> DistinctWithObjects()
        {
            List<Employee> repeated = new List<Employee>();
            repeated.AddRange(employees.Take(2));
            repeated.AddRange(employees.Take(2));

            var result = repeated.Distinct(new EmployeeComparer());

            return result;
        }

        public Employee ElementAt()
        {
            return employees.ElementAt(0);
        }

        public Employee ElementAtOrDefault()
        {
            return employees.ElementAtOrDefault(0);
        }

        public IEnumerable<Employee> Empty()
        {
            return Enumerable.Empty<Employee>();
        }

        public IEnumerable<string> Except()
        {
            List<string> l1 = new List<string>() { "C#", "Angular", "PHP", "Vue", "Blazor" };
            List<string> l2 = new List<string>() { "PHP", "JavaScript", "React", "PHP", "Vue" };

            return l1.Except(l2);
        }

        public Employee First()
        {
            return employees.First();
        }

        public Employee FirstWithCondition()
        {
            return employees.First(x => x.Age == 19);
        }

        public Employee FirstOrDefault()
        {
            return employees.FirstOrDefault();
        }

        public Employee FirstOrDefaultWithCondition()
        {
            return employees.FirstOrDefault(x => x.CompanyId == 1);
        }

        public IEnumerable<IGrouping<int, Employee>> GroupBy()
        {
            var result = employees.GroupBy(x => x.Age);
            return result;
        }

        public IEnumerable<EmployeeProjectedGroup> GroupJoin()
        {
            var result = companies.GroupJoin(employees,
                comp => comp.Id,
                emp => emp.CompanyId,
                (cName, eGroup) => new EmployeeProjectedGroup()
                {
                    Employees = eGroup,
                    CompanyName = cName.Name
                });

            return result;
        }

        public IEnumerable<int> Intersect()
        {
            List<int> ids = new List<int> { 2, 7, 4, 8, 5, 1 };
            List<int> otherIds = new List<int> { 1, 9, 2, 8, 3, 7 };

            var result = ids.Intersect(otherIds);

            return result;
        }

        public IEnumerable<EmployeeAndCompany> Join()
        {
            var result = companies.Join(employees,
                comp => comp.Id,
                emp => emp.CompanyId,
                (c, e) => new EmployeeAndCompany()
                {
                    Id = e.Id,
                    Name = $"{e.FirstName} {e.LastName}",
                    Company = c.Name
                });

            return result;
        }

    }

    public class EmployeeComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee x, Employee y)
        {
            return x.Id == y.Id;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            throw new NotImplementedException();
        }
    }

}


