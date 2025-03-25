﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mock;

#nullable disable

namespace Mock.Migrations
{
    [DbContext(typeof(WheelShareContext))]
    [Migration("20250324112518_init17")]
    partial class init17
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Repository.Entities.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.Property<int>("RideId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RideId");

                    b.HasIndex("UserId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Repository.Entities.Ride", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("DestinationAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("DestinationStationID")
                        .HasColumnType("int");

                    b.Property<int>("DriveId")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<int>("NumSeats")
                        .HasColumnType("int");

                    b.Property<bool>("SharedRide")
                        .HasColumnType("bit");

                    b.Property<string>("SourceAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SourceStationID")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("TotalCost")
                        .HasColumnType("float");

                    b.Property<int?>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DestinationStationID");

                    b.HasIndex("DriveId");

                    b.HasIndex("SourceStationID");

                    b.HasIndex("VehicleId");

                    b.ToTable("Rides");
                });

            modelBuilder.Entity("Repository.Entities.RideParticipant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DropOffLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PickupLocation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RideId")
                        .HasColumnType("int");

                    b.Property<double>("ShareCost")
                        .HasColumnType("float");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RideId");

                    b.HasIndex("UserId");

                    b.ToTable("RideParticipants");
                });

            modelBuilder.Entity("Repository.Entities.Station", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Stations");

                    b.HasData(
                        new
                        {
                            Id = -10,
                            Address = "שמעיה 6",
                            Area = "מרכז",
                            City = "אלעד"
                        },
                        new
                        {
                            Id = -1,
                            Address = "אבן גבירול 8",
                            Area = "מרכז",
                            City = "אלעד"
                        },
                        new
                        {
                            Id = -2,
                            Address = "רבן יוחנן בן זכאי 97",
                            Area = "מרכז",
                            City = "אלעד"
                        },
                        new
                        {
                            Id = -3,
                            Address = "רבי עקיבא 100",
                            Area = "מרכז",
                            City = "בני ברק"
                        },
                        new
                        {
                            Id = -4,
                            Address = "ז'בוטינסקי 150",
                            Area = "מרכז",
                            City = "בני ברק"
                        },
                        new
                        {
                            Id = -5,
                            Address = "חזון איש 50",
                            Area = "מרכז",
                            City = "בני ברק"
                        },
                        new
                        {
                            Id = -6,
                            Address = "יפו 234",
                            Area = "מרכז",
                            City = "ירושלים"
                        },
                        new
                        {
                            Id = -7,
                            Address = "עזה 29",
                            Area = "מרכז",
                            City = "ירושלים"
                        },
                        new
                        {
                            Id = -8,
                            Address = "דרך חברון 101",
                            Area = "מרכז",
                            City = "ירושלים"
                        },
                        new
                        {
                            Id = -9,
                            Address = "הנביאים 54",
                            Area = "מרכז",
                            City = "ירושלים"
                        });
                });

            modelBuilder.Entity("Repository.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Repository.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("CostPerHour")
                        .HasColumnType("float");

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Seats")
                        .HasColumnType("int");

                    b.Property<int>("StationID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StationID");

                    b.ToTable("Vehicles");

                    b.HasData(
                        new
                        {
                            Id = -1,
                            CostPerHour = 12.9,
                            LicensePlate = "123-45-678",
                            Seats = 5,
                            StationID = -10
                        },
                        new
                        {
                            Id = -2,
                            CostPerHour = 12.9,
                            LicensePlate = "123-45-679",
                            Seats = 5,
                            StationID = -10
                        },
                        new
                        {
                            Id = -3,
                            CostPerHour = 19.899999999999999,
                            LicensePlate = "123-45-677",
                            Seats = 7,
                            StationID = -10
                        },
                        new
                        {
                            Id = -4,
                            CostPerHour = 12.9,
                            LicensePlate = "234-56-789",
                            Seats = 5,
                            StationID = -1
                        },
                        new
                        {
                            Id = -5,
                            CostPerHour = 19.899999999999999,
                            LicensePlate = "234-56-788",
                            Seats = 7,
                            StationID = -1
                        },
                        new
                        {
                            Id = -6,
                            CostPerHour = 19.899999999999999,
                            LicensePlate = "345-67-890",
                            Seats = 7,
                            StationID = -2
                        },
                        new
                        {
                            Id = -7,
                            CostPerHour = 12.9,
                            LicensePlate = "234-56-789",
                            Seats = 5,
                            StationID = -2
                        },
                        new
                        {
                            Id = -8,
                            CostPerHour = 19.899999999999999,
                            LicensePlate = "234-56-788",
                            Seats = 7,
                            StationID = -2
                        },
                        new
                        {
                            Id = -9,
                            CostPerHour = 19.899999999999999,
                            LicensePlate = "111-23-456",
                            Seats = 7,
                            StationID = -3
                        },
                        new
                        {
                            Id = -10,
                            CostPerHour = 12.9,
                            LicensePlate = "111-23-567",
                            Seats = 5,
                            StationID = -3
                        },
                        new
                        {
                            Id = -11,
                            CostPerHour = 12.9,
                            LicensePlate = "111-23-678",
                            Seats = 5,
                            StationID = -3
                        },
                        new
                        {
                            Id = -12,
                            CostPerHour = 19.899999999999999,
                            LicensePlate = "111-23-789",
                            Seats = 7,
                            StationID = -3
                        },
                        new
                        {
                            Id = -13,
                            CostPerHour = 12.9,
                            LicensePlate = "222-34-567",
                            Seats = 5,
                            StationID = -4
                        },
                        new
                        {
                            Id = -14,
                            CostPerHour = 12.9,
                            LicensePlate = "222-34-678",
                            Seats = 5,
                            StationID = -4
                        },
                        new
                        {
                            Id = -15,
                            CostPerHour = 19.899999999999999,
                            LicensePlate = "222-34-789",
                            Seats = 7,
                            StationID = -4
                        },
                        new
                        {
                            Id = -16,
                            CostPerHour = 12.9,
                            LicensePlate = "333-23-678",
                            Seats = 5,
                            StationID = -5
                        },
                        new
                        {
                            Id = -17,
                            CostPerHour = 19.899999999999999,
                            LicensePlate = "333-34-456",
                            Seats = 7,
                            StationID = -5
                        },
                        new
                        {
                            Id = -18,
                            CostPerHour = 12.9,
                            LicensePlate = "333-34-567",
                            Seats = 5,
                            StationID = -5
                        },
                        new
                        {
                            Id = -19,
                            CostPerHour = 12.9,
                            LicensePlate = "333-34-678",
                            Seats = 5,
                            StationID = -5
                        },
                        new
                        {
                            Id = -20,
                            CostPerHour = 19.899999999999999,
                            LicensePlate = "333-34-789",
                            Seats = 7,
                            StationID = -5
                        },
                        new
                        {
                            Id = -21,
                            CostPerHour = 12.9,
                            LicensePlate = "444-34-678",
                            Seats = 5,
                            StationID = -6
                        },
                        new
                        {
                            Id = -22,
                            CostPerHour = 19.899999999999999,
                            LicensePlate = "444-34-789",
                            Seats = 7,
                            StationID = -7
                        },
                        new
                        {
                            Id = -23,
                            CostPerHour = 12.9,
                            LicensePlate = "444-23-789",
                            Seats = 5,
                            StationID = -7
                        },
                        new
                        {
                            Id = -24,
                            CostPerHour = 12.9,
                            LicensePlate = "444-56-789",
                            Seats = 5,
                            StationID = -7
                        },
                        new
                        {
                            Id = -25,
                            CostPerHour = 19.899999999999999,
                            LicensePlate = "444-78-789",
                            Seats = 7,
                            StationID = -7
                        },
                        new
                        {
                            Id = -26,
                            CostPerHour = 12.9,
                            LicensePlate = "555-23-678",
                            Seats = 5,
                            StationID = -8
                        },
                        new
                        {
                            Id = -27,
                            CostPerHour = 19.899999999999999,
                            LicensePlate = "555-34-456",
                            Seats = 7,
                            StationID = -8
                        },
                        new
                        {
                            Id = -28,
                            CostPerHour = 12.9,
                            LicensePlate = "555-34-567",
                            Seats = 5,
                            StationID = -8
                        },
                        new
                        {
                            Id = -29,
                            CostPerHour = 12.9,
                            LicensePlate = "555-34-678",
                            Seats = 5,
                            StationID = -8
                        },
                        new
                        {
                            Id = -30,
                            CostPerHour = 19.899999999999999,
                            LicensePlate = "555-34-789",
                            Seats = 7,
                            StationID = -8
                        },
                        new
                        {
                            Id = -31,
                            CostPerHour = 12.9,
                            LicensePlate = "666-34-567",
                            Seats = 5,
                            StationID = -9
                        },
                        new
                        {
                            Id = -32,
                            CostPerHour = 12.9,
                            LicensePlate = "666-34-678",
                            Seats = 5,
                            StationID = -9
                        },
                        new
                        {
                            Id = -33,
                            CostPerHour = 19.899999999999999,
                            LicensePlate = "666-34-789",
                            Seats = 7,
                            StationID = -9
                        });
                });

            modelBuilder.Entity("Repository.Entities.VehicleAvailability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<int>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("VehicleAvailabilities");
                });

            modelBuilder.Entity("Repository.Entities.Payment", b =>
                {
                    b.HasOne("Repository.Entities.Ride", "Ride")
                        .WithMany()
                        .HasForeignKey("RideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repository.Entities.User", "User")
                        .WithMany("Payments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ride");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Repository.Entities.Ride", b =>
                {
                    b.HasOne("Repository.Entities.Station", "DestinationStation")
                        .WithMany()
                        .HasForeignKey("DestinationStationID");

                    b.HasOne("Repository.Entities.User", "Driver")
                        .WithMany("Rides")
                        .HasForeignKey("DriveId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repository.Entities.Station", "SourceStation")
                        .WithMany()
                        .HasForeignKey("SourceStationID");

                    b.HasOne("Repository.Entities.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId");

                    b.Navigation("DestinationStation");

                    b.Navigation("Driver");

                    b.Navigation("SourceStation");

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Repository.Entities.RideParticipant", b =>
                {
                    b.HasOne("Repository.Entities.Ride", "Ride")
                        .WithMany()
                        .HasForeignKey("RideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Repository.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ride");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Repository.Entities.Vehicle", b =>
                {
                    b.HasOne("Repository.Entities.Station", "Station")
                        .WithMany("Vehicles")
                        .HasForeignKey("StationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Station");
                });

            modelBuilder.Entity("Repository.Entities.VehicleAvailability", b =>
                {
                    b.HasOne("Repository.Entities.Vehicle", "Vehicle")
                        .WithMany("VehicleAvailabilities")
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("Repository.Entities.Station", b =>
                {
                    b.Navigation("Vehicles");
                });

            modelBuilder.Entity("Repository.Entities.User", b =>
                {
                    b.Navigation("Payments");

                    b.Navigation("Rides");
                });

            modelBuilder.Entity("Repository.Entities.Vehicle", b =>
                {
                    b.Navigation("VehicleAvailabilities");
                });
#pragma warning restore 612, 618
        }
    }
}
