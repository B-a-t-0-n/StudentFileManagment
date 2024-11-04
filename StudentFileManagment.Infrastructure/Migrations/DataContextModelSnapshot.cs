﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
                            Id = new Guid("d01241ad-e80b-4bfd-9473-020f6710c48c"),
                            Name = "СПО"
                        },
                        new
                        {
                            Id = new Guid("c7616c99-233d-4ac8-ac42-7a1e317a8d2d"),
                            Name = "Бакалавриат"
                        },
                        new
                        {
                            Id = new Guid("05abe942-b603-4dab-9f8b-99b7c13c23ac"),
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

                    b.HasKey("Id");

                    b.HasIndex("InstitutionAndEducationId");

                    b.ToTable("EducationDirections");

                    b.HasData(
                        new
                        {
                            Id = new Guid("c37058ac-5dd7-41b3-9cf9-5572d734a64b"),
                            InstitutionAndEducationId = new Guid("1d9d1b7a-9e03-4c27-abae-4914e183ed54"),
                            Name = "Информационные системы и программирование"
                        },
                        new
                        {
                            Id = new Guid("cea6189b-558a-43e5-9e5e-306186795de6"),
                            InstitutionAndEducationId = new Guid("caf7cffa-c435-4034-a286-1dbb26d5ff32"),
                            Name = "Информационные системы и программирование"
                        },
                        new
                        {
                            Id = new Guid("3613288f-3b03-4d40-bc83-3e0a05755896"),
                            InstitutionAndEducationId = new Guid("58255230-8f22-41a7-8dce-f03c0933d610"),
                            Name = "Информационные системы и программирование"
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
                            Id = new Guid("66fdf08d-10d9-42c2-a8cf-02a0a06505da"),
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
                            Id = new Guid("1d9d1b7a-9e03-4c27-abae-4914e183ed54"),
                            DirectionsId = new Guid("00000000-0000-0000-0000-000000000000"),
                            EducationId = new Guid("d01241ad-e80b-4bfd-9473-020f6710c48c"),
                            InstitutionId = new Guid("66fdf08d-10d9-42c2-a8cf-02a0a06505da")
                        },
                        new
                        {
                            Id = new Guid("caf7cffa-c435-4034-a286-1dbb26d5ff32"),
                            DirectionsId = new Guid("00000000-0000-0000-0000-000000000000"),
                            EducationId = new Guid("c7616c99-233d-4ac8-ac42-7a1e317a8d2d"),
                            InstitutionId = new Guid("66fdf08d-10d9-42c2-a8cf-02a0a06505da")
                        },
                        new
                        {
                            Id = new Guid("58255230-8f22-41a7-8dce-f03c0933d610"),
                            DirectionsId = new Guid("00000000-0000-0000-0000-000000000000"),
                            EducationId = new Guid("05abe942-b603-4dab-9f8b-99b7c13c23ac"),
                            InstitutionId = new Guid("66fdf08d-10d9-42c2-a8cf-02a0a06505da")
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

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SemesterId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("SemesterId");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1f122923-d1f1-4434-adb3-a1f3e743f46e"),
                            Name = "Проектирование и дизайн информационных систем",
                            SemesterId = new Guid("64ae2b2a-e220-450f-8848-3a6a86a9d84c")
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

            modelBuilder.Entity("StudentFileManagment.Domain.Cource", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EducationDirectionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EducationDirectionId");

                    b.ToTable("Cources");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9d399f47-e840-40d9-a159-6e2e6bbcbed3"),
                            EducationDirectionId = new Guid("c37058ac-5dd7-41b3-9cf9-5572d734a64b"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("3b98ae3d-02b2-4812-9a08-ad940a33da15"),
                            EducationDirectionId = new Guid("c37058ac-5dd7-41b3-9cf9-5572d734a64b"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("5b66dbc6-691a-4d66-bed4-a8d39ec2a4a2"),
                            EducationDirectionId = new Guid("c37058ac-5dd7-41b3-9cf9-5572d734a64b"),
                            Number = 3
                        },
                        new
                        {
                            Id = new Guid("8d5f8c4d-ea0f-4ba0-97df-2ea97e45950b"),
                            EducationDirectionId = new Guid("c37058ac-5dd7-41b3-9cf9-5572d734a64b"),
                            Number = 4
                        },
                        new
                        {
                            Id = new Guid("edc4b7fc-df64-4cdb-a687-38b7cd9b042b"),
                            EducationDirectionId = new Guid("cea6189b-558a-43e5-9e5e-306186795de6"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("67f9d45f-9cd2-4489-9d33-93d26f0c0b84"),
                            EducationDirectionId = new Guid("cea6189b-558a-43e5-9e5e-306186795de6"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("fa016b7a-0a10-4f51-84c7-7d676efe1d35"),
                            EducationDirectionId = new Guid("cea6189b-558a-43e5-9e5e-306186795de6"),
                            Number = 3
                        },
                        new
                        {
                            Id = new Guid("56f48ee5-5950-44c7-8c35-036f78c9624f"),
                            EducationDirectionId = new Guid("cea6189b-558a-43e5-9e5e-306186795de6"),
                            Number = 4
                        },
                        new
                        {
                            Id = new Guid("cee68c2e-d5a1-4a94-9976-9256bf1363b2"),
                            EducationDirectionId = new Guid("3613288f-3b03-4d40-bc83-3e0a05755896"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("468adf17-3a5c-41da-86e0-28c6232f8e16"),
                            EducationDirectionId = new Guid("3613288f-3b03-4d40-bc83-3e0a05755896"),
                            Number = 2
                        });
                });

            modelBuilder.Entity("StudentFileManagment.Domain.Semester", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CourceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourceId");

                    b.ToTable("Semesters");

                    b.HasData(
                        new
                        {
                            Id = new Guid("39cc24c3-17d8-4493-8870-6b235b4f371b"),
                            CourceId = new Guid("9d399f47-e840-40d9-a159-6e2e6bbcbed3"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("2e8ea62a-8edb-4291-9944-1eddcc2d7ad7"),
                            CourceId = new Guid("9d399f47-e840-40d9-a159-6e2e6bbcbed3"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("64ae2b2a-e220-450f-8848-3a6a86a9d84c"),
                            CourceId = new Guid("3b98ae3d-02b2-4812-9a08-ad940a33da15"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("991dc8f3-1676-4f7f-9a35-dcb029ddfdd6"),
                            CourceId = new Guid("3b98ae3d-02b2-4812-9a08-ad940a33da15"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("46a547ae-c02c-4239-b88d-29a61ba6ee47"),
                            CourceId = new Guid("5b66dbc6-691a-4d66-bed4-a8d39ec2a4a2"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("f8ec1b2b-7dbd-4c4c-9db6-5b3c2204c241"),
                            CourceId = new Guid("5b66dbc6-691a-4d66-bed4-a8d39ec2a4a2"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("43ef8818-1a69-49b8-8cda-7f0d13e0ebaa"),
                            CourceId = new Guid("8d5f8c4d-ea0f-4ba0-97df-2ea97e45950b"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("9aad3171-d0e2-43ec-9229-f671a88f6621"),
                            CourceId = new Guid("8d5f8c4d-ea0f-4ba0-97df-2ea97e45950b"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("3cabebb5-558d-443e-946a-07f708887f1d"),
                            CourceId = new Guid("edc4b7fc-df64-4cdb-a687-38b7cd9b042b"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("8f03ad28-5f0d-4c72-88d1-969578644e20"),
                            CourceId = new Guid("edc4b7fc-df64-4cdb-a687-38b7cd9b042b"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("78e3aeb3-a34c-4de6-a6fe-5096ac6a8f64"),
                            CourceId = new Guid("67f9d45f-9cd2-4489-9d33-93d26f0c0b84"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("f2baa983-44f4-4cbf-b8f3-ebecfb303ac8"),
                            CourceId = new Guid("67f9d45f-9cd2-4489-9d33-93d26f0c0b84"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("3872bdd2-08cf-4452-ab6c-a36b2974a2b5"),
                            CourceId = new Guid("fa016b7a-0a10-4f51-84c7-7d676efe1d35"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("da0eaf8b-b463-4363-87dd-da54e4b59065"),
                            CourceId = new Guid("fa016b7a-0a10-4f51-84c7-7d676efe1d35"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("d7da980c-3e04-40aa-a6a2-252255eaefcd"),
                            CourceId = new Guid("56f48ee5-5950-44c7-8c35-036f78c9624f"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("95ae6a17-5452-4548-88bb-b54d36dc14ed"),
                            CourceId = new Guid("56f48ee5-5950-44c7-8c35-036f78c9624f"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("7bc709ca-6a17-496c-ad0c-a783b95cbdb8"),
                            CourceId = new Guid("cee68c2e-d5a1-4a94-9976-9256bf1363b2"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("53c8a24f-caf1-47e9-8083-4ccb342058df"),
                            CourceId = new Guid("cee68c2e-d5a1-4a94-9976-9256bf1363b2"),
                            Number = 2
                        },
                        new
                        {
                            Id = new Guid("1924050d-042b-4a91-b4a6-9e8aff18081a"),
                            CourceId = new Guid("468adf17-3a5c-41da-86e0-28c6232f8e16"),
                            Number = 1
                        },
                        new
                        {
                            Id = new Guid("118c8549-2cf5-486d-8f90-da00e125504d"),
                            CourceId = new Guid("468adf17-3a5c-41da-86e0-28c6232f8e16"),
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
