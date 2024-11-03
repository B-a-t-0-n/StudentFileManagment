﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentFileManagement.Infrastructure;

#nullable disable

namespace StudentFileManagment.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241103173045_AddData")]
    partial class AddData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("StudentFileManagement.Domain.Education", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Educations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("57f7873d-c03a-406f-8735-f08cb88f97a8"),
                            Name = "СПО"
                        },
                        new
                        {
                            Id = new Guid("055bf038-e980-46ea-b362-bfc01fc69328"),
                            Name = "Бакалавриат"
                        },
                        new
                        {
                            Id = new Guid("1601ecaf-8311-46e8-970d-b62ddec1a509"),
                            Name = "Магистратура"
                        });
                });

            modelBuilder.Entity("StudentFileManagement.Domain.EducationDirection", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("InstitutionAndEducationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberCources")
                        .HasColumnType("int");

                    b.Property<int>("NumberSemesters")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("InstitutionAndEducationId");

                    b.ToTable("EducationDirections");

                    b.HasData(
                        new
                        {
                            Id = new Guid("8c119a64-99c0-4f4d-9968-022aac2b1a08"),
                            InstitutionAndEducationId = new Guid("02bed09e-c6d9-47e5-83db-d5d60a9dab17"),
                            Name = "Информационные системы и программирование",
                            NumberCources = 4,
                            NumberSemesters = 2
                        },
                        new
                        {
                            Id = new Guid("852261d7-f37d-4cf8-8de5-8f07cb00df26"),
                            InstitutionAndEducationId = new Guid("760c6066-229e-4aa6-a667-6dab5e606df3"),
                            Name = "Информационные системы и программирование",
                            NumberCources = 4,
                            NumberSemesters = 2
                        },
                        new
                        {
                            Id = new Guid("ee28610f-662f-4a80-b95c-b942526bebe3"),
                            InstitutionAndEducationId = new Guid("39fa224f-f625-45bd-b37d-a9a3c1fa9ab9"),
                            Name = "Информационные системы и программирование",
                            NumberCources = 4,
                            NumberSemesters = 2
                        });
                });

            modelBuilder.Entity("StudentFileManagement.Domain.File", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LectureFilesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LectureFilesId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.Institution", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Institutions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ad878326-82bb-4d9b-8e56-c286740e2fad"),
                            Name = "ВГЛТУ"
                        });
                });

            modelBuilder.Entity("StudentFileManagement.Domain.InstitutionAndEducation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DirectionsId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EducationId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("InstitutionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EducationId");

                    b.HasIndex("InstitutionId");

                    b.ToTable("InstitutionAndEducations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("02bed09e-c6d9-47e5-83db-d5d60a9dab17"),
                            DirectionsId = new Guid("00000000-0000-0000-0000-000000000000"),
                            EducationId = new Guid("57f7873d-c03a-406f-8735-f08cb88f97a8"),
                            InstitutionId = new Guid("ad878326-82bb-4d9b-8e56-c286740e2fad")
                        },
                        new
                        {
                            Id = new Guid("760c6066-229e-4aa6-a667-6dab5e606df3"),
                            DirectionsId = new Guid("00000000-0000-0000-0000-000000000000"),
                            EducationId = new Guid("055bf038-e980-46ea-b362-bfc01fc69328"),
                            InstitutionId = new Guid("ad878326-82bb-4d9b-8e56-c286740e2fad")
                        },
                        new
                        {
                            Id = new Guid("39fa224f-f625-45bd-b37d-a9a3c1fa9ab9"),
                            DirectionsId = new Guid("00000000-0000-0000-0000-000000000000"),
                            EducationId = new Guid("1601ecaf-8311-46e8-970d-b62ddec1a509"),
                            InstitutionId = new Guid("ad878326-82bb-4d9b-8e56-c286740e2fad")
                        });
                });

            modelBuilder.Entity("StudentFileManagement.Domain.Lecture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.LectureFiles", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("LectureId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LectureId");

                    b.HasIndex("UserId");

                    b.ToTable("LectureFiles");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Cource")
                        .HasColumnType("int");

                    b.Property<Guid>("EducationDirectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Semester")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EducationDirectionId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c6bd1b19-ea3b-4106-b064-261986686631"),
                            Cource = 2,
                            EducationDirectionId = new Guid("8c119a64-99c0-4f4d-9968-022aac2b1a08"),
                            Name = "Проектирование и дизайн информационных систем",
                            Semester = 1
                        });
                });

            modelBuilder.Entity("StudentFileManagement.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("ChatId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<bool>("IsModerator")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nickname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.EducationDirection", b =>
                {
                    b.HasOne("StudentFileManagement.Domain.InstitutionAndEducation", "InstitutionAndEducation")
                        .WithMany("Directions")
                        .HasForeignKey("InstitutionAndEducationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("InstitutionAndEducation");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.File", b =>
                {
                    b.HasOne("StudentFileManagement.Domain.LectureFiles", "LectureFiles")
                        .WithMany("File")
                        .HasForeignKey("LectureFilesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LectureFiles");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.InstitutionAndEducation", b =>
                {
                    b.HasOne("StudentFileManagement.Domain.Education", "Education")
                        .WithMany("InstitutionAndEducation")
                        .HasForeignKey("EducationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentFileManagement.Domain.Institution", "Institution")
                        .WithMany("InstitutionAndEducation")
                        .HasForeignKey("InstitutionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Education");

                    b.Navigation("Institution");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.Lecture", b =>
                {
                    b.HasOne("StudentFileManagement.Domain.Subject", "Subject")
                        .WithMany("Lectures")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.LectureFiles", b =>
                {
                    b.HasOne("StudentFileManagement.Domain.Lecture", "Lecture")
                        .WithMany("Files")
                        .HasForeignKey("LectureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("StudentFileManagement.Domain.User", "User")
                        .WithMany("LectureFiles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lecture");

                    b.Navigation("User");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.Subject", b =>
                {
                    b.HasOne("StudentFileManagement.Domain.EducationDirection", "EducationDirection")
                        .WithMany("Subjects")
                        .HasForeignKey("EducationDirectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EducationDirection");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.Education", b =>
                {
                    b.Navigation("InstitutionAndEducation");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.EducationDirection", b =>
                {
                    b.Navigation("Subjects");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.Institution", b =>
                {
                    b.Navigation("InstitutionAndEducation");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.InstitutionAndEducation", b =>
                {
                    b.Navigation("Directions");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.Lecture", b =>
                {
                    b.Navigation("Files");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.LectureFiles", b =>
                {
                    b.Navigation("File");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.Subject", b =>
                {
                    b.Navigation("Lectures");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.User", b =>
                {
                    b.Navigation("LectureFiles");
                });
#pragma warning restore 612, 618
        }
    }
}