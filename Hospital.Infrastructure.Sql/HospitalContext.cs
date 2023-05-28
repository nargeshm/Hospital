using HospitalEntities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Hospital.Infrastructure.Sql
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options) : base(options)
        {

        }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Department> Departments { get; set; }
    }

}