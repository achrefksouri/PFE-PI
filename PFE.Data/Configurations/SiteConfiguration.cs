﻿using PFE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFE.Data.Configurations
{
   public class SiteConfiguration : EntityTypeConfiguration<Site>
    {
        public SiteConfiguration()
        {
            HasOptional<School>(s => s.School).WithMany(c => c.Siteslist).HasForeignKey(c => c.SchoolFK).WillCascadeOnDelete(true);
        }
    }
}
