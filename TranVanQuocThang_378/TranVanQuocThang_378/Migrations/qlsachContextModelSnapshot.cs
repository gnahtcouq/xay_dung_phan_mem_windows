﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPISach.Models;

#nullable disable

namespace TranVanQuocThang_378.Migrations
{
    [DbContext(typeof(qlsachContext))]
    partial class qlsachContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebAPISach.Models.ChitietSachTacgium", b =>
                {
                    b.Property<string>("Masach")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("masach");

                    b.Property<string>("Matg")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("matg");

                    b.HasKey("Masach", "Matg");

                    b.HasIndex("Matg");

                    b.ToTable("chitietSach_Tacgia", (string)null);
                });

            modelBuilder.Entity("WebAPISach.Models.Nhaxuatban", b =>
                {
                    b.Property<string>("Manxb")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("manxb");

                    b.Property<string>("Diachi")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("diachi");

                    b.Property<string>("Dienthoai")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("dienthoai");

                    b.Property<string>("Tennxb")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tennxb");

                    b.HasKey("Manxb");

                    b.ToTable("nhaxuatban", (string)null);
                });

            modelBuilder.Entity("WebAPISach.Models.Sach", b =>
                {
                    b.Property<string>("Masach")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("masach");

                    b.Property<string>("Manxb")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("manxb");

                    b.Property<string>("Namxb")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("namxb");

                    b.Property<string>("Tensach")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tensach");

                    b.Property<string>("Theloai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("theloai");

                    b.HasKey("Masach");

                    b.HasIndex("Manxb");

                    b.ToTable("sach", (string)null);
                });

            modelBuilder.Entity("WebAPISach.Models.Tacgium", b =>
                {
                    b.Property<string>("Matg")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasColumnName("matg");

                    b.Property<DateTime?>("Ngaysinh")
                        .HasColumnType("date")
                        .HasColumnName("ngaysinh");

                    b.Property<bool?>("Phai")
                        .HasColumnType("bit")
                        .HasColumnName("phai");

                    b.Property<string>("Tentg")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tentg");

                    b.HasKey("Matg");

                    b.ToTable("tacgia", (string)null);
                });

            modelBuilder.Entity("WebAPISach.Models.ChitietSachTacgium", b =>
                {
                    b.HasOne("WebAPISach.Models.Sach", "MasachNavigation")
                        .WithMany("ChitietSachTacgia")
                        .HasForeignKey("Masach")
                        .IsRequired()
                        .HasConstraintName("FK_chitietSach_Tacgia_sach");

                    b.HasOne("WebAPISach.Models.Tacgium", "MatgNavigation")
                        .WithMany("ChitietSachTacgia")
                        .HasForeignKey("Matg")
                        .IsRequired()
                        .HasConstraintName("FK_chitietSach_Tacgia_tacgia");

                    b.Navigation("MasachNavigation");

                    b.Navigation("MatgNavigation");
                });

            modelBuilder.Entity("WebAPISach.Models.Sach", b =>
                {
                    b.HasOne("WebAPISach.Models.Nhaxuatban", "ManxbNavigation")
                        .WithMany("Saches")
                        .HasForeignKey("Manxb")
                        .HasConstraintName("FK_sach_nhaxuatban");

                    b.Navigation("ManxbNavigation");
                });

            modelBuilder.Entity("WebAPISach.Models.Nhaxuatban", b =>
                {
                    b.Navigation("Saches");
                });

            modelBuilder.Entity("WebAPISach.Models.Sach", b =>
                {
                    b.Navigation("ChitietSachTacgia");
                });

            modelBuilder.Entity("WebAPISach.Models.Tacgium", b =>
                {
                    b.Navigation("ChitietSachTacgia");
                });
#pragma warning restore 612, 618
        }
    }
}
