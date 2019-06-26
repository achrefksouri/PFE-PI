using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
    public class Role
    {
        public int IdRole { get; set; }
        public string Label{ get; set; }
        //propriétes de navigation
        public List<Employee> EmployeeList;
    }
}