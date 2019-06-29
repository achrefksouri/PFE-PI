using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
    public enum status { Scheduled , Postponed , Honored}
  public class GraduationProposal
    {
        public  int IdGraduateProposal { get; set; }
        public  DateTime DateGraduateProposal { get; set; }
        public  string Classroom { get; set; }

        public string statuts { get; set; }
        public int IdStudentFK { get; set; }
        public Student Student { get; set; }
    }

}
