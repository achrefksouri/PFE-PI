using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
   public class SheetCategory
    {
        public  int IdSheetCategory { get; set; }
        public  string Label { get; set; }

        //propriétés de navigation

        
        public virtual ICollection<IntershipSheet> IntershipSheetList { get; set; }

    }
}
