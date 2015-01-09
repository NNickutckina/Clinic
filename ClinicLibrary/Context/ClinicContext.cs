using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ClinicLibrary.DomainModel;
using ClinicLibrary.Services;

namespace ClinicLibrary.Context
{
    public class ClinicContext: DbContext
    {
        public ClinicContext()
            : base("Clinic") 
        {
            Database.SetInitializer<ClinicContext>(new CreateDatabaseIfNotExists<ClinicContext>());
            //Database.SetInitializer<ClinicContext>(new DropCreateDatabaseIfModelChanges<ClinicContext>());
            //Database.SetInitializer<ClinicContext>(new DropCreateDatabaseAlways<ClinicContext>());
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<ServiceType> Services { get; set; }
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<Visit> Visits { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>()
                .HasKey(e => e.Identifier);

            modelBuilder.Entity<ServiceType>()
                .HasKey(e => e.Identifier);

            modelBuilder.Entity<Service>()
                .HasKey(e => e.Identifier);

            modelBuilder.Entity<Policy>()
                .HasKey(e => e.Identifier);

            modelBuilder.Entity<Patient>()
                .HasKey(e => e.Identifier);

            modelBuilder.Entity<Insurance>()
                .HasKey(e => e.Identifier);

            modelBuilder.Entity<Visit>()
                        .HasRequired(ad => ad.Doctor);

            modelBuilder.Entity<Visit>()
                        .HasRequired(ad => ad.Policy);

            modelBuilder.Entity<Visit>()
                        .HasMany<Service>(s => s.Services);

            modelBuilder.Entity<Service>()
                .HasRequired(ad => ad.ServiceType);

            modelBuilder.Entity<Policy>()
                .HasRequired(ad => ad.Insurance);

            modelBuilder.Entity<Policy>()
                .HasRequired(ad => ad.Patient);

            modelBuilder.Entity<Policy>()
                .HasMany(ad => ad.ServiceList);
        } 
    }
}
