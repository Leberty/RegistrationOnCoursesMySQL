using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RegistrationOnCourses
{
    public partial class registration_on_coursesContext : DbContext
    {
        public registration_on_coursesContext()
        {
        }

        public registration_on_coursesContext(DbContextOptions<registration_on_coursesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CoursesSet> CoursesSets { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UsersOnCourse> UsersOnCourses { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;user=root;password=12345;database=registration_on_courses", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.27-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<CoursesSet>(entity =>
            {
                entity.ToTable("courses_set");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CourseCountHours)
                    .HasMaxLength(45)
                    .HasColumnName("courseCountHours");

                entity.Property(e => e.CourseFinish).HasColumnName("courseFinish");

                entity.Property(e => e.CourseName)
                    .HasMaxLength(45)
                    .HasColumnName("courseName");

                entity.Property(e => e.CourseStart).HasColumnName("courseStart");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("users");

                entity.HasIndex(e => e.Id, "id_UNIQUE")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EduLevel)
                    .HasMaxLength(45)
                    .HasColumnName("eduLevel");

                entity.Property(e => e.Midname)
                    .HasMaxLength(45)
                    .HasColumnName("midname");

                entity.Property(e => e.Name)
                    .HasMaxLength(45)
                    .HasColumnName("name");

                entity.Property(e => e.Surname)
                    .HasMaxLength(45)
                    .HasColumnName("surname");
            });

            modelBuilder.Entity<UsersOnCourse>(entity =>
            {
                entity.ToTable("users_on_courses");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CourseId).HasColumnName("courseId");

                entity.Property(e => e.UsersId).HasColumnName("usersId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
