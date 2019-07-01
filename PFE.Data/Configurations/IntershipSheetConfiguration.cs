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
            HasRequired<Compagny>(a => a.Compagny)
                  .WithMany(t => t.InetrshipSheetList)
                  .HasForeignKey(e => e.CompagnyFK)
                  .WillCascadeOnDelete(true);

            HasRequired<SheetCategory>(a => a.SheetCategory)
                .WithMany(e => e.IntershipSheetList)
                .HasForeignKey(s => s.SheetCategoryFK)
                .WillCascadeOnDelete(true);

           HasRequired<Student>(a => a.Student)
                .WithMany(e => e.IntershipSheetList)
                .HasForeignKey(s => s.StudentFK)
                .WillCascadeOnDelete(true);

        }
    }
}
