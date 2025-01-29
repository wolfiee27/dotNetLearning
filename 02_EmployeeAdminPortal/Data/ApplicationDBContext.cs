using _02_EmployeeAdminPortal.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace _02_EmployeeAdminPortal.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
