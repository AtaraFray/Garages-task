using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace GaragesDAL.Models
{
    public partial class GaragesDBContext : DbContext
    {
        public GaragesDBContext()
        {
        }

        public GaragesDBContext(DbContextOptions<GaragesDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Garages> Garages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;DataBase=GaragesDB;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Garages>(entity =>
            {
                entity.Property(e => e.GarageAddress).HasMaxLength(200);

                entity.Property(e => e.GarageCity).HasMaxLength(200);

                entity.Property(e => e.GarageName).HasMaxLength(200);

                entity.Property(e => e.GaragePhone).HasMaxLength(50);

                entity.Property(e => e.GarageType).HasMaxLength(100);

                entity.Property(e => e.Profession).HasMaxLength(200);

                entity.Property(e => e.ProfessionManager).HasMaxLength(200);

                entity.Property(e => e.Testime).HasMaxLength(200);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
