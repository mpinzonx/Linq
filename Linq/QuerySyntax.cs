using Linq.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class QuerySyntax
    {

        private List<Person> people;
        private List<Contact> contacts;

        public QuerySyntax()
        {
            people = new List<Person>();

            people.AddRange(new Person[]
            {
                new Person() { Id = 1, FirstName = "mario", LastName = "pinzón", Age = 24 },
                new Person() { Id = 2, FirstName = "elisabeth", LastName = "johnson", Age = 25 },
                new Person() { Id = 3, FirstName = "ethan", LastName = "walker", Age = 15 },
                new Person() { Id = 4, FirstName = "anne", LastName = "smith", Age = 17 },
                new Person() { Id = 5, FirstName = "john", LastName = "green", Age = 45 },

                new Person() { Id = 6, FirstName = "isabella", LastName = "baker", Age = 32 },
                new Person() { Id = 7, FirstName = "thomas", LastName = "carter", Age = 12 },
                new Person() { Id = 8, FirstName = "sofia", LastName = "adams", Age = 17 },
                new Person() { Id = 9, FirstName = "andrew", LastName = "lewis", Age = 19 },
                new Person() { Id = 10, FirstName = "amelia", LastName = "clark", Age = 25 },
            });

            contacts = new List<Contact>();

            contacts.AddRange(new Contact[]
            {
                new Contact() { Id = 1, Email = "mpinzon@gmail.com", PersonId = 1 },
                new Contact() { Id = 2, Email = "ejohnson@gmail.com", PersonId = 2 },
                new Contact() { Id = 3, Email = "ewalker@gmail.com", PersonId = 3 },
                new Contact() { Id = 4, Email = "asmith@gmail.com", PersonId = 4 },
                new Contact() { Id = 5, Email = "jgreen@gmail.com", PersonId = 5 },

                new Contact() { Id = 6, Email = "ibaker@gmail.com", PersonId = 6 },
                new Contact() { Id = 7, Email = "tcarter@gmail.com", PersonId = 7 },
                new Contact() { Id = 8, Email = "sadams@gmail.com", PersonId = 8 },
                new Contact() { Id = 9, Email = "alewis@gmail.com", PersonId = 9 },
                new Contact() { Id = 10, Email = "aclark@gmail.com", PersonId = 10 },
            });

        }

        public IEnumerable<Person> GetDataSource()
        {
            var result = from p in people
                         select p;
            return result;
        }

        public IEnumerable<Person> Filter()
        {
            var result = from p in people
                         where p.Age < 18
                         select p;
            return result;
        }

        public IEnumerable<Person> Order()
        {
            var result = from p in people
                         orderby p.LastName ascending
                         select p;

            //var result = from p in people
            //             orderby p.LastName descending
            //             select p;

            return result;
        }

        public IEnumerable<IGrouping<int, Person>> Group()
        {
            var result = from p in people
                         group p by p.Age;

            return result;
        }

        public IEnumerable<PersonProjected> Join()
        {
            var result = from p in people
                         join c in contacts
                         on p.Id equals c.PersonId
                         select new PersonProjected()
                         {
                             Id = p.Id,
                             FullName = $"{p.FirstName} {p.LastName}",
                             Email = c.Email
                         };

            return result;
        }

    }
}
