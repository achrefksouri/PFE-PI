using PFE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Data.Configurations
{
    class IntershipAgreementSheetConfiguration : EntityTypeConfiguration<IntershipAgreementShhet>

    {
        public IntershipAgreementSheetConfiguration()
        {
            HasRequired<Student>(e => e.Student)
                  .WithMany(r => r.IntershipAgreementSheetList)
                  .HasForeignKey(f => f.IdStudentFK)
                  .WillCascadeOnDelete(true);
        }
    }
    test
}
