using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
   public class Departement
    {
        public int IdDepartement { get; set; }
        public string LabelDepartement { get; set; }
        //propriétes de navigation
        public Site Site { get; set; }
        public int SiteFK { get; set; }
        public List<Employee> EmployeeList { get; set; }
        public List<Option> OptionList { get; set; }
    }
}
