﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TARge20.Data;

namespace TARge20.Data.Migrations
{
    [DbContext(typeof(TARge20DbContext))]
    partial class TARge20DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TARge20.Core.Domain.AccessPermit", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("WorkTitleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("WorkTitleId");

                    b.ToTable("AccessPermit");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNR")
                        .HasColumnType("int");

                    b.Property<string>("Register")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("TARge20.Core.Domain.CompanyOffice", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Contact")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNR")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("CompanyOffice");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AccessPermitId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Children")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CompanyOfficeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("HealthCheckId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("IdCode")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("WorkTitleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("AccessPermitId");

                    b.HasIndex("CompanyOfficeId");

                    b.HasIndex("HealthCheckId");

                    b.HasIndex("WorkTitleId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.EmployeeChild", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeChild");
                });

            modelBuilder.Entity("TARge20.Core.Domain.HealthCheck", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("HealthCheck");
                });

            modelBuilder.Entity("TARge20.Core.Domain.LoanItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("LoanListId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LoanListId");

                    b.ToTable("LoanItem");
                });

            modelBuilder.Entity("TARge20.Core.Domain.LoanList", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Interest")
                        .HasColumnType("int");

                    b.Property<string>("Item")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LoanStart")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("LoanList");
                });

            modelBuilder.Entity("TARge20.Core.Domain.SickLeaves", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("SickLeaves");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Vacations", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Vacations");
                });

            modelBuilder.Entity("TARge20.Core.Domain.WorkTitle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TitleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WorkTitle");
                });

            modelBuilder.Entity("TARge20.Core.Domain.AccessPermit", b =>
                {
                    b.HasOne("TARge20.Core.Domain.WorkTitle", "WorkTitle")
                        .WithMany("AccessPermit")
                        .HasForeignKey("WorkTitleId");

                    b.Navigation("WorkTitle");
                });

            modelBuilder.Entity("TARge20.Core.Domain.CompanyOffice", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Company", "Company")
                        .WithMany("CompanyOffice")
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Employee", b =>
                {
                    b.HasOne("TARge20.Core.Domain.AccessPermit", "AccessPermit")
                        .WithMany("Employee")
                        .HasForeignKey("AccessPermitId");

                    b.HasOne("TARge20.Core.Domain.CompanyOffice", "CompanyOffice")
                        .WithMany("Employee")
                        .HasForeignKey("CompanyOfficeId");

                    b.HasOne("TARge20.Core.Domain.HealthCheck", "HealthCheck")
                        .WithMany("Employee")
                        .HasForeignKey("HealthCheckId");

                    b.HasOne("TARge20.Core.Domain.WorkTitle", "WorkTitle")
                        .WithMany("Employee")
                        .HasForeignKey("WorkTitleId");

                    b.Navigation("AccessPermit");

                    b.Navigation("CompanyOffice");

                    b.Navigation("HealthCheck");

                    b.Navigation("WorkTitle");
                });

            modelBuilder.Entity("TARge20.Core.Domain.EmployeeChild", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("EmployeeChild")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.LoanItem", b =>
                {
                    b.HasOne("TARge20.Core.Domain.LoanList", "LoanList")
                        .WithMany("LoanItem")
                        .HasForeignKey("LoanListId");

                    b.Navigation("LoanList");
                });

            modelBuilder.Entity("TARge20.Core.Domain.LoanList", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Company", "Company")
                        .WithMany("LoanList")
                        .HasForeignKey("CompanyId");

                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("LoanList")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Company");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.SickLeaves", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("SickLeaves")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Vacations", b =>
                {
                    b.HasOne("TARge20.Core.Domain.Employee", "Employee")
                        .WithMany("Vacations")
                        .HasForeignKey("EmployeeId");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.AccessPermit", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Company", b =>
                {
                    b.Navigation("CompanyOffice");

                    b.Navigation("LoanList");
                });

            modelBuilder.Entity("TARge20.Core.Domain.CompanyOffice", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.Employee", b =>
                {
                    b.Navigation("EmployeeChild");

                    b.Navigation("LoanList");

                    b.Navigation("SickLeaves");

                    b.Navigation("Vacations");
                });

            modelBuilder.Entity("TARge20.Core.Domain.HealthCheck", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("TARge20.Core.Domain.LoanList", b =>
                {
                    b.Navigation("LoanItem");
                });

            modelBuilder.Entity("TARge20.Core.Domain.WorkTitle", b =>
                {
                    b.Navigation("AccessPermit");

                    b.Navigation("Employee");
                });
#pragma warning restore 612, 618
        }
    }
}
