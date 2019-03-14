using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebFormsMVC.Models
{
    public class PersonRepository : IPersonRepository
    {
        public IEnumerable<Person> GetPeople()
        {
            yield return new Person("Bob", 21);
            yield return new Person("Frank", 21);
            yield return new Person("Wilma", 25);
        }
    }
}