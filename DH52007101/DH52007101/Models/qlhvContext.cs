﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DH52007101.Models {
    public partial class qlhvContext : DbContext {
        public qlhvContext() {
        }

        public qlhvContext(DbContextOptions<qlhvContext> options)
            : base(options) {
        }

        public virtual DbSet<Diemthi> Diemthis { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<Lylich> Lyliches { get; set; }
        public virtual DbSet<Monhoc> Monhocs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=qlhv;Integrated Security=True;Encrypt=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Diemthi>(entity =>
            {
                entity.HasKey(e => new { e.Mshv, e.Msmh });

                entity.ToTable("diemthi");

                entity.Property(e => e.Mshv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("mshv");

                entity.Property(e => e.Msmh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("msmh");

                entity.Property(e => e.Diem)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("diem");

                entity.HasOne(d => d.MshvNavigation)
                    .WithMany(p => p.Diemthis)
                    .HasForeignKey(d => d.Mshv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_diemthi_lylich");

                entity.HasOne(d => d.MsmhNavigation)
                    .WithMany(p => p.Diemthis)
                    .HasForeignKey(d => d.Msmh)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_diemthi_monhoc");
            });

            modelBuilder.Entity<Lop>(entity =>
            {
                entity.HasKey(e => e.Malop);

                entity.ToTable("lop");

                entity.Property(e => e.Malop)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("malop");

                entity.Property(e => e.Tenlop)
                    .HasMaxLength(50)
                    .HasColumnName("tenlop");
            });

            modelBuilder.Entity<Lylich>(entity =>
            {
                entity.HasKey(e => e.Mshv);

                entity.ToTable("lylich");

                entity.Property(e => e.Mshv)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("mshv");

                entity.Property(e => e.Malop)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("malop");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaysinh");

                entity.Property(e => e.Phai).HasColumnName("phai");

                entity.Property(e => e.Tenhv)
                    .HasMaxLength(50)
                    .HasColumnName("tenhv");

                entity.HasOne(d => d.MalopNavigation)
                    .WithMany(p => p.Lyliches)
                    .HasForeignKey(d => d.Malop)
                    .HasConstraintName("FK_lylich_lop");
            });

            modelBuilder.Entity<Monhoc>(entity =>
            {
                entity.HasKey(e => e.Msmh);

                entity.ToTable("monhoc");

                entity.Property(e => e.Msmh)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("msmh");

                entity.Property(e => e.Sotiet).HasColumnName("sotiet");

                entity.Property(e => e.Tenmh)
                    .HasMaxLength(50)
                    .HasColumnName("tenmh");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
