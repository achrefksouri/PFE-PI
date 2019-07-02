using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string State { get; set; }

        public SheetCategory SheetCategory { get; set; }


        public List<Action> Actionlist { get; set; }

        public int SheetCategoryFK { get; set; }

        public virtual  ICollection <IntershipSheet> Inter{ get; set; }
        public int IntershipAgreementShhetFK{ get; set; }


    }

}
