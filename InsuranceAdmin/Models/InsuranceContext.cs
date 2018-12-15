using System;
using Microsoft.EntityFrameworkCore;

namespace InsuranceAdmin.Models
{
    public class InsuranceContext : DbContext
    {
        public InsuranceContext(DbContextOptions<InsuranceContext> options) : base(options)
        {
        }

        public DbSet<Insurance> insurances { get; set; }
        public DbSet<HouseInsurance> house_insurances { get; set; }
        public DbSet<VehicleInsurance> vehicle_insurances { get; set; }
    }
}
