using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
   public class Student
    {
        public  int IdStudent { get; set; }
        public string  FirstName{ get; set; }
        public  string LastName { get; set; }
        public  DateTime BirthDate { get; set; }
        //propriétés de navigation
        public List<IntershipSheet> IntershipSheetList { get; set; }
        public List<IntershipAgreementShhet> IntershipAgreementSheetList { get; set; }

        public List<GraduationProposal> GraduationpurposalList { get; set; }


    }
}
