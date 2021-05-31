using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace TackleShopAdminApi.Models
{
    public partial class TackleDBContext : DbContext
    {
        public TackleDBContext()
        {
        }

        public TackleDBContext(DbContextOptions<TackleDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Combo> Combos { get; set; }
        public virtual DbSet<Line> Lines { get; set; }
        public virtual DbSet<Lure> Lures { get; set; }
        public virtual DbSet<Reel> Reels { get; set; }
        public virtual DbSet<Rod> Rods { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=TackleDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Chinese_PRC_CI_AS");

            modelBuilder.Entity<Combo>(entity =>
            {
                entity.ToTable("Combo");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Inventory).HasColumnName("Inventory#");

                entity.Property(e => e.ItemTypeForShipping)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Reel)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Rod)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Line>(entity =>
            {
                entity.ToTable("Line");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Diameter)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Inventory).HasColumnName("Inventory#");

                entity.Property(e => e.ItemTypeForShipping)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Length)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Perating)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PERating");

                entity.Property(e => e.Price).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Series)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpoolLength)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Strength)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Lure>(entity =>
            {
                entity.ToTable("Lure");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Buoyancy)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Color)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Hooks)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Inventory).HasColumnName("Inventory#");

                entity.Property(e => e.ItemTypeForShipping)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Length)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlasticsLength)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Series)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Reel>(entity =>
            {
                entity.ToTable("Reel");

                entity.Property(e => e.Bearings)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BraidCapacity)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.DiameterCapacity)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DragPower)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GearRatio)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Inventory).HasColumnName("Inventory#");

                entity.Property(e => e.ItemTypeForShipping)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MonoCapacity)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.ReelType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReelWeight)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RetrievePerCrank)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Series)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rod>(entity =>
            {
                entity.ToTable("Rod");

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CastWeight)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImagePath)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Inventory).HasColumnName("Inventory#");

                entity.Property(e => e.ItemTypeForShipping)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Length)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LineWeight)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Perating)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PERating");

                entity.Property(e => e.Pieces)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Price).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RodButtAssembly)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RodGrips)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RodGuides)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.RodType)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Series)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
