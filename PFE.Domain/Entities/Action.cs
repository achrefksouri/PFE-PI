using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
   public class Action
    {
        public  int Id { get; set; }
        public  string Label { get; set; }
        public IntershipSheet IntershipSheet { get; set; }
        public string IdIntershipSheetFK { get; set; }

    }
}
