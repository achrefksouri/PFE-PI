using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [DataType(DataType.Date)]
        public  DateTime BirthDate { get; set; }
        //propriétés de navigation
        public List<IntershipSheet> IntershipSheetList { get; set; }
        public List<IntershipAgreementShhet> IntershipAgreementSheetList { get; set; }
        public CLass Class { get; set; }
        public int ClassFK { get; set; }
        public List<GraduationProposal> GraduationpurposalList { get; set; }
        



    }
}
