using Microsoft.EntityFrameworkCore;
using System;

namespace TrackRecordAPI.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<TrackRecord> TrackRecords { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

            modelBuilder.Entity<Student>().HasData(
                new Student
                {
                    StudentId = 1,
                    FirstName = "Ritesh",
                    LastName = "Joshi",
                    StudentAge = 22,
                    DOB = DateTime.UtcNow
                }, 
                new Student
                {
                    StudentId = 2,
                    FirstName = "Amit",
                    LastName = "Joshi",
                    StudentAge = 20,
                    DOB = DateTime.UtcNow
                }
            );
        }
    }
}
