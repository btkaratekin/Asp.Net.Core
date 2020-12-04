﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OgrIsler.DataAccess.Concrete.EntityFramework;

namespace OgrIsler.DataAccess.Migrations
{
    [DbContext(typeof(OgrIslerDbContext))]
    [Migration("20201204235403_MyFirstMigration")]
    partial class MyFirstMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OgrIsler.Entities.Concrete.EntityFramework.Bilgi", b =>
                {
                    b.Property<string>("OgrNo")
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<bool>("Cinsiyet")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Dtarih")
                        .HasColumnType("datetime2");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("OgrNo");

                    b.ToTable("OgrBilgi");
                });

            modelBuilder.Entity("OgrIsler.Entities.Concrete.EntityFramework.Bolum", b =>
                {
                    b.Property<string>("Bkodu")
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.Property<string>("Badi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Bkodu");

                    b.ToTable("OgrBolum");
                });

            modelBuilder.Entity("OgrIsler.Entities.Concrete.EntityFramework.Danisman", b =>
                {
                    b.Property<int>("Dkodu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bkodu")
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Dadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Dsoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Dkodu");

                    b.HasIndex("Bkodu");

                    b.ToTable("OgrDanisman");
                });

            modelBuilder.Entity("OgrIsler.Entities.Concrete.EntityFramework.Okul", b =>
                {
                    b.Property<string>("OgrNo")
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<int?>("Dkodu")
                        .HasColumnType("int");

                    b.Property<string>("Pkodu")
                        .HasColumnType("nvarchar(3)");

                    b.Property<byte>("Sinif")
                        .HasColumnType("tinyint");

                    b.HasKey("OgrNo");

                    b.HasIndex("Dkodu");

                    b.HasIndex("Pkodu");

                    b.ToTable("OgrOkul");
                });

            modelBuilder.Entity("OgrIsler.Entities.Concrete.EntityFramework.PrograM", b =>
                {
                    b.Property<string>("Pkodu")
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.Property<string>("Bkodu")
                        .HasColumnType("nvarchar(3)");

                    b.Property<string>("Padi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Pkodu");

                    b.HasIndex("Bkodu");

                    b.ToTable("OgrProgram");
                });

            modelBuilder.Entity("OgrIsler.Entities.Concrete.EntityFramework.Danisman", b =>
                {
                    b.HasOne("OgrIsler.Entities.Concrete.EntityFramework.Bolum", "Bolumkodu")
                        .WithMany("danismanlar")
                        .HasForeignKey("Bkodu");
                });

            modelBuilder.Entity("OgrIsler.Entities.Concrete.EntityFramework.Okul", b =>
                {
                    b.HasOne("OgrIsler.Entities.Concrete.EntityFramework.Danisman", "Danismankodu")
                        .WithMany("okullar")
                        .HasForeignKey("Dkodu");

                    b.HasOne("OgrIsler.Entities.Concrete.EntityFramework.Bilgi", "bilgi")
                        .WithOne("okul")
                        .HasForeignKey("OgrIsler.Entities.Concrete.EntityFramework.Okul", "OgrNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OgrIsler.Entities.Concrete.EntityFramework.PrograM", "Programkodu")
                        .WithMany("okullar")
                        .HasForeignKey("Pkodu");
                });

            modelBuilder.Entity("OgrIsler.Entities.Concrete.EntityFramework.PrograM", b =>
                {
                    b.HasOne("OgrIsler.Entities.Concrete.EntityFramework.Bolum", "Bolumkodu")
                        .WithMany("programlar")
                        .HasForeignKey("Bkodu");
                });
#pragma warning restore 612, 618
        }
    }
}