using Microsoft.EntityFrameworkCore;

namespace _39_CodeFirstASPCore.Models
{
    public class StudentDBContext : DbContext
    {
        public StudentDBContext(DbContextOptions options) : base(options) 
        {
                 
        }
        public DbSet<Student> Students { get; set; }
    }
}
