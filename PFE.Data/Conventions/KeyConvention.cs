using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Data.Conventions
{
  public class KeyConvention : Convention
    {
        public KeyConvention()
        {
            this.Properties().Where(p => p.Name.StartsWith("Id")).Configure(p => p.IsKey());
        }
    }
}
