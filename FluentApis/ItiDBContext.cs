using AssignmentC_EFCORE.convention;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_EFCORE.FluentApis
{
    internal class ItiDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseInst> CourseInsts { get; set; }
        public DbSet<StudCourse> StudCourses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ebrahim\\SQLEXPRESS;Database=ITIDB;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Student
            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(s => s.StudID);
                entity.Property(s => s.FName).IsRequired().HasMaxLength(50);
                entity.Property(s => s.LName).IsRequired().HasMaxLength(50);
                entity.Property(s => s.Age).IsRequired();
            });

            // Department
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(d => d.DeptID);
                entity.Property(d => d.Name).IsRequired().HasMaxLength(100);
            });

            // Course
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(c => c.CourID);
                entity.Property(c => c.Name).IsRequired().HasMaxLength(100);
            });

            // Instructor
            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.HasKey(i => i.InsID);
                entity.Property(i => i.Name).IsRequired().HasMaxLength(100);
            });

            // Topic
            modelBuilder.Entity<Topic>(entity =>
            {
                entity.HasKey(t => t.TopID);
                entity.Property(t => t.Name).IsRequired().HasMaxLength(50);
            });

            // StudCourse (Composite Key)
            modelBuilder.Entity<StudCourse>(entity =>
            {
                entity.HasKey(sc => new { sc.StudID, sc.CourID });
            });

            // CourseInst (Composite Key)
            modelBuilder.Entity<CourseInst>(entity =>
            {
                entity.HasKey(ci => new { ci.InstID, ci.CourID });
            });


        }
    }
}
