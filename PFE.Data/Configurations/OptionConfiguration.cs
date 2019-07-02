using PFE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Data.Configurations
{
    public class OptionConfiguration : EntityTypeConfiguration <Option>
    {
        public OptionConfiguration()
        {
            HasOptional<Departement>(s => s.Departement).WithMany(c => c.OptionList).HasForeignKey(c => c.DepartementFK).WillCascadeOnDelete(true);
        }
    }

}
