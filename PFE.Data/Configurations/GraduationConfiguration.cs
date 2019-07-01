using PFE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Data.Configurations
{
   public class GraduationConfiguration : EntityTypeConfiguration<GraduationProposal>
    {
        public GraduationConfiguration()
        {
            HasRequired<Student>(a => a.Student)
                .WithMany(c => c.GraduationpurposalList)
                .HasForeignKey(c => c.StudentFK)
                .WillCascadeOnDelete(true);
        }
    }
}
