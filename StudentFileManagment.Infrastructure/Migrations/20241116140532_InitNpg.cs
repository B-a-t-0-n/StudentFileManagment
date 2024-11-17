using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentFileManagment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitNpg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Institutions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Institutions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Nickname = table.Column<string>(type: "text", nullable: true),
                    ChatId = table.Column<long>(type: "bigint", nullable: false),
                    IsAdmin = table.Column<bool>(type: "boolean", nullable: false),
                    IsModerator = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstitutionAndEducations",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    InstitutionId = table.Column<Guid>(type: "uuid", nullable: false),
                    EducationId = table.Column<Guid>(type: "uuid", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    InstitutionAndEducationId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationDirections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EducationDirections_InstitutionAndEducations_InstitutionAnd~",
                        column: x => x.InstitutionAndEducationId,
                        principalTable: "InstitutionAndEducations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cources",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    EducationDirectionId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cources_EducationDirections_EducationDirectionId",
                        column: x => x.EducationDirectionId,
                        principalTable: "EducationDirections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Semesters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Number = table.Column<int>(type: "integer", nullable: false),
                    CourceId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semesters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Semesters_Cources_CourceId",
                        column: x => x.CourceId,
                        principalTable: "Cources",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    SemesterId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subjects_Semesters_SemesterId",
                        column: x => x.SemesterId,
                        principalTable: "Semesters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lectures",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    SubjectId = table.Column<Guid>(type: "uuid", nullable: false)
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
                name: "LecturesData",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Comment = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<Guid>(type: "uuid", nullable: false),
                    LectureId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LecturesData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LecturesData_Lectures_LectureId",
                        column: x => x.LectureId,
                        principalTable: "Lectures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LecturesData_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Path = table.Column<string>(type: "text", nullable: false),
                    LectureDataId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Files_LecturesData_LectureDataId",
                        column: x => x.LectureDataId,
                        principalTable: "LecturesData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("57887b64-e853-4999-99b8-3d463dfc41f6"), "Магистратура" },
                    { new Guid("9440dadc-0b8e-405f-9d30-9b96b17ab15a"), "СПО" },
                    { new Guid("fca48a59-2033-43fa-ae7d-b22aeb63851d"), "Бакалавриат" }
                });

            migrationBuilder.InsertData(
                table: "Institutions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("5e21af2c-01cb-475e-a487-23083064353d"), "ВГЛТУ" });

            migrationBuilder.InsertData(
                table: "InstitutionAndEducations",
                columns: new[] { "Id", "EducationId", "InstitutionId" },
                values: new object[,]
                {
                    { new Guid("20e2cbea-95ba-48e1-ae75-6096d5cc3f72"), new Guid("57887b64-e853-4999-99b8-3d463dfc41f6"), new Guid("5e21af2c-01cb-475e-a487-23083064353d") },
                    { new Guid("8c46491a-e296-470f-9265-2c38c34f44ab"), new Guid("9440dadc-0b8e-405f-9d30-9b96b17ab15a"), new Guid("5e21af2c-01cb-475e-a487-23083064353d") },
                    { new Guid("ee899545-b050-4ecd-bdd6-4aa25b0d3116"), new Guid("fca48a59-2033-43fa-ae7d-b22aeb63851d"), new Guid("5e21af2c-01cb-475e-a487-23083064353d") }
                });

            migrationBuilder.InsertData(
                table: "EducationDirections",
                columns: new[] { "Id", "InstitutionAndEducationId", "Name" },
                values: new object[,]
                {
                    { new Guid("1282b2ab-45df-4820-9600-5d31a6950d0f"), new Guid("20e2cbea-95ba-48e1-ae75-6096d5cc3f72"), "Информационные системы и программирование" },
                    { new Guid("602c02ae-725b-479e-9667-35c0c0d71384"), new Guid("8c46491a-e296-470f-9265-2c38c34f44ab"), "Информационные системы и программирование" },
                    { new Guid("99eab9be-de2e-4b03-ace1-e6e644102578"), new Guid("ee899545-b050-4ecd-bdd6-4aa25b0d3116"), "Информационные системы и программирование" }
                });

            migrationBuilder.InsertData(
                table: "Cources",
                columns: new[] { "Id", "EducationDirectionId", "Number" },
                values: new object[,]
                {
                    { new Guid("1f59417a-37c8-46a6-99d2-e54af9144193"), new Guid("1282b2ab-45df-4820-9600-5d31a6950d0f"), 2 },
                    { new Guid("25eb8274-13a4-4e19-9446-d903e2c9a0c4"), new Guid("99eab9be-de2e-4b03-ace1-e6e644102578"), 4 },
                    { new Guid("3f630e70-6bdf-4da0-980b-3645009cb7c7"), new Guid("602c02ae-725b-479e-9667-35c0c0d71384"), 3 },
                    { new Guid("4a9ffe2f-eed7-48c4-abcf-2a6a56063b4e"), new Guid("602c02ae-725b-479e-9667-35c0c0d71384"), 2 },
                    { new Guid("5367ef55-a173-489e-82c0-840aa3d56ed0"), new Guid("99eab9be-de2e-4b03-ace1-e6e644102578"), 1 },
                    { new Guid("5c117bc6-912d-4fd0-881d-5ec5ce666083"), new Guid("1282b2ab-45df-4820-9600-5d31a6950d0f"), 1 },
                    { new Guid("60db9a82-a8e0-4114-812a-a12a75336eb1"), new Guid("99eab9be-de2e-4b03-ace1-e6e644102578"), 3 },
                    { new Guid("d97a028d-d3f3-43a5-98b1-06e0f5cf4ca5"), new Guid("602c02ae-725b-479e-9667-35c0c0d71384"), 1 },
                    { new Guid("e2597d08-fd61-44d0-9fe3-dfafc9ed1462"), new Guid("602c02ae-725b-479e-9667-35c0c0d71384"), 4 },
                    { new Guid("fb154af1-7230-4caf-99b8-7c597cf8fe74"), new Guid("99eab9be-de2e-4b03-ace1-e6e644102578"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CourceId", "Number" },
                values: new object[,]
                {
                    { new Guid("242f1d10-ee25-4ce0-9857-5a2fa225f32b"), new Guid("25eb8274-13a4-4e19-9446-d903e2c9a0c4"), 1 },
                    { new Guid("2aec6b9f-c3c2-4871-954e-4b1f3b31a029"), new Guid("60db9a82-a8e0-4114-812a-a12a75336eb1"), 2 },
                    { new Guid("37fb6708-f002-4b24-81ef-a423f441a22e"), new Guid("3f630e70-6bdf-4da0-980b-3645009cb7c7"), 1 },
                    { new Guid("3b92f388-ec22-4503-a331-7872cd88d677"), new Guid("4a9ffe2f-eed7-48c4-abcf-2a6a56063b4e"), 2 },
                    { new Guid("430d8369-41ec-4947-8ea0-f179becb5eed"), new Guid("1f59417a-37c8-46a6-99d2-e54af9144193"), 2 },
                    { new Guid("4f3cf312-fad2-4b6b-ab6d-2a3c59318983"), new Guid("fb154af1-7230-4caf-99b8-7c597cf8fe74"), 1 },
                    { new Guid("52276e5f-98ef-45d7-a75e-2aa76a025eaf"), new Guid("25eb8274-13a4-4e19-9446-d903e2c9a0c4"), 2 },
                    { new Guid("67f74fd7-5ae4-428a-84fc-b3dd90140ea9"), new Guid("5c117bc6-912d-4fd0-881d-5ec5ce666083"), 1 },
                    { new Guid("6efdb899-7c4c-45b2-b970-52d1effc24e5"), new Guid("60db9a82-a8e0-4114-812a-a12a75336eb1"), 1 },
                    { new Guid("7470b8a7-5369-441d-b84e-08b0c2508113"), new Guid("3f630e70-6bdf-4da0-980b-3645009cb7c7"), 2 },
                    { new Guid("88d67125-447d-4ece-b6bf-cfc35c322c6a"), new Guid("d97a028d-d3f3-43a5-98b1-06e0f5cf4ca5"), 1 },
                    { new Guid("8ad2a130-cc52-478f-a454-e6bdf29d3e7d"), new Guid("fb154af1-7230-4caf-99b8-7c597cf8fe74"), 2 },
                    { new Guid("8c4895c7-41e3-4df8-8a3e-c73a919c4d71"), new Guid("1f59417a-37c8-46a6-99d2-e54af9144193"), 1 },
                    { new Guid("9dd87b67-13a9-4c21-843d-0d2e88ca6c7f"), new Guid("5c117bc6-912d-4fd0-881d-5ec5ce666083"), 2 },
                    { new Guid("a1c92cd1-df66-4024-9ed0-033c5d3b49ee"), new Guid("4a9ffe2f-eed7-48c4-abcf-2a6a56063b4e"), 1 },
                    { new Guid("ab1237fd-44b3-4e79-89f7-1602440d5667"), new Guid("e2597d08-fd61-44d0-9fe3-dfafc9ed1462"), 2 },
                    { new Guid("aee70948-d546-4475-8d2a-fb4edf1c259a"), new Guid("d97a028d-d3f3-43a5-98b1-06e0f5cf4ca5"), 2 },
                    { new Guid("c89bb612-3643-451c-b2bc-892d7b98c7fe"), new Guid("5367ef55-a173-489e-82c0-840aa3d56ed0"), 1 },
                    { new Guid("d1aed08c-dea4-4564-8682-a95b15f850e8"), new Guid("e2597d08-fd61-44d0-9fe3-dfafc9ed1462"), 1 },
                    { new Guid("f8708152-cfe8-403c-8158-deb62ad3d5f8"), new Guid("5367ef55-a173-489e-82c0-840aa3d56ed0"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SemesterId" },
                values: new object[] { new Guid("17bda0f9-e109-43ef-9157-e2fcabfb741b"), "Проектирование и дизайн информационных систем", new Guid("a1c92cd1-df66-4024-9ed0-033c5d3b49ee") });

            migrationBuilder.CreateIndex(
                name: "IX_Cources_EducationDirectionId",
                table: "Cources",
                column: "EducationDirectionId");

            migrationBuilder.CreateIndex(
                name: "IX_EducationDirections_InstitutionAndEducationId",
                table: "EducationDirections",
                column: "InstitutionAndEducationId");

            migrationBuilder.CreateIndex(
                name: "IX_Files_LectureDataId",
                table: "Files",
                column: "LectureDataId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionAndEducations_EducationId",
                table: "InstitutionAndEducations",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_InstitutionAndEducations_InstitutionId",
                table: "InstitutionAndEducations",
                column: "InstitutionId");

            migrationBuilder.CreateIndex(
                name: "IX_Lectures_SubjectId",
                table: "Lectures",
                column: "SubjectId");

            migrationBuilder.CreateIndex(
                name: "IX_LecturesData_LectureId",
                table: "LecturesData",
                column: "LectureId");

            migrationBuilder.CreateIndex(
                name: "IX_LecturesData_UserId",
                table: "LecturesData",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Semesters_CourceId",
                table: "Semesters",
                column: "CourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Subjects_SemesterId",
                table: "Subjects",
                column: "SemesterId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropTable(
                name: "LecturesData");

            migrationBuilder.DropTable(
                name: "Lectures");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropTable(
                name: "Semesters");

            migrationBuilder.DropTable(
                name: "Cources");

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
