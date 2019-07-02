using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
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
        
        [ForeignKey("SiteFK")]
        public virtual Site Site { get; set; }
        public int? SiteFK { get; set; }
        public virtual ICollection<Employee> EmployeeList { get; set; }
        public virtual ICollection<Option> OptionList { get; set; }
    }
}
