using PFE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Data.Configurations
{
   public class StudentConfiguration : EntityTypeConfiguration<Student>
    {
        public StudentConfiguration()
        {
            HasRequired<CLass>(a => a.Class)
                .WithMany(a => a.StudentList)
                .HasForeignKey(a => a.ClassFK)
                .WillCascadeOnDelete(true);

            
        }
    }
}
