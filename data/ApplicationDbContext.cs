using A1.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace A1.data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions options) : base (options) { }

        public DbSet<School> Schools { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Student>()
                .HasOne(s => s.School)
                .WithMany(sc => sc.Students)
                .HasForeignKey(s => s.SchoolId)
                .OnDelete(DeleteBehavior.Restrict); 

            builder.Entity<Teacher>()
                .HasOne(t => t.School)
                .WithMany(sc => sc.Teachers)
                .HasForeignKey(t => t.SchoolId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<School>().HasData(
                new School { Id = 1, Name = "Al-Nour School", Address = "Tahrir St" },
                new School { Id = 2, Name = "Future Academy", Address = "Corniche" },
                new School { Id = 3, Name = "Pioneers School", Address = "Sporting" });

            builder.Entity<Teacher>().HasData(
                new Teacher { Id = 1, Name = "Mr. Ahmed", SchoolId = 1 },
                new Teacher { Id = 2, Name = "Mrs. Mona", SchoolId = 1 },
                new Teacher { Id = 3, Name = "Mr. Khaled", SchoolId = 2 }
            );

            builder.Entity<Subject>().HasData(
                new Subject { Id = 1, Name = "Mathematics", TeacherId = 1 },
                new Subject { Id = 2, Name = "English", TeacherId = 2 },
                new Subject { Id = 3, Name = "Physics", TeacherId = 3 }
            );

            builder.Entity<Student>().HasData(
                new Student { Id = 1, Name = "Omar", Age = 16, GradeLevel = "10th", SchoolId = 1 },
                new Student { Id = 2, Name = "Sara", Age = 17, GradeLevel = "11th", SchoolId = 1 },
                new Student { Id = 3, Name = "Ali", Age = 15, GradeLevel = "9th", SchoolId = 2 }
            );

            builder.Entity("StudentSubject").HasData(
                new { StudentsId = 1, SubjectsId = 1 }, 
                new { StudentsId = 1, SubjectsId = 2 }, 
                new { StudentsId = 2, SubjectsId = 2 },  
                new { StudentsId = 3, SubjectsId = 3 }
            );
        }

    }
}
