using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
  public class GraduationProposal
    {
        public  int IdGraduateProposal { get; set; }
        public  DateTime DateGraduateProposal { get; set; }
        public  string Classroom { get; set; }

        public IntershipSheet IntershipSheet;
    }

}
