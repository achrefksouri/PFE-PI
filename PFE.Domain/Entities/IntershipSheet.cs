using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
    public enum State { Approved, Rejected ,Await }
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
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public State State { get; set; }
        public int SheetCategoryFK { get; set; }
        [ForeignKey("SheetCategory")]
        public virtual SheetCategory SheetCategory { get; set; }
        
        
        public virtual ICollection<Action> Actionlist { get; set; }

        
        public int IntershipAgreementShhetFK { get; set; }
        [ForeignKey("IntershipAgreementShhetFK")]
        public virtual IntershipAgreementShhet IntershipAgreementShhet { get; set; }
        


    }

}
