using HospitalAssignment.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalAssignment.Context
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<CityInfo> CityInfo { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //  => optionsBuilder.UseNpgsql("Server=localhost;Port=5432;User Id=postgres;Password=P@ris2027!;Database=postgres;");
        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<CityInfo>().ToTable("CityInfos");

            builder.Entity<Address>().ToTable("Addresses");

            builder.Entity<Patient>().ToTable("patients");


            base.OnModelCreating(builder);
        }
    }
    
}
