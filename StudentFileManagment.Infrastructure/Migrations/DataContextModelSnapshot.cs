﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using StudentFileManagement.Infrastructure;

#nullable disable

namespace StudentFileManagment.Infrastructure.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("4dbe7c6e-2218-4071-8837-699ff20baa24"),
                            Name = "СПО"
                        },
                        new
                        {
                            Id = new Guid("72614a3a-cfff-4c26-abce-f43d2f1bc325"),
                            Name = "Бакалавриат"
                        },
                        new
                        {
                            Id = new Guid("23f6c36e-1a2a-4d3f-aa41-d1689d7f78e1"),
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
                            Id = new Guid("4d11b3ee-b8b3-44e5-b40d-613c0a7c4104"),
                            InstitutionAndEducationId = new Guid("3e9372df-7319-4924-83a1-20b1d1b8e848"),
                            Name = "Информационные системы и программирование"
                        },
                        new
                        {
                            Id = new Guid("9e21bea4-5d74-4d10-8fcf-09d1ddcbc5c7"),
                            InstitutionAndEducationId = new Guid("f3b52d23-9ad0-41f5-ab38-82e40ada6299"),
                            Name = "Информационные системы и программирование"
                        },
                        new
                        {
                            Id = new Guid("444a4b16-9a48-4a8a-a873-8401e59d7506"),
                            InstitutionAndEducationId = new Guid("0f809a18-b7bf-49a1-b1f2-5d67e9d04448"),
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
                            Id = new Guid("cc377952-3d95-4dab-9207-5a926887f1e5"),
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
                            Id = new Guid("3e9372df-7319-4924-83a1-20b1d1b8e848"),
                            EducationId = new Guid("4dbe7c6e-2218-4071-8837-699ff20baa24"),
                            InstitutionId = new Guid("cc377952-3d95-4dab-9207-5a926887f1e5")
                        },
                        new
                        {
                            Id = new Guid("f3b52d23-9ad0-41f5-ab38-82e40ada6299"),
                            EducationId = new Guid("72614a3a-cfff-4c26-abce-f43d2f1bc325"),
                            InstitutionId = new Guid("cc377952-3d95-4dab-9207-5a926887f1e5")
                        },
                        new
                        {
                            Id = new Guid("0f809a18-b7bf-49a1-b1f2-5d67e9d04448"),
                            EducationId = new Guid("23f6c36e-1a2a-4d3f-aa41-d1689d7f78e1"),
                            InstitutionId = new Guid("cc377952-3d95-4dab-9207-5a926887f1e5")
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
                            Id = new Guid("41be0b93-8931-42bb-97d3-57b3f7f7ccd5"),
                            Name = "Проектирование и дизайн информационных систем",
                            SemesterId = new Guid("8e0022cb-dd42-4ba3-b5b5-c443858a5ca1")
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
                            Id = new Guid("6f70ddcd-b437-4f07-b32b-f551aaac2927"),
                            EducationDirectionId = new Guid("4d11b3ee-b8b3-44e5-b40d-613c0a7c4104"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("b5c91b0c-503d-48f8-8290-947ef9c452e3"),
                            EducationDirectionId = new Guid("4d11b3ee-b8b3-44e5-b40d-613c0a7c4104"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("3295510f-0a3c-4dfa-8479-27bbe7b157a4"),
                            EducationDirectionId = new Guid("4d11b3ee-b8b3-44e5-b40d-613c0a7c4104"),
                            Number = 3
                        },
                        new
                        {
                            Id = new Guid("da924a5c-cdd3-4c10-907a-42702fe5871f"),
                            EducationDirectionId = new Guid("4d11b3ee-b8b3-44e5-b40d-613c0a7c4104"),
                            Number = 4
                        },
                        new
                        {
                            Id = new Guid("088148d0-a45f-4877-b2f2-5c66399ae558"),
                            EducationDirectionId = new Guid("9e21bea4-5d74-4d10-8fcf-09d1ddcbc5c7"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("d2c5e3c5-a0be-47f2-92c6-4c6f5542898d"),
                            EducationDirectionId = new Guid("9e21bea4-5d74-4d10-8fcf-09d1ddcbc5c7"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("e6ec4ce3-3d0f-46dd-bd71-897c87dba9f4"),
                            EducationDirectionId = new Guid("9e21bea4-5d74-4d10-8fcf-09d1ddcbc5c7"),
                            Number = 3
                        },
                        new
                        {
                            Id = new Guid("099d014f-82d6-458c-ab3c-5779ad024951"),
                            EducationDirectionId = new Guid("9e21bea4-5d74-4d10-8fcf-09d1ddcbc5c7"),
                            Number = 4
                        },
                        new
                        {
                            Id = new Guid("0e3754c9-98df-40a2-9dfa-cd18c5cf3d46"),
                            EducationDirectionId = new Guid("444a4b16-9a48-4a8a-a873-8401e59d7506"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("0b5d8431-3ada-4071-8a26-d95c1d97b504"),
                            EducationDirectionId = new Guid("444a4b16-9a48-4a8a-a873-8401e59d7506"),
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
                            Id = new Guid("13786a7f-9a8b-40d5-b45e-0eedd876c18e"),
                            CourceId = new Guid("6f70ddcd-b437-4f07-b32b-f551aaac2927"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("3553d855-5dc5-4b03-98f2-94759f9c7976"),
                            CourceId = new Guid("6f70ddcd-b437-4f07-b32b-f551aaac2927"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("8e0022cb-dd42-4ba3-b5b5-c443858a5ca1"),
                            CourceId = new Guid("b5c91b0c-503d-48f8-8290-947ef9c452e3"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("0e53e69e-d2b3-43e2-b591-cdf8ca2a136e"),
                            CourceId = new Guid("b5c91b0c-503d-48f8-8290-947ef9c452e3"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("114af4ca-0b38-4beb-9fc8-9fa9087a943d"),
                            CourceId = new Guid("3295510f-0a3c-4dfa-8479-27bbe7b157a4"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("58c78b85-fd9b-4087-be9a-f0ee40d89cae"),
                            CourceId = new Guid("3295510f-0a3c-4dfa-8479-27bbe7b157a4"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("e6cfff90-e435-4d07-8af7-36c531cc0db1"),
                            CourceId = new Guid("da924a5c-cdd3-4c10-907a-42702fe5871f"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("efb4cb12-3e9b-4409-97d7-87dfe93a4b97"),
                            CourceId = new Guid("da924a5c-cdd3-4c10-907a-42702fe5871f"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("06c31dd8-0e86-450e-b237-2ae00de9653f"),
                            CourceId = new Guid("088148d0-a45f-4877-b2f2-5c66399ae558"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("2947dc96-6eca-4897-a97f-ea1693811e62"),
                            CourceId = new Guid("088148d0-a45f-4877-b2f2-5c66399ae558"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("e877546e-d6bb-4d31-99cc-60f025c32b92"),
                            CourceId = new Guid("d2c5e3c5-a0be-47f2-92c6-4c6f5542898d"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("429b2e03-b8f9-47b5-87b5-2b36b683d26a"),
                            CourceId = new Guid("d2c5e3c5-a0be-47f2-92c6-4c6f5542898d"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("2f48910a-2d48-44fa-9e45-7a701d6d2ff4"),
                            CourceId = new Guid("e6ec4ce3-3d0f-46dd-bd71-897c87dba9f4"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("3c038712-5460-4080-94fb-3753d9eae46f"),
                            CourceId = new Guid("e6ec4ce3-3d0f-46dd-bd71-897c87dba9f4"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("1f2dc88b-45f1-4fea-80b0-c7ad6f6a97b1"),
                            CourceId = new Guid("099d014f-82d6-458c-ab3c-5779ad024951"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("68db642e-4cb2-4d52-a528-64ab4f684f81"),
                            CourceId = new Guid("099d014f-82d6-458c-ab3c-5779ad024951"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("312ebbf1-dc51-461a-8582-539ddd19a9d4"),
                            CourceId = new Guid("0e3754c9-98df-40a2-9dfa-cd18c5cf3d46"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("27187642-1682-44a3-8ba3-7e8392161360"),
                            CourceId = new Guid("0e3754c9-98df-40a2-9dfa-cd18c5cf3d46"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("2d3dd94f-84c0-4bf8-93ca-1e3be98282a4"),
                            CourceId = new Guid("0b5d8431-3ada-4071-8a26-d95c1d97b504"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("efd4d226-fa1f-4f9c-b128-b00acd4524b7"),
                            CourceId = new Guid("0b5d8431-3ada-4071-8a26-d95c1d97b504"),
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
