using PFE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Data.Configurations
{
    public class DepartementConfiguration : EntityTypeConfiguration<Departement>
    {
        public DepartementConfiguration() 
        {
            HasRequired<Site>(s => s.Site).WithMany(c => c.DepartementList).HasForeignKey(c => c.SiteFK).WillCascadeOnDelete(true);
        }
    }
}
