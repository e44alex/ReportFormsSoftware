﻿// <auto-generated />
using System;
using Diplom.Shared.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorApp1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201116092627_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Diplom.Shared.Model.Organisation", b =>
                {
                    b.Property<int>("UNK")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HigherOrgUNK")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Principal")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UNK");

                    b.HasIndex("HigherOrgUNK");

                    b.ToTable("Organisations");
                });

            modelBuilder.Entity("Diplom.Shared.Model.ReportForm", b =>
                {
                    b.Property<Guid>("FormHeadId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("FormDataId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("FormDataFormHeadId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("FormDataOrganisationId")
                        .HasColumnType("int");

                    b.Property<Guid?>("FormDataReportPeriodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FormDataRowCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("FormHeadId", "FormDataId");

                    b.HasIndex("FormDataFormHeadId", "FormDataOrganisationId", "FormDataRowCode", "FormDataReportPeriodId");

                    b.ToTable("ReportForms");
                });

            modelBuilder.Entity("Diplom.Shared.Model.ReportFormData", b =>
                {
                    b.Property<Guid>("FormHeadId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("OrganisationId")
                        .HasColumnType("int");

                    b.Property<string>("RowCode")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("ReportPeriodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("C1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C11")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C16")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C17")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C18")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C19")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C20")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C21")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C22")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("C9")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FormHeadId", "OrganisationId", "RowCode", "ReportPeriodId");

                    b.HasIndex("OrganisationId");

                    b.HasIndex("ReportPeriodId");

                    b.ToTable("ReportFormDatas");
                });

            modelBuilder.Entity("Diplom.Shared.Model.ReportFormHead", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Chapter")
                        .HasColumnType("int");

                    b.Property<int>("Cls")
                        .HasColumnType("int");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<int>("Paragraph")
                        .HasColumnType("int");

                    b.Property<int>("PeriodicType")
                        .HasColumnType("int");

                    b.Property<int>("Program")
                        .HasColumnType("int");

                    b.Property<int>("SubPragraph")
                        .HasColumnType("int");

                    b.Property<int>("SubProgram")
                        .HasColumnType("int");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ReportFormHeads");
                });

            modelBuilder.Entity("Diplom.Shared.Model.ReportPeriod", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ReportPeriods");
                });

            modelBuilder.Entity("Diplom.Shared.Model.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrganisationUNK")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patronym")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Username");

                    b.HasIndex("OrganisationUNK");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Diplom.Shared.Model.Organisation", b =>
                {
                    b.HasOne("Diplom.Shared.Model.Organisation", "HigherOrg")
                        .WithMany()
                        .HasForeignKey("HigherOrgUNK");

                    b.Navigation("HigherOrg");
                });

            modelBuilder.Entity("Diplom.Shared.Model.ReportForm", b =>
                {
                    b.HasOne("Diplom.Shared.Model.ReportFormHead", "FormHead")
                        .WithMany()
                        .HasForeignKey("FormHeadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Diplom.Shared.Model.ReportFormData", "FormData")
                        .WithMany()
                        .HasForeignKey("FormDataFormHeadId", "FormDataOrganisationId", "FormDataRowCode", "FormDataReportPeriodId");

                    b.Navigation("FormData");

                    b.Navigation("FormHead");
                });

            modelBuilder.Entity("Diplom.Shared.Model.ReportFormData", b =>
                {
                    b.HasOne("Diplom.Shared.Model.ReportFormHead", "FormHead")
                        .WithMany()
                        .HasForeignKey("FormHeadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Diplom.Shared.Model.Organisation", "Organisation")
                        .WithMany()
                        .HasForeignKey("OrganisationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Diplom.Shared.Model.ReportPeriod", "ReportPeriod")
                        .WithMany()
                        .HasForeignKey("ReportPeriodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FormHead");

                    b.Navigation("Organisation");

                    b.Navigation("ReportPeriod");
                });

            modelBuilder.Entity("Diplom.Shared.Model.User", b =>
                {
                    b.HasOne("Diplom.Shared.Model.Organisation", "Organisation")
                        .WithMany()
                        .HasForeignKey("OrganisationUNK");

                    b.Navigation("Organisation");
                });
#pragma warning restore 612, 618
        }
    }
}
