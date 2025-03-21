﻿// <auto-generated />
using System;
using LeThanhTuan_206.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LeThanhTuan_206.Migrations
{
    [DbContext(typeof(csdl_thuephongContext))]
    [Migration("20240306012333_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LeThanhTuan_206.Models.Chitietphieuthue", b =>
                {
                    b.Property<string>("Sopt")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("sopt");

                    b.Property<string>("Maphong")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("maphong");

                    b.Property<double?>("Dongia")
                        .HasColumnType("float")
                        .HasColumnName("dongia");

                    b.Property<int?>("Songaythue")
                        .HasColumnType("int")
                        .HasColumnName("songaythue");

                    b.HasKey("Sopt", "Maphong");

                    b.HasIndex("Maphong");

                    b.ToTable("chitietphieuthue", (string)null);
                });

            modelBuilder.Entity("LeThanhTuan_206.Models.Khachthue", b =>
                {
                    b.Property<string>("Makh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("makh");

                    b.Property<string>("Socmnd")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("socmnd");

                    b.Property<string>("Sodienthoai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("sodienthoai");

                    b.Property<string>("Tenkh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("tenkh");

                    b.HasKey("Makh");

                    b.ToTable("khachthue", (string)null);
                });

            modelBuilder.Entity("LeThanhTuan_206.Models.Loaiphong", b =>
                {
                    b.Property<string>("Maloai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("maloai");

                    b.Property<double?>("Dongia")
                        .HasColumnType("float")
                        .HasColumnName("dongia");

                    b.Property<int?>("Songuoi")
                        .HasColumnType("int")
                        .HasColumnName("songuoi");

                    b.HasKey("Maloai");

                    b.ToTable("loaiphong", (string)null);
                });

            modelBuilder.Entity("LeThanhTuan_206.Models.Phieuthue", b =>
                {
                    b.Property<string>("Sopt")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("sopt");

                    b.Property<string>("Makh")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("makh");

                    b.Property<DateTime?>("Ngaythue")
                        .HasColumnType("date")
                        .HasColumnName("ngaythue");

                    b.HasKey("Sopt");

                    b.HasIndex("Makh");

                    b.ToTable("phieuthue", (string)null);
                });

            modelBuilder.Entity("LeThanhTuan_206.Models.Phong", b =>
                {
                    b.Property<string>("Maphong")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("maphong");

                    b.Property<string>("Maloai")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("maloai");

                    b.Property<int?>("Tinhtrang")
                        .HasColumnType("int")
                        .HasColumnName("tinhtrang");

                    b.HasKey("Maphong");

                    b.HasIndex("Maloai");

                    b.ToTable("phong", (string)null);
                });

            modelBuilder.Entity("LeThanhTuan_206.Models.Chitietphieuthue", b =>
                {
                    b.HasOne("LeThanhTuan_206.Models.Phong", "MaphongNavigation")
                        .WithMany("Chitietphieuthues")
                        .HasForeignKey("Maphong")
                        .IsRequired()
                        .HasConstraintName("FK_chitietphieuthue_phong");

                    b.HasOne("LeThanhTuan_206.Models.Phieuthue", "SoptNavigation")
                        .WithMany("Chitietphieuthues")
                        .HasForeignKey("Sopt")
                        .IsRequired()
                        .HasConstraintName("FK_chitietphieuthue_phieuthue");

                    b.Navigation("MaphongNavigation");

                    b.Navigation("SoptNavigation");
                });

            modelBuilder.Entity("LeThanhTuan_206.Models.Phieuthue", b =>
                {
                    b.HasOne("LeThanhTuan_206.Models.Khachthue", "MakhNavigation")
                        .WithMany("Phieuthues")
                        .HasForeignKey("Makh")
                        .HasConstraintName("FK_phieuthue_khachthue");

                    b.Navigation("MakhNavigation");
                });

            modelBuilder.Entity("LeThanhTuan_206.Models.Phong", b =>
                {
                    b.HasOne("LeThanhTuan_206.Models.Loaiphong", "MaloaiNavigation")
                        .WithMany("Phongs")
                        .HasForeignKey("Maloai")
                        .HasConstraintName("FK_phong_loaiphong");

                    b.Navigation("MaloaiNavigation");
                });

            modelBuilder.Entity("LeThanhTuan_206.Models.Khachthue", b =>
                {
                    b.Navigation("Phieuthues");
                });

            modelBuilder.Entity("LeThanhTuan_206.Models.Loaiphong", b =>
                {
                    b.Navigation("Phongs");
                });

            modelBuilder.Entity("LeThanhTuan_206.Models.Phieuthue", b =>
                {
                    b.Navigation("Chitietphieuthues");
                });

            modelBuilder.Entity("LeThanhTuan_206.Models.Phong", b =>
                {
                    b.Navigation("Chitietphieuthues");
                });
#pragma warning restore 612, 618
        }
    }
}
