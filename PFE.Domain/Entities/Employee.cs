using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
   public class Employee
    {
        public int IdEmployee { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        //propriétes de navigation
        public Departement Departement;
        public Role Role;
    }
}
