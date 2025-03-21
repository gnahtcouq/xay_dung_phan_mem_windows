﻿// <auto-generated />
using System;
using DH52007101.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DH52007101.Migrations {
    [DbContext(typeof(qlhvContext))]
    partial class qlhvContextModelSnapshot : ModelSnapshot {
        protected override void BuildModel(ModelBuilder modelBuilder) {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("SQL_Latin1_General_CP1_CI_AS")
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DH52007101.Models.Diemthi", b =>
                {
                    b.Property<string>("Mshv")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("mshv");

                    b.Property<string>("Msmh")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("msmh");

                    b.Property<string>("Diem")
                        .HasMaxLength(5)
                        .IsUnicode(false)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("diem");

                    b.HasKey("Mshv", "Msmh");

                    b.HasIndex("Msmh");

                    b.ToTable("diemthi", (string)null);
                });

            modelBuilder.Entity("DH52007101.Models.Lop", b =>
                {
                    b.Property<string>("Malop")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("malop");

                    b.Property<string>("Tenlop")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tenlop");

                    b.HasKey("Malop");

                    b.ToTable("lop", (string)null);
                });

            modelBuilder.Entity("DH52007101.Models.Lylich", b =>
                {
                    b.Property<string>("Mshv")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("mshv");

                    b.Property<string>("Malop")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("malop");

                    b.Property<DateTime?>("Ngaysinh")
                        .HasColumnType("datetime")
                        .HasColumnName("ngaysinh");

                    b.Property<bool?>("Phai")
                        .HasColumnType("bit")
                        .HasColumnName("phai");

                    b.Property<string>("Tenhv")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tenhv");

                    b.HasKey("Mshv");

                    b.HasIndex("Malop");

                    b.ToTable("lylich", (string)null);
                });

            modelBuilder.Entity("DH52007101.Models.Monhoc", b =>
                {
                    b.Property<string>("Msmh")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)")
                        .HasColumnName("msmh");

                    b.Property<int?>("Sotiet")
                        .HasColumnType("int")
                        .HasColumnName("sotiet");

                    b.Property<string>("Tenmh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tenmh");

                    b.HasKey("Msmh");

                    b.ToTable("monhoc", (string)null);
                });

            modelBuilder.Entity("DH52007101.Models.Diemthi", b =>
                {
                    b.HasOne("DH52007101.Models.Lylich", "MshvNavigation")
                        .WithMany("Diemthis")
                        .HasForeignKey("Mshv")
                        .IsRequired()
                        .HasConstraintName("FK_diemthi_lylich");

                    b.HasOne("DH52007101.Models.Monhoc", "MsmhNavigation")
                        .WithMany("Diemthis")
                        .HasForeignKey("Msmh")
                        .IsRequired()
                        .HasConstraintName("FK_diemthi_monhoc");

                    b.Navigation("MshvNavigation");

                    b.Navigation("MsmhNavigation");
                });

            modelBuilder.Entity("DH52007101.Models.Lylich", b =>
                {
                    b.HasOne("DH52007101.Models.Lop", "MalopNavigation")
                        .WithMany("Lyliches")
                        .HasForeignKey("Malop")
                        .HasConstraintName("FK_lylich_lop");

                    b.Navigation("MalopNavigation");
                });

            modelBuilder.Entity("DH52007101.Models.Lop", b =>
                {
                    b.Navigation("Lyliches");
                });

            modelBuilder.Entity("DH52007101.Models.Lylich", b =>
                {
                    b.Navigation("Diemthis");
                });

            modelBuilder.Entity("DH52007101.Models.Monhoc", b =>
                {
                    b.Navigation("Diemthis");
                });
#pragma warning restore 612, 618
        }
    }
}
