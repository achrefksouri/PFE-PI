using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
   public class IntershipAgreementShhet
    {
        public int Id{ get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate{ get; set; }
        [DataType(DataType.Date)]
        public DateTime DeadLine{ get; set; }

        public Student Student { get; set; }
        public int StudentFK { get; set; }
        public Compagny Compagny { get; set; }
        public int CompagnyFK { get; set; }
    }
}
