﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using T1708ENewWeb.Models;

namespace T1708ENewWeb.Migrations
{
    [DbContext(typeof(T1708ENewWebContext))]
    [Migration("20181106111906_AddRelationship")]
    partial class AddRelationship
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("T1708ENewWeb.Models.Mark", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StudentRollNumber");

                    b.Property<string>("SubjectName");

                    b.HasKey("Id");

                    b.HasIndex("StudentRollNumber");

                    b.ToTable("Mark");
                });

            modelBuilder.Entity("T1708ENewWeb.Models.Student", b =>
                {
                    b.Property<string>("RollNumber")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<int>("Status");

                    b.Property<DateTime>("UpdatedAt");

                    b.HasKey("RollNumber");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("T1708ENewWeb.Models.Mark", b =>
                {
                    b.HasOne("T1708ENewWeb.Models.Student", "Student")
                        .WithMany("Marks")
                        .HasForeignKey("StudentRollNumber");
                });
#pragma warning restore 612, 618
        }
    }
}