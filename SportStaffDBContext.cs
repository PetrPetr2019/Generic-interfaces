using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace StaffSport
{
    public partial class SportStaffDBContext : DbContext
    {
        public SportStaffDBContext()
        {
        }

        public SportStaffDBContext(DbContextOptions<SportStaffDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Competition> Competition { get; set; }
        public virtual DbSet<Result> Result { get; set; }
        public virtual DbSet<Sportsman> Sportsman { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SportStaffDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competition>(entity =>
            {
                entity.ToTable("competition");

                entity.Property(e => e.CompetitionId).HasColumnName("competition_id");

                entity.Property(e => e.CompetitionName)
                    .HasColumnName("competition_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SetDate)
                    .HasColumnName("set_date")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WorldRecord).HasColumnName("world_record");
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("result");

                entity.Property(e => e.City).HasColumnName("city");

                entity.Property(e => e.CompetitionId)
                    .HasColumnName("competition_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.HoldDate)
                    .HasColumnName("hold_date")
                    .HasColumnType("date");

                entity.Property(e => e.Result1).HasColumnName("result");

                entity.Property(e => e.SportsmanId).HasColumnName("sportsman_id");
            });

            modelBuilder.Entity<Sportsman>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("sportsman");

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(255);

                entity.Property(e => e.PersonalRecord).HasColumnName("personal_record");

                entity.Property(e => e.Rank).HasColumnName("rank");

                entity.Property(e => e.SportsmanId)
                    .HasColumnName("sportsman_id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.SportsmanName)
                    .HasColumnName("sportsman_name")
                    .HasMaxLength(255);

                entity.Property(e => e.YearOfBirth)
                    .HasColumnName("year_of_birth")
                    .HasMaxLength(255);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
