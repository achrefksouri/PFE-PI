using PFE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Data.Configurations
{
    public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
    {
        public EmployeeConfiguration()
        {
            HasRequired<Departement>(s => s.Departement).WithMany(c => c.EmployeeList).HasForeignKey(c => c.DepFK).WillCascadeOnDelete(true);
        }
    }
}
