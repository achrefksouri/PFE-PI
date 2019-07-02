using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
   public class Action
    {
        public  int IdAction { get; set; }
        public  string Label { get; set; }
        public int? IntershipSheetFK { get; set; }
        [ForeignKey("IntershipSheetFK")]
        public virtual IntershipSheet IntershipSheet { get; set; }
        

    }
}
