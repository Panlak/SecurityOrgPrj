﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SecurityOrgPrj;

namespace SecurityOrgPrj.Migrations
{
    [DbContext(typeof(AppDBContent))]
    partial class AppDBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .IsRequired()
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

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.DeparutureInfo", b =>
                {
                    b.Property<int>("DeparutureInfoId")
                        .HasColumnType("integer");

                    b.Property<int>("EventsId")
                        .HasColumnType("integer");

                    b.Property<int>("EventsSubscriptionId")
                        .HasColumnType("integer");

                    b.Property<int>("EventsSubscriptionServiceId")
                        .HasColumnType("integer");

                    b.Property<int>("EventsSubscriptionServiceSecurityOrganizationId")
                        .HasColumnType("integer");

                    b.Property<int>("EventsSubscriptionCustomerId")
                        .HasColumnType("integer");

                    b.Property<int>("StaffId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.HasKey("DeparutureInfoId", "EventsId", "EventsSubscriptionId", "EventsSubscriptionServiceId", "EventsSubscriptionServiceSecurityOrganizationId", "EventsSubscriptionCustomerId", "StaffId");

                    b.HasIndex("DeparutureInfoId")
                        .IsUnique();

                    b.HasIndex("StaffId");

                    b.HasIndex("EventsId", "EventsSubscriptionId", "EventsSubscriptionServiceId", "EventsSubscriptionServiceSecurityOrganizationId", "EventsSubscriptionCustomerId");

                    b.ToTable("DeparutureInfo");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.Events", b =>
                {
                    b.Property<int>("EventsId")
                        .HasColumnType("integer");

                    b.Property<int>("SubscriptionId")
                        .HasColumnType("integer");

                    b.Property<int>("SubscriptionServiceId")
                        .HasColumnType("integer");

                    b.Property<int>("SubscriptionServiceSecurityOrganizationId")
                        .HasColumnType("integer");

                    b.Property<int>("SubscriptionCustomerId")
                        .HasColumnType("integer");

                    b.Property<string>("Event_Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<string>("Priority")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Time_call")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("EventsId", "SubscriptionId", "SubscriptionServiceId", "SubscriptionServiceSecurityOrganizationId", "SubscriptionCustomerId");

                    b.HasIndex("EventsId")
                        .IsUnique();

                    b.HasIndex("SubscriptionId", "SubscriptionServiceId", "SubscriptionServiceSecurityOrganizationId", "SubscriptionCustomerId");

                    b.ToTable("Events");
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
                    b.Property<int>("ServiceId")
                        .HasColumnType("integer");

                    b.Property<int>("SecurityOrganizationId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Price")
                        .HasColumnType("integer");

                    b.HasKey("ServiceId", "SecurityOrganizationId");

                    b.HasIndex("SecurityOrganizationId");

                    b.HasIndex("ServiceId")
                        .IsUnique();

                    b.ToTable("Service");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CityId")
                        .HasColumnType("integer");

                    b.Property<int>("CountPeople")
                        .HasColumnType("integer");

                    b.Property<string>("NameCommand")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("StaffId");

                    b.HasIndex("CityId");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.Subscription", b =>
                {
                    b.Property<int>("SubscriptionId")
                        .HasColumnType("integer");

                    b.Property<int>("ServiceId")
                        .HasColumnType("integer");

                    b.Property<int>("ServiceSecurityOrganizationId")
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
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("SubscriptionId", "ServiceId", "ServiceSecurityOrganizationId", "CustomerId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ServiceId", "ServiceSecurityOrganizationId");

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

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.DeparutureInfo", b =>
                {
                    b.HasOne("SecurityOrgPrj.Data.Models.Staff", null)
                        .WithMany("DeparutureInfo")
                        .HasForeignKey("StaffId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SecurityOrgPrj.Data.Models.Events", "Events")
                        .WithMany("DeparutureInfo")
                        .HasForeignKey("EventsId", "EventsSubscriptionId", "EventsSubscriptionServiceId", "EventsSubscriptionServiceSecurityOrganizationId", "EventsSubscriptionCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Events");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.Events", b =>
                {
                    b.HasOne("SecurityOrgPrj.Data.Models.Subscription", "Subscription")
                        .WithMany("Events")
                        .HasForeignKey("SubscriptionId", "SubscriptionServiceId", "SubscriptionServiceSecurityOrganizationId", "SubscriptionCustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subscription");
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

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.Staff", b =>
                {
                    b.HasOne("SecurityOrgPrj.Data.Models.City", null)
                        .WithMany("Staff")
                        .HasForeignKey("CityId");
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

                    b.Navigation("Staff");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.Customer", b =>
                {
                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.Events", b =>
                {
                    b.Navigation("DeparutureInfo");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.SecurityOrganization", b =>
                {
                    b.Navigation("Service");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.Service", b =>
                {
                    b.Navigation("Subscription");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.Staff", b =>
                {
                    b.Navigation("DeparutureInfo");
                });

            modelBuilder.Entity("SecurityOrgPrj.Data.Models.Subscription", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("SecurityOrgPrj.Models.Countries", b =>
                {
                    b.Navigation("City");
                });
#pragma warning restore 612, 618
        }
    }
}
