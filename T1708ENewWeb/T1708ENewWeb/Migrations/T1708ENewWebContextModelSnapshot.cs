﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using T1708ENewWeb.Models;

namespace T1708ENewWeb.Migrations
{
    [DbContext(typeof(T1708ENewWebContext))]
    partial class T1708ENewWebContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("SubjectMark");

                    b.Property<string>("SubjectName");

                    b.HasKey("Id");

                    b.HasIndex("StudentRollNumber");

                    b.ToTable("Mark");

                    b.HasData(
                        new { Id = 1, StudentRollNumber = "A002768", SubjectMark = 20, SubjectName = "Java" },
                        new { Id = 2, StudentRollNumber = "A002768", SubjectMark = 23, SubjectName = "C#" },
                        new { Id = 3, StudentRollNumber = "A002768", SubjectMark = 22, SubjectName = "PHP" },
                        new { Id = 4, StudentRollNumber = "A002778", SubjectMark = 25, SubjectName = "HTML" },
                        new { Id = 5, StudentRollNumber = "A002778", SubjectMark = 22, SubjectName = "Javascript" }
                    );
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

                    b.HasData(
                        new { RollNumber = "A002768", CreatedAt = new DateTime(2018, 11, 6, 18, 27, 43, 536, DateTimeKind.Local), Email = "xuanhung@gmail.com", FirstName = "Hung", Status = 1, UpdatedAt = new DateTime(2018, 11, 6, 18, 27, 43, 536, DateTimeKind.Local) },
                        new { RollNumber = "A002778", CreatedAt = new DateTime(2018, 11, 6, 18, 27, 43, 536, DateTimeKind.Local), Email = "luyen@gmail.com", FirstName = "Luyen", Status = 1, UpdatedAt = new DateTime(2018, 11, 6, 18, 27, 43, 536, DateTimeKind.Local) },
                        new { RollNumber = "A002769", CreatedAt = new DateTime(2018, 11, 6, 18, 27, 43, 536, DateTimeKind.Local), Email = "hong@gmail.com", FirstName = "Hong", Status = 1, UpdatedAt = new DateTime(2018, 11, 6, 18, 27, 43, 536, DateTimeKind.Local) }
                    );
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
