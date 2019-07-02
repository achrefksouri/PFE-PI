using PFE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Data.Configurations
{
    public class IntershipSheetConfiguration : EntityTypeConfiguration<IntershipSheet>
    {
        public IntershipSheetConfiguration()
        {
           
            HasRequired<SheetCategory>(a => a.SheetCategory)
                .WithMany(e => e.IntershipSheetList)
                .HasForeignKey(s => s.SheetCategoryFK)
                .WillCascadeOnDelete(true);

            HasRequired<IntershipAgreementShhet>(i => i.IntershipAgreementShhet)
               .WithMany(f => f.IntershipSheets)
               .HasForeignKey(r => r.IntershipAgreementShhetFK)
               .WillCascadeOnDelete(true);


        }
    }
}
