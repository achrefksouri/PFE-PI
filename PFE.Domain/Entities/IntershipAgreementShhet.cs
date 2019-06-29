using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
   public class IntershipAgreementShhet
    {
        public int Id{ get; set; }
        public DateTime StartDate{ get; set; }
        public DateTime DeadLine{ get; set; }

        public Student Student { get; set; }
        public int IdStudentFK { get; set; }








    }
}
