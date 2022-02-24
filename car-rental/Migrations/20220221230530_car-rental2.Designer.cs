﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using car_rental.Data;

namespace car_rental.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220221230530_car-rental2")]
    partial class carrental2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("car_rental.Models.CarRental", b =>
                {
                    b.Property<int>("CarRentalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("RentFrom")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("RentTo")
                        .HasColumnType("datetime2");

                    b.Property<int>("RentalId")
                        .HasColumnType("int");

                    b.HasKey("CarRentalId");

                    b.HasIndex("CarId");

                    b.HasIndex("RentalId");

                    b.ToTable("CarRental");
                });

            modelBuilder.Entity("car_rental.Models.Cars", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarType")
                        .HasColumnType("int");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CarId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("car_rental.Models.Rental", b =>
                {
                    b.Property<int>("RentalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CustomerAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Pesel")
                        .HasColumnType("int");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("RentalId");

                    b.ToTable("Rental");
                });

            modelBuilder.Entity("car_rental.Models.CarRental", b =>
                {
                    b.HasOne("car_rental.Models.Cars", "Cars")
                        .WithMany("CarRental")
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("car_rental.Models.Rental", "Rental")
                        .WithMany("CarRental")
                        .HasForeignKey("RentalId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cars");

                    b.Navigation("Rental");
                });

            modelBuilder.Entity("car_rental.Models.Cars", b =>
                {
                    b.Navigation("CarRental");
                });

            modelBuilder.Entity("car_rental.Models.Rental", b =>
                {
                    b.Navigation("CarRental");
                });
#pragma warning restore 612, 618
        }
    }
}
