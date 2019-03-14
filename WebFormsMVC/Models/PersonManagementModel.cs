using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace WebFormsMVC.Models
{
    public class PersonManagementModel
    {
        public string PageHeading { get; set; }
        public Person OwnerPerson { get; set; }
        public IEnumerable<Person> PersonList { get; set; }

        public bool EnableModelSelection
        {
            get { return PersonList.Count() > 0; }
        }
    }
}