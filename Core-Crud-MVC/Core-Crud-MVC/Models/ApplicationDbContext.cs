using Microsoft.EntityFrameworkCore;

namespace Core_Crud_MVC.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {


        }

        public DbSet<NewEmpClass> EmployeeTable { get; set; }
    }
}
