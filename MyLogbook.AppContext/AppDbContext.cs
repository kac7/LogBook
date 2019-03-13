using Microsoft.EntityFrameworkCore;
using MyLogbook.Entities;
using System;
using System.Collections.Generic;

namespace MyLogbook.AppContext
{
    public class AppDbContext: DbContext
    {
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<SubjectGoup> SubjectsGroups { get; set; } 

        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base (options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Faculty>().HasMany(f => f.Groups).WithOne();

            builder.Entity<Group>().HasOne(b => b.Faculty).WithMany(z => z.Groups).HasForeignKey(b => b.FacultyId);

            builder.Entity<Student>().HasOne(z => z.Group).WithMany(x => x.Students).HasForeignKey(z => z.GroupId);

            builder.Entity<Rating>().HasOne(z => z.Student).WithMany(x => x.Rating).HasForeignKey(z => z.StudenId);

            builder.Entity<Rating>().HasOne(z => z.Subject).WithMany(x => x.Rating).HasForeignKey(z => z.SubjectId);

            builder.Entity<Teacher>().HasMany(z => z.Subjects).WithOne();

            builder.Entity<Subject>().HasOne(z => z.Teacher).WithMany(x => x.Subjects).HasForeignKey(z => z.TeacherId);

            builder.Entity<SubjectGoup>().HasKey(z => new { z.GroupId, z.SubjectId }); 

            builder.Entity<SubjectGoup>().HasOne(z => z.Group).WithMany(x => x.SubjectGoup).HasForeignKey(z => z.GroupId);

            builder.Entity<SubjectGoup>().HasOne(z => z.Subject).WithMany(x => x.SubjectGoup).HasForeignKey(z => z.SubjectId);

            base.OnModelCreating(builder);

            builder.Entity<Faculty>().HasData(
                new Faculty
                {
                    Id = Guid.NewGuid(),
                    Name = "Programming",

                },
                new Faculty
                {
                    Id = Guid.NewGuid(),
                    Name = "System administration and security",

                },
                new Faculty
                {
                    Id = Guid.NewGuid(),
                    Name = "Disign",

                },
                new Faculty
                {
                    Id = Guid.NewGuid(),
                    Name = "Base",

                });
        }
    }
}
