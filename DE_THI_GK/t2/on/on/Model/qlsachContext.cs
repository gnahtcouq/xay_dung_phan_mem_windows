using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace on.Models {
    public partial class qlsachContext : DbContext {
        public qlsachContext() {
        }

        public qlsachContext(DbContextOptions<qlsachContext> options)
            : base(options) {
        }

        public virtual DbSet<ChitietSachTacgium> ChitietSachTacgia { get; set; }
        public virtual DbSet<Nhaxuatban> Nhaxuatbans { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<Tacgium> Tacgia { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=sach;Integrated Security=True;Encrypt=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<ChitietSachTacgium>(entity =>
            {
                entity.HasKey(e => new { e.Masach, e.Matg });

                entity.ToTable("chitietSach_Tacgia");

                entity.Property(e => e.Masach)
                    .HasMaxLength(20)
                    .HasColumnName("masach");

                entity.Property(e => e.Matg)
                    .HasMaxLength(15)
                    .HasColumnName("matg");

                entity.HasOne(d => d.MasachNavigation)
                    .WithMany(p => p.ChitietSachTacgia)
                    .HasForeignKey(d => d.Masach)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_chitietSach_Tacgia_sach");

                entity.HasOne(d => d.MatgNavigation)
                    .WithMany(p => p.ChitietSachTacgia)
                    .HasForeignKey(d => d.Matg)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_chitietSach_Tacgia_tacgia");
            });

            modelBuilder.Entity<Nhaxuatban>(entity =>
            {
                entity.HasKey(e => e.Manxb);

                entity.ToTable("nhaxuatban");

                entity.Property(e => e.Manxb)
                    .HasMaxLength(15)
                    .HasColumnName("manxb");

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("diachi");

                entity.Property(e => e.Dienthoai)
                    .HasMaxLength(15)
                    .HasColumnName("dienthoai");

                entity.Property(e => e.Tennxb)
                    .HasMaxLength(50)
                    .HasColumnName("tennxb");
            });

            modelBuilder.Entity<Sach>(entity =>
            {
                entity.HasKey(e => e.Masach);

                entity.ToTable("sach");

                entity.Property(e => e.Masach)
                    .HasMaxLength(20)
                    .HasColumnName("masach");

                entity.Property(e => e.Manxb)
                    .HasMaxLength(15)
                    .HasColumnName("manxb");

                entity.Property(e => e.Namxb)
                    .HasMaxLength(10)
                    .HasColumnName("namxb");

                entity.Property(e => e.Tensach)
                    .HasMaxLength(50)
                    .HasColumnName("tensach");

                entity.Property(e => e.Theloai)
                    .HasMaxLength(50)
                    .HasColumnName("theloai");

                entity.HasOne(d => d.ManxbNavigation)
                    .WithMany(p => p.Saches)
                    .HasForeignKey(d => d.Manxb)
                    .HasConstraintName("FK_sach_nhaxuatban");
            });

            modelBuilder.Entity<Tacgium>(entity =>
            {
                entity.HasKey(e => e.Matg);

                entity.ToTable("tacgia");

                entity.Property(e => e.Matg)
                    .HasMaxLength(15)
                    .HasColumnName("matg");

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("date")
                    .HasColumnName("ngaysinh");

                entity.Property(e => e.Phai).HasColumnName("phai");

                entity.Property(e => e.Tentg)
                    .HasMaxLength(50)
                    .HasColumnName("tentg");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
