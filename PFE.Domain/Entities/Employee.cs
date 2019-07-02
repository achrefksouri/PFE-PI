using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
    public enum Role { Teacher , Supervisor , InternshipManager , departementManager , Administrator}
   public class Employee
    {
        public int IdEmployee { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Role Role { get; set; }
        public int DepartementFK { get; set; }
        //propriétes de navigation
        [ForeignKey("DepartementFK")]
        public virtual Departement Departement { get; set; }
        


    }
}
