using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
   public class IntershipAgreementShhet
    {
        public int IdIntershipAgreementShhet { get; set; }
        [DataType(DataType.Date)]
        public DateTime StartDate{ get; set; }
        [DataType(DataType.Date)]
        public DateTime DeadLine{ get; set; }
        public int? StudentFK { get; set; }

        [ForeignKey("StudentFK")]
        public virtual Student Student { get; set; }
        public int CompagnyFK { get; set; }
        [ForeignKey("CompagnyFK")]
        public virtual Compagny Compagny { get; set; }
        
        public virtual ICollection< IntershipSheet> IntershipSheets { get; set; }
    }
}
