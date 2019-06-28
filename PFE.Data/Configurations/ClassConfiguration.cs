using PFE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Data.Configurations
{
  public class ClassConfiguration : EntityTypeConfiguration<CLass>
    {
        public ClassConfiguration()
        {
            HasRequired<AcademicYear>(a => a.year).WithMany(c => c.listCLass).HasForeignKey(c => c.YearFK).WillCascadeOnDelete(true);
        }
    }
}
