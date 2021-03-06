﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OMAF.Data;

namespace OMAF.Migrations
{
    [DbContext(typeof(OmafContext))]
    [Migration("20200415235506_MxCtrlNotes")]
    partial class MxCtrlNotes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OMAF.Models.Aircraft", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Buno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ComplDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CorrAction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discrepancy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InitiateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Initiator")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inspector")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("IwDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("JobStat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MxCtrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MxCtrlNotes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SysReason")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UDP")
                        .HasColumnType("int");

                    b.Property<string>("Worker")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Aircraft");
                });
#pragma warning restore 612, 618
        }
    }
}
