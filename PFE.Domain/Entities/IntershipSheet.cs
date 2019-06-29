using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
    public enum State { Approved, Rejected }
    public class IntershipSheet
    {
        public int IdIntershipSheet { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Issue { get; set; }
        public string Fonctionality { get; set; }
        public string Keyword { get; set; }
        public string PersoMail { get; set; }
        public string PeroMail { get; set; }
        public DateTime Date { get; set; }
        public string State { get; set; }

        public IntershipAgreementShhet IntershipAgreementShhet { get; set; }
        public Compagny Compagny { get; set; }
        public Student Student { get; set; }
        public GraduationProposal GraduationProposal;
        
    }

}
