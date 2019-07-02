using System;

using PFE.Domain.Entities;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Data.Configurations
{
    public class ActionConfiguration : EntityTypeConfiguration <Domain.Entities.Action>
    {
        public ActionConfiguration()
        {
            HasRequired<IntershipSheet>(a => a.IntershipSheet)
                .WithMany(c => c.Actionlist)
                .HasForeignKey(c => c.IntershipSheetFK)
                .WillCascadeOnDelete(true);
        }
    }
    //test 
}

