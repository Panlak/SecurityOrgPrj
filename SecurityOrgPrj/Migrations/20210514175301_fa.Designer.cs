﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SecurityOrgPrj;

namespace SecurityOrgPrj.Migrations
{
    [DbContext(typeof(AppDBContent))]
    [Migration("20210514175301_fa")]
    partial class fa
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CityName")
                        .HasColumnType("text");

                    b.Property<int?>("CountriesId")
                        .HasColumnType("integer");

                    b.HasKey("CityId");

                    b.HasIndex("CountriesId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CityId")
                        .HasColumnType("integer");

                    b.Property<string>("Custome_Surname")
                        .HasColumnType("text");

                    b.Property<string>("Customer_Name")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.HasKey("CustomerId");

                    b.HasIndex("CityId");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.SecurityOrganization", b =>
                {
                    b.Property<int>("SecurityOrganizationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CityId")
                        .HasColumnType("integer");

                    b.Property<int>("CountEmployees")
                        .HasColumnType("integer");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("NameOrganization")
                        .HasColumnType("text");

                    b.HasKey("SecurityOrganizationId");

                    b.HasIndex("CityId");

                    b.ToTable("SecurityOrganization");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.Service", b =>
                {
                    b.Property<int>("SecurityOrganizationId")
                        .HasColumnType("integer");

                    b.Property<int>("ServiceId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.HasKey("SecurityOrganizationId", "ServiceId");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.Subscription", b =>
                {
                    b.Property<int>("ServiceId")
                        .HasColumnType("integer");

                    b.Property<int>("ServiceSecurityOrganizationId")
                        .HasColumnType("integer");

                    b.Property<int>("SubscriptionId")
                        .HasColumnType("integer");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("EndtSubscription")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartSubscription")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("SubscriptionName")
                        .HasColumnType("text");

                    b.HasKey("ServiceId", "ServiceSecurityOrganizationId", "SubscriptionId", "CustomerId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Subscription");
                });

            modelBuilder.Entity("SecurityOrgPrj.Models.Countries", b =>
                {
                    b.Property<int>("CountriesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CountryName")
                        .HasColumnType("text");

                    b.HasKey("CountriesId");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.City", b =>
                {
                    b.HasOne("SecurityOrgPrj.Models.Countries", null)
                        .WithMany("City")
                        .HasForeignKey("CountriesId");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.Customer", b =>
                {
                    b.HasOne("SecurityOrgPrj.Data.Models.City", null)
                        .WithMany("Customer")
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.SecurityOrganization", b =>
                {
                    b.HasOne("SecurityOrgPrj.Data.Models.City", null)
                        .WithMany("SecurityOrganizationId")
                        .HasForeignKey("CityId");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.Service", b =>
                {
                    b.HasOne("SecurityOrgPrj.Data.Models.SecurityOrganization", null)
                        .WithMany("Service")
                        .HasForeignKey("SecurityOrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.Subscription", b =>
                {
                    b.HasOne("SecurityOrgPrj.Data.Models.Customer", null)
                        .WithMany("Subscription")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SecurityOrgPrj.Data.Models.Service", "Service")
                        .WithMany("Subscription")
                        .HasForeignKey("ServiceId", "ServiceSecurityOrganizationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Service");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.City", b =>
                {
                    b.Navigation("Customer");

                    b.Navigation("SecurityOrganizationId");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.Customer", b =>
                {
                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.SecurityOrganization", b =>
                {
                    b.Navigation("Service");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.Service", b =>
                {
                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("SecurityOrgPrj.Models.Countries", b =>
                {
                    b.Navigation("City");
                });
#pragma warning restore 612, 618
        }
    }
}
