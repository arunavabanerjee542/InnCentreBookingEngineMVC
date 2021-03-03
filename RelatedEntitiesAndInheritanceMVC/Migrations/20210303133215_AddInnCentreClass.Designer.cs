﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RelatedEntitiesAndInheritanceMVC.Models;

namespace RelatedEntitiesAndInheritanceMVC.Migrations
{
    [DbContext(typeof(InnCentreDbContext))]
    [Migration("20210303133215_AddInnCentreClass")]
    partial class AddInnCentreClass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RelatedEntitiesAndInheritanceMVC.Models.InnCentreBookingEngine", b =>
                {
                    b.Property<int>("InnCentreBookingEngineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("InnCentreBookingEngineId");

                    b.ToTable("InnCentreBookingEngines");
                });

            modelBuilder.Entity("RelatedEntitiesAndInheritanceMVC.Models.Property", b =>
                {
                    b.Property<int>("PropertyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PropertyId");

                    b.ToTable("Property");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Property");
                });

            modelBuilder.Entity("RelatedEntitiesAndInheritanceMVC.Models.PropertyBookingWebServer", b =>
                {
                    b.Property<int>("PropertyBookingWebServerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("InnCentreBookingEngineId")
                        .HasColumnType("int");

                    b.HasKey("PropertyBookingWebServerId");

                    b.HasIndex("InnCentreBookingEngineId");

                    b.ToTable("PropertyBookingWebServers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("PropertyBookingWebServer");
                });

            modelBuilder.Entity("RelatedEntitiesAndInheritanceMVC.Models.PropertyBookingWebServerHasProperty", b =>
                {
                    b.Property<int>("PropertyId")
                        .HasColumnType("int");

                    b.Property<int>("PropertyBookingWebServerId")
                        .HasColumnType("int");

                    b.HasKey("PropertyId", "PropertyBookingWebServerId");

                    b.HasIndex("PropertyBookingWebServerId");

                    b.ToTable("propertyBookingWebServerHasProperties");
                });

            modelBuilder.Entity("RelatedEntitiesAndInheritanceMVC.Models.Room", b =>
                {
                    b.Property<int>("RoomId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("HotelId")
                        .HasColumnType("int");

                    b.Property<bool>("IsAvailable")
                        .HasColumnType("bit");

                    b.HasKey("RoomId");

                    b.HasIndex("HotelId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("RelatedEntitiesAndInheritanceMVC.Models.Hotel", b =>
                {
                    b.HasBaseType("RelatedEntitiesAndInheritanceMVC.Models.Property");

                    b.Property<int>("RoomCount")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Hotel");
                });

            modelBuilder.Entity("RelatedEntitiesAndInheritanceMVC.Models.AirBnb", b =>
                {
                    b.HasBaseType("RelatedEntitiesAndInheritanceMVC.Models.PropertyBookingWebServer");

                    b.HasDiscriminator().HasValue("AirBnb");
                });

            modelBuilder.Entity("RelatedEntitiesAndInheritanceMVC.Models.Expedia", b =>
                {
                    b.HasBaseType("RelatedEntitiesAndInheritanceMVC.Models.PropertyBookingWebServer");

                    b.HasDiscriminator().HasValue("Expedia");
                });

            modelBuilder.Entity("RelatedEntitiesAndInheritanceMVC.Models.InnRoad", b =>
                {
                    b.HasBaseType("RelatedEntitiesAndInheritanceMVC.Models.PropertyBookingWebServer");

                    b.HasDiscriminator().HasValue("InnRoad");
                });

            modelBuilder.Entity("RelatedEntitiesAndInheritanceMVC.Models.PropertyBookingWebServer", b =>
                {
                    b.HasOne("RelatedEntitiesAndInheritanceMVC.Models.InnCentreBookingEngine", "InnCentreBookingEngine")
                        .WithMany("PropertyBookingWebServers")
                        .HasForeignKey("InnCentreBookingEngineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RelatedEntitiesAndInheritanceMVC.Models.PropertyBookingWebServerHasProperty", b =>
                {
                    b.HasOne("RelatedEntitiesAndInheritanceMVC.Models.PropertyBookingWebServer", "PropertyBookingWebServer")
                        .WithMany("PropertyBookingWebServerHasProperties")
                        .HasForeignKey("PropertyBookingWebServerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RelatedEntitiesAndInheritanceMVC.Models.Property", "Property")
                        .WithMany("PropertyBookingWebServerHasProperties")
                        .HasForeignKey("PropertyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RelatedEntitiesAndInheritanceMVC.Models.Room", b =>
                {
                    b.HasOne("RelatedEntitiesAndInheritanceMVC.Models.Hotel", "Hotel")
                        .WithMany("Rooms")
                        .HasForeignKey("HotelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
