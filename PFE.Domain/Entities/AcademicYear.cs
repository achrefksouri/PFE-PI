using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
   public class AcademicYear
    {
        public int IdAcademicYear { get; set; }
        public  int Session { get; set; }
        //propriétes de navigation
        public List<Student> StudentList;


    }
}
