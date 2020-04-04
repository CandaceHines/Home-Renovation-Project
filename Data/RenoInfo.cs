using StudentInformation.Models;
using Microsoft.EntityFrameworkCore;

namespace Home_Renovation_Budget.Models
{
    //Creates a new database context named StudentInformationContext
    public class StudentInformationContext : DbContext
    {
        public StudentInformationContext(DbContextOptions<StudentInformationContext> options) : base(options)
        {
        }

        //This is where we register our models as entities
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}