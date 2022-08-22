using Microsoft.EntityFrameworkCore;
using RhoTaSolution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhoTaSolution.Infrastructure.Persistence.ApplicationDBContext
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Hospital>? Hospitals { get; set; }
        public DbSet<Address>? Addresses { get; set; }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<JobTitle>? JobTitles { get; set; }
        public DbSet<Department>? Departments { get; set; }
        public DbSet<Appointment>? Appointments { get; set; }
        public DbSet<Doctor>? Doctors { get; set; }

    }
}
