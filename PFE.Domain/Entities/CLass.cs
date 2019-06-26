using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
   public class CLass
    {
        public  int IdClass { get; set; }

        //propriétes de navigation
        public Option Option;
        public List<Student> StudentList;
       
    }
}
