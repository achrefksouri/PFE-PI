using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
 
        public virtual ICollection <IntershipAgreementShhet> IntershipAgreementSheets { get; set; }
        public int ClassFK { get; set; }
        [ForeignKey("ClassFK")]
        public virtual CLass Class { get; set; }
        
        public virtual ICollection <GraduationProposal> GraduationpurposalList { get; set; }
        



    }
}
