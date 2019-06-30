using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Domain.Entities
{
   public class Compagny
    {
        public int IdCompagny { get; set; }
        public string WebSite { get; set; }
        public string Adress  { get; set; }
        public string Country{ get; set; }
        public  string ManagerName{ get; set; }
        public string ManagerEmail{ get; set; }
        public string SupervisorName { get; set; }
        public string SupervisorEmail{ get; set; }
        public int Phone { get; set; }
        //propriétes de navigation
        public List<IntershipSheet> InetrshipSheetList { get; set; }
    }
}
