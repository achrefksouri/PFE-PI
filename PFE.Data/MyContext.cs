using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PFE.Domain.Entities;
using PFE.Data.Conventions;
using PFE.Data.Configurations;

namespace PFE.Data
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MyPFEDB")
        {

        }
        public DbSet<IntershipSheet> IntershipSheet { get; set; }
        public DbSet<Departement> Departement { get; set; }
        public DbSet<Student> Student { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Add(new KeyConvention());
            modelBuilder.Conventions.Add(new DateTimeConvention());
            modelBuilder.Configurations.Add(new ActionConfiguration());
            modelBuilder.Configurations.Add(new ClassConfiguration());
            modelBuilder.Configurations.Add(new DepartementConfiguration());
            modelBuilder.Configurations.Add(new EmployeeConfiguration());
            modelBuilder.Configurations.Add(new GraduationConfiguration());
            modelBuilder.Configurations.Add(new IntershipAgreementSheetConfiguration());
            modelBuilder.Configurations.Add(new IntershipSheetConfiguration());
            modelBuilder.Configurations.Add(new OptionConfiguration());
            modelBuilder.Configurations.Add(new SiteConfiguration());
            modelBuilder.Configurations.Add(new StudentConfiguration());

        }
    }
}
