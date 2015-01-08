using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ClinicLibrary.DomainModel;

namespace ClinicLibrary.Context
{
    public class ClinicContext: DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<ServiceType> Services { get; set; }
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<Visit> Visits { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{

        //} 
    }
}
