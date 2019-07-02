using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
   public class CLass
    {
        public  int IdClass { get; set; }
        public string label { get; set; }
        public int OptionFK { get; set; }

        //propriétes de navigation
        [ForeignKey("OptionFK")]
        public virtual Option Option { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime AcademicYear { get; set; }

       

        public virtual ICollection<Student> StudentList { get; set; }

        
       
       
       


    }
}
