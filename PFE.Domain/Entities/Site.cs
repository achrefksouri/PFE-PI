using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
   public class Site
    {
        public   int IdSite{ get; set; }
        public  string Label { get; set; }
        public int? SchoolFK { get; set; }
        [ForeignKey("SchoolFK")]
        public virtual School School { get; set; }
        
        
        
        public ICollection<Departement> DepartementList { get; set; }
    }

}
