using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentFileManagment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Institutions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nickname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChatId = table.Column<long>(type: "bigint", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    IsModerator = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstitutionAndEducations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstitutionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EducationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DirectionsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstitutionAndEducations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstitutionAndEducations_Educations_EducationId",
                        column: x => x.EducationId,
                        principalTable: "Educations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstitutionAndEducations_Institutions_InstitutionId",
                        column: x => x.InstitutionId,
                        principalTable: "Institutions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EducationDirections",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberCources = table.Column<int>(type: "int", nullable: false),
                    NumberSemesters = table.Column<int>(type: "int", nullable: false),
                    InstitutionAndEducationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationDirections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationDirections_InstitutionAndEducations_InstitutionAndEducationId",
                        column: x => x.InstitutionAndEducationId,
                        principalTable: "InstitutionAndEducations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cource = table.Column<int>(type: "int", nullable: false),
                    Semester = table.Column<int>(type: "int", nullable: false),
                    EducationDirectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_EducationDirections_EducationDirectionId",
                        column: x => x.EducationDirectionId,
                        principalTable: "EducationDirections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lectures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lectures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lectures_Subjects_SubjectId",
                        column: x => x.SubjectId,
                        principalTable: "Subjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LectureFiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LectureId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LectureFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LectureFiles_Lectures_LectureId",
                        column: x => x.LectureId,
                        principalTable: "Lectures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LectureFiles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LectureFilesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Files_LectureFiles_LectureFilesId",
                        column: x => x.LectureFilesId,
                        principalTable: "LectureFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("29989ee1-ff22-44d0-9243-f5841d2f5beb"), "СПО" },
                    { new Guid("ae0744c9-f72f-471c-8b1a-5abd8ea98bea"), "Магистратура" },
                    { new Guid("c253b784-3f92-4ef3-8514-a52e78345ec1"), "Бакалавриат" }
                });

            migrationBuilder.InsertData(
                table: "Institutions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("cacd1011-4cfc-480e-9f81-3a168efa2f16"), "ВГЛТУ" });

            migrationBuilder.InsertData(
                table: "InstitutionAndEducations",
                columns: new[] { "Id", "DirectionsId", "EducationId", "InstitutionId" },
                values: new object[,]
                {
                    { new Guid("57732f2a-1cf1-4943-ac79-ee682f73f89e"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c253b784-3f92-4ef3-8514-a52e78345ec1"), new Guid("cacd1011-4cfc-480e-9f81-3a168efa2f16") },
                    { new Guid("6b3186cd-8597-43fe-8572-e995a5457a73"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("ae0744c9-f72f-471c-8b1a-5abd8ea98bea"), new Guid("cacd1011-4cfc-480e-9f81-3a168efa2f16") },
                    { new Guid("a6aa4b03-f6e0-445d-a33d-3e307057cae5"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("29989ee1-ff22-44d0-9243-f5841d2f5beb"), new Guid("cacd1011-4cfc-480e-9f81-3a168efa2f16") }
                });

            migrationBuilder.InsertData(
                table: "EducationDirections",
                columns: new[] { "Id", "InstitutionAndEducationId", "Name", "NumberCources", "NumberSemesters" },
                values: new object[,]
                {
                    { new Guid("4f9c4172-cd26-40fa-a71f-f916989d823e"), new Guid("a6aa4b03-f6e0-445d-a33d-3e307057cae5"), "Информационные системы и программирование", 4, 2 },
                    { new Guid("7485b3cb-2a57-49d8-a2cd-fa83c63c39f9"), new Guid("57732f2a-1cf1-4943-ac79-ee682f73f89e"), "Информационные системы и программирование", 4, 2 },
                    { new Guid("754b8afc-92d5-462c-abe6-bbd61d654ec4"), new Guid("6b3186cd-8597-43fe-8572-e995a5457a73"), "Информационные системы и программирование", 4, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_EducationDirections_InstitutionAndEducationId",
                table: "EducationDirections",
                column: "InstitutionAndEducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_LectureFilesId",
                table: "Files",
                column: "LectureFilesId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionAndEducations_EducationId",
                table: "InstitutionAndEducations",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionAndEducations_InstitutionId",
                table: "InstitutionAndEducations",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_LectureFiles_LectureId",
                table: "LectureFiles",
                column: "LectureId");

            migrationBuilder.CreateIndex(
                name: "IX_LectureFiles_UserId",
                table: "LectureFiles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_SubjectId",
                table: "Lectures",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_EducationDirectionId",
                table: "Subjects",
                column: "EducationDirectionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "LectureFiles");

            migrationBuilder.DropTable(
                name: "Lectures");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "EducationDirections");

            migrationBuilder.DropTable(
                name: "InstitutionAndEducations");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Institutions");
        }
    }
}
