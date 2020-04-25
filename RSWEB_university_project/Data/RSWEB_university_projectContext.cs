using Microsoft.EntityFrameworkCore;
using RSWEB_university_project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RSWEB_university_project.Data
{
    public class RSWEB_university_projectContext : DbContext
    {
        public RSWEB_university_projectContext(DbContextOptions<RSWEB_university_projectContext> options)
            : base(options) {
        }

        public DbSet<Teacher> Teacher { 
            get;
            set;
        }
        public DbSet<Course> Course {
            get;
            set;
        }
        public DbSet<Enrollment> Enrollment { 
            get;
            set;
        }
        public DbSet<Student> Student {
            get;
            set;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Enrollment>()
                .HasOne<Student>(p => p.Student)
                .WithMany(p => p.Courses)
                .HasForeignKey(p => p.StudentID);
            

            modelBuilder.Entity<Enrollment>()
                .HasOne<Course>(d => d.Course)
                .WithMany(d => d.Students)
                .HasForeignKey(d => d.CourseID);

            modelBuilder.Entity<Course>()
                .HasOne<Teacher>(p => p.FirstTeacher)
                .WithMany(p => p.Teacher1)
                .HasForeignKey(p => p.FirstTeacherId);

            modelBuilder.Entity<Course>()
               .HasOne<Teacher>(p => p.SecondTeacher)
               .WithMany(p => p.Teacher2)
               .HasForeignKey(p => p.SecondTeacherId).OnDelete(DeleteBehavior.NoAction);
        }
    }
}
    

   

