using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFormsMVC.Models
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPeople();
    }
}
