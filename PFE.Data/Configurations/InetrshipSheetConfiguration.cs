using PFE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Data.Configurations
{
    class InetrshipSheetConfiguration : EntityTypeConfiguration<IntershipSheet>
    {
        public InetrshipSheetConfiguration()
        {
            HasRequired<Compagny>(a => a.Compagny)
                  .WithMany(t => t.InetrshipSheetList)
                  .HasForeignKey(e => e.IdCompagnyFK)
                  .WillCascadeOnDelete(true);

            HasRequired<SheetCategory>(a => a.SheetCategory)
                .WithMany(e => e.IntershipSheetList)
                .HasForeignKey(s => s.IdSheetCategoryFK)
                .WillCascadeOnDelete(true);

           HasRequired<Student>(a => a.Student)
                .WithMany(e => e.IntershipSheetList)
                .HasForeignKey(s => s.IdStudentFK)
                .WillCascadeOnDelete(true);






        }
    }
}
