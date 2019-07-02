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
            HasOptional<Student>(sa => sa.Student)
                  .WithMany(te => te.IntershipAgreementSheets)
                  .HasForeignKey(ee => ee.StudentFK)
                  .WillCascadeOnDelete(false);
            HasRequired<Compagny>(a => a.Compagny)
                  .WithMany(t => t.IntershipAgreementShhetList)
                  .HasForeignKey(e => e.CompagnyFK)
                  .WillCascadeOnDelete(true);

            
        }
    }
    
    
}
