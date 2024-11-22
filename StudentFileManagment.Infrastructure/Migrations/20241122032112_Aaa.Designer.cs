﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StudentFileManagement.Infrastructure;

#nullable disable

namespace StudentFileManagment.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20241122032112_Aaa")]
    partial class Aaa
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("StudentFileManagement.Domain.Education", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Educations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("12ad0b99-3533-44d2-ba69-af64448fe7fc"),
                            Name = "СПО"
                        },
                        new
                        {
                            Id = new Guid("f8be468f-100b-4aab-93b4-cbf2b182010c"),
                            Name = "Бакалавриат"
                        },
                        new
                        {
                            Id = new Guid("0ca06734-c380-49f0-9494-43f32c554b68"),
                            Name = "Магистратура"
                        });
                });

            modelBuilder.Entity("StudentFileManagement.Domain.EducationDirection", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("InstitutionAndEducationId")
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("InstitutionAndEducationId");

                    b.ToTable("EducationDirections");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0e9ada63-c621-48a2-89d2-df7eb0bfc38d"),
                            InstitutionAndEducationId = new Guid("789f545c-95ba-4aed-9911-84ba308afe61"),
                            Name = "Информационные системы и программирование"
                        },
                        new
                        {
                            Id = new Guid("545c1c90-c6ce-4fda-9e00-a799bb03a321"),
                            InstitutionAndEducationId = new Guid("96e55109-8353-4fc0-bcba-4220d50e1399"),
                            Name = "Информационные системы и программирование"
                        },
                        new
                        {
                            Id = new Guid("99c3f27c-cc25-48f5-adb5-944762dbac9d"),
                            InstitutionAndEducationId = new Guid("0947239c-7486-4a29-9169-fa108fc4d6f5"),
                            Name = "Информационные системы и программирование"
                        });
                });

            modelBuilder.Entity("StudentFileManagement.Domain.File", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("LectureDataId")
                        .HasColumnType("uuid");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("LectureDataId");

                    b.ToTable("Files");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.Institution", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Institutions");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ef222af5-1e5e-48e0-9c30-23e448437b61"),
                            Name = "ВГЛТУ"
                        });
                });

            modelBuilder.Entity("StudentFileManagement.Domain.InstitutionAndEducation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("EducationId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("InstitutionId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("EducationId");

                    b.HasIndex("InstitutionId");

                    b.ToTable("InstitutionAndEducations");

                    b.HasData(
                        new
                        {
                            Id = new Guid("789f545c-95ba-4aed-9911-84ba308afe61"),
                            EducationId = new Guid("12ad0b99-3533-44d2-ba69-af64448fe7fc"),
                            InstitutionId = new Guid("ef222af5-1e5e-48e0-9c30-23e448437b61")
                        },
                        new
                        {
                            Id = new Guid("96e55109-8353-4fc0-bcba-4220d50e1399"),
                            EducationId = new Guid("f8be468f-100b-4aab-93b4-cbf2b182010c"),
                            InstitutionId = new Guid("ef222af5-1e5e-48e0-9c30-23e448437b61")
                        },
                        new
                        {
                            Id = new Guid("0947239c-7486-4a29-9169-fa108fc4d6f5"),
                            EducationId = new Guid("0ca06734-c380-49f0-9494-43f32c554b68"),
                            InstitutionId = new Guid("ef222af5-1e5e-48e0-9c30-23e448437b61")
                        });
                });

            modelBuilder.Entity("StudentFileManagement.Domain.Lecture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("Date")
                        .HasColumnType("date");

                    b.Property<Guid>("SubjectId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Lectures");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.LectureData", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<Guid>("LectureId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("LectureId");

                    b.HasIndex("UserId");

                    b.ToTable("LecturesData");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.Subject", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("SemesterId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SemesterId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f3d765f0-d04f-4ad7-be1f-7fcac9d1e2b4"),
                            Name = "Проектирование и дизайн информационных систем",
                            SemesterId = new Guid("0d4030d5-dd4f-46d9-983c-1f7b2c66533b")
                        });
                });

            modelBuilder.Entity("StudentFileManagement.Domain.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<long>("ChatId")
                        .HasColumnType("bigint");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsModerator")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Nickname")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("StudentFileManagment.Domain.Cource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("EducationDirectionId")
                        .HasColumnType("uuid");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("EducationDirectionId");

                    b.ToTable("Cources");

                    b.HasData(
                        new
                        {
                            Id = new Guid("019e8657-782f-4ed6-9022-2c7d3fba9f61"),
                            EducationDirectionId = new Guid("0e9ada63-c621-48a2-89d2-df7eb0bfc38d"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("4990bf26-a836-406b-96eb-7b1da4f6acd0"),
                            EducationDirectionId = new Guid("0e9ada63-c621-48a2-89d2-df7eb0bfc38d"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("d385d4ca-7033-45d2-90c7-bc818732ba26"),
                            EducationDirectionId = new Guid("0e9ada63-c621-48a2-89d2-df7eb0bfc38d"),
                            Number = 3
                        },
                        new
                        {
                            Id = new Guid("e327543f-40b0-4cd6-9500-98e7e0d64170"),
                            EducationDirectionId = new Guid("0e9ada63-c621-48a2-89d2-df7eb0bfc38d"),
                            Number = 4
                        },
                        new
                        {
                            Id = new Guid("c0b5c432-9272-43ce-b929-479a73c8378a"),
                            EducationDirectionId = new Guid("545c1c90-c6ce-4fda-9e00-a799bb03a321"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("2008622c-d216-46f2-9ba8-85818c58830c"),
                            EducationDirectionId = new Guid("545c1c90-c6ce-4fda-9e00-a799bb03a321"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("da81cc99-4753-4f69-9a12-f338cee686e8"),
                            EducationDirectionId = new Guid("545c1c90-c6ce-4fda-9e00-a799bb03a321"),
                            Number = 3
                        },
                        new
                        {
                            Id = new Guid("b3279ac9-325e-4f06-9705-fe7300fd9c00"),
                            EducationDirectionId = new Guid("545c1c90-c6ce-4fda-9e00-a799bb03a321"),
                            Number = 4
                        },
                        new
                        {
                            Id = new Guid("dee18e93-10e5-49bb-82fb-2bcdeb19b436"),
                            EducationDirectionId = new Guid("99c3f27c-cc25-48f5-adb5-944762dbac9d"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("0446d67d-2e72-4a36-996d-f3b394267566"),
                            EducationDirectionId = new Guid("99c3f27c-cc25-48f5-adb5-944762dbac9d"),
                            Number = 2
                        });
                });

            modelBuilder.Entity("StudentFileManagment.Domain.Semester", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CourceId")
                        .HasColumnType("uuid");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CourceId");

                    b.ToTable("Semesters");

                    b.HasData(
                        new
                        {
                            Id = new Guid("7a3cc152-0027-4753-a0ae-dc561992d484"),
                            CourceId = new Guid("019e8657-782f-4ed6-9022-2c7d3fba9f61"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("94ccf727-0fc5-48f9-8f1c-4f1f594efc7e"),
                            CourceId = new Guid("019e8657-782f-4ed6-9022-2c7d3fba9f61"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("0d4030d5-dd4f-46d9-983c-1f7b2c66533b"),
                            CourceId = new Guid("4990bf26-a836-406b-96eb-7b1da4f6acd0"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("cac7fee5-cb3c-4a4b-bd07-d1d0f819c98a"),
                            CourceId = new Guid("4990bf26-a836-406b-96eb-7b1da4f6acd0"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("59dfc402-039d-4fc8-91d1-59ccf0cc62cd"),
                            CourceId = new Guid("d385d4ca-7033-45d2-90c7-bc818732ba26"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("1e605be8-0c89-4ee2-93c3-8da83478d80c"),
                            CourceId = new Guid("d385d4ca-7033-45d2-90c7-bc818732ba26"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("e9916923-abd8-4cba-b0b3-3e2e9b160bca"),
                            CourceId = new Guid("e327543f-40b0-4cd6-9500-98e7e0d64170"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("53b228dc-8094-41f4-a793-372b350a4d1f"),
                            CourceId = new Guid("e327543f-40b0-4cd6-9500-98e7e0d64170"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("de775b18-1457-4907-a6fe-c675bcecf68e"),
                            CourceId = new Guid("c0b5c432-9272-43ce-b929-479a73c8378a"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("215690c2-b086-46ee-8f04-de954581c69d"),
                            CourceId = new Guid("c0b5c432-9272-43ce-b929-479a73c8378a"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("18fff53b-4b99-4e1d-a77f-327a00303d98"),
                            CourceId = new Guid("2008622c-d216-46f2-9ba8-85818c58830c"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("2e6bb430-bf2b-420e-8d85-e33c973e9525"),
                            CourceId = new Guid("2008622c-d216-46f2-9ba8-85818c58830c"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("12ca5c70-019a-4e77-bdb4-24b2a2261259"),
                            CourceId = new Guid("da81cc99-4753-4f69-9a12-f338cee686e8"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("2e5e31c6-2706-4d2d-ad3b-5d4bb49901a1"),
                            CourceId = new Guid("da81cc99-4753-4f69-9a12-f338cee686e8"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("92a78185-7f5a-440d-950a-f7c13f4e746f"),
                            CourceId = new Guid("b3279ac9-325e-4f06-9705-fe7300fd9c00"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("f42d1acf-bc2a-48c3-b9f3-55e3915e3053"),
                            CourceId = new Guid("b3279ac9-325e-4f06-9705-fe7300fd9c00"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("ae9c04fd-13c7-4142-a437-e7c41876e722"),
                            CourceId = new Guid("dee18e93-10e5-49bb-82fb-2bcdeb19b436"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("a5e2d638-c0e4-4f5a-ae61-ade72dcb045b"),
                            CourceId = new Guid("dee18e93-10e5-49bb-82fb-2bcdeb19b436"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("2172952f-8ffd-48fc-84f4-778fac80f0c4"),
                            CourceId = new Guid("0446d67d-2e72-4a36-996d-f3b394267566"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("bca8cbcb-5487-47bb-96ef-43d521ae4294"),
                            CourceId = new Guid("0446d67d-2e72-4a36-996d-f3b394267566"),
                            Number = 2
                        });
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
                    b.HasOne("StudentFileManagement.Domain.LectureData", "LectureData")
                        .WithMany("File")
                        .HasForeignKey("LectureDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LectureData");
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

            modelBuilder.Entity("StudentFileManagement.Domain.LectureData", b =>
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
                    b.HasOne("StudentFileManagment.Domain.Semester", "Semester")
                        .WithMany("Subjects")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Semester");
                });

            modelBuilder.Entity("StudentFileManagment.Domain.Cource", b =>
                {
                    b.HasOne("StudentFileManagement.Domain.EducationDirection", "EducationDirection")
                        .WithMany("Cources")
                        .HasForeignKey("EducationDirectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EducationDirection");
                });

            modelBuilder.Entity("StudentFileManagment.Domain.Semester", b =>
                {
                    b.HasOne("StudentFileManagment.Domain.Cource", "Cource")
                        .WithMany("Semesters")
                        .HasForeignKey("CourceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cource");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.Education", b =>
                {
                    b.Navigation("InstitutionAndEducation");
                });

            modelBuilder.Entity("StudentFileManagement.Domain.EducationDirection", b =>
                {
                    b.Navigation("Cources");
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

            modelBuilder.Entity("StudentFileManagement.Domain.LectureData", b =>
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

            modelBuilder.Entity("StudentFileManagment.Domain.Cource", b =>
                {
                    b.Navigation("Semesters");
                });

            modelBuilder.Entity("StudentFileManagment.Domain.Semester", b =>
                {
                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
