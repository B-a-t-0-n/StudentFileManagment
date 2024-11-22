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
                    { new Guid("274f0879-81b2-48b9-8c83-563129a433b2"), "Магистратура" },
                    { new Guid("b651de1c-b745-4acf-ac8f-b0b2c9a38ce5"), "СПО" },
                    { new Guid("ca75b47d-168c-48ae-97b1-1d64fbd279c1"), "Бакалавриат" }
                });

            migrationBuilder.InsertData(
                table: "Institutions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("1258b06e-5775-4d50-b776-497a6056d3eb"), "ВГЛТУ" });

            migrationBuilder.InsertData(
                table: "InstitutionAndEducations",
                columns: new[] { "Id", "EducationId", "InstitutionId" },
                values: new object[,]
                {
                    { new Guid("b1ab7cf2-e1e1-4e96-869c-f96b93c05534"), new Guid("ca75b47d-168c-48ae-97b1-1d64fbd279c1"), new Guid("1258b06e-5775-4d50-b776-497a6056d3eb") },
                    { new Guid("c6646a66-5158-44df-b3e0-597cb4b94732"), new Guid("274f0879-81b2-48b9-8c83-563129a433b2"), new Guid("1258b06e-5775-4d50-b776-497a6056d3eb") },
                    { new Guid("ebe01add-2ac1-43b4-8957-8e7e95726871"), new Guid("b651de1c-b745-4acf-ac8f-b0b2c9a38ce5"), new Guid("1258b06e-5775-4d50-b776-497a6056d3eb") }
                });

            migrationBuilder.InsertData(
                table: "EducationDirections",
                columns: new[] { "Id", "InstitutionAndEducationId", "Name" },
                values: new object[,]
                {
                    { new Guid("0e15eb64-d669-4c14-b5e0-2e2e952c6520"), new Guid("b1ab7cf2-e1e1-4e96-869c-f96b93c05534"), "Информационные системы и программирование" },
                    { new Guid("c20ec013-6c94-44d0-a290-ff5b3ddbe26e"), new Guid("c6646a66-5158-44df-b3e0-597cb4b94732"), "Информационные системы и программирование" },
                    { new Guid("cc8dbf2f-e9c1-41dc-aedd-6fdfeec33997"), new Guid("ebe01add-2ac1-43b4-8957-8e7e95726871"), "Информационные системы и программирование" }
                });

            migrationBuilder.InsertData(
                table: "Cources",
                columns: new[] { "Id", "EducationDirectionId", "Number" },
                values: new object[,]
                {
                    { new Guid("18398daa-9149-429a-a761-e6c76eb65dd8"), new Guid("0e15eb64-d669-4c14-b5e0-2e2e952c6520"), 3 },
                    { new Guid("1e30bf01-c0ef-4c23-91ab-fd8ec9e461f2"), new Guid("0e15eb64-d669-4c14-b5e0-2e2e952c6520"), 4 },
                    { new Guid("3bec3d2f-4b29-490a-84a9-a104ba4219d9"), new Guid("cc8dbf2f-e9c1-41dc-aedd-6fdfeec33997"), 3 },
                    { new Guid("89013fb3-ace7-4bd1-bca1-abee97e7e753"), new Guid("cc8dbf2f-e9c1-41dc-aedd-6fdfeec33997"), 2 },
                    { new Guid("9f47b622-69fc-4414-a710-325364ce4e4e"), new Guid("cc8dbf2f-e9c1-41dc-aedd-6fdfeec33997"), 1 },
                    { new Guid("aaacbb53-40a6-46b6-9557-be8c85a6354c"), new Guid("c20ec013-6c94-44d0-a290-ff5b3ddbe26e"), 1 },
                    { new Guid("c4fcc62f-ae61-41da-aded-db3ca03eb63f"), new Guid("0e15eb64-d669-4c14-b5e0-2e2e952c6520"), 2 },
                    { new Guid("f7dc0e37-864d-4de0-b686-7cda0f64717f"), new Guid("0e15eb64-d669-4c14-b5e0-2e2e952c6520"), 1 },
                    { new Guid("f9f83d43-940b-4aba-ad57-8b3cd0044c51"), new Guid("c20ec013-6c94-44d0-a290-ff5b3ddbe26e"), 2 },
                    { new Guid("fdfc575f-377b-4f5b-98e5-aff7363b9800"), new Guid("cc8dbf2f-e9c1-41dc-aedd-6fdfeec33997"), 4 }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CourceId", "Number" },
                values: new object[,]
                {
                    { new Guid("001e0d09-5a70-4f5d-bef5-155d5699fa72"), new Guid("9f47b622-69fc-4414-a710-325364ce4e4e"), 1 },
                    { new Guid("01b2e251-7fd0-4072-a0ab-92d8bba89aea"), new Guid("f9f83d43-940b-4aba-ad57-8b3cd0044c51"), 2 },
                    { new Guid("149ca383-7e54-422d-966c-217f35198b67"), new Guid("3bec3d2f-4b29-490a-84a9-a104ba4219d9"), 1 },
                    { new Guid("16e34bd1-ed4b-418f-bcc4-d55d15508989"), new Guid("3bec3d2f-4b29-490a-84a9-a104ba4219d9"), 2 },
                    { new Guid("177505d5-33a0-433a-8240-dbd8e5d34fce"), new Guid("1e30bf01-c0ef-4c23-91ab-fd8ec9e461f2"), 1 },
                    { new Guid("1a51ccf0-4763-4317-afa2-0ebdb96ebe52"), new Guid("c4fcc62f-ae61-41da-aded-db3ca03eb63f"), 1 },
                    { new Guid("1d39b470-e65f-4901-856c-239c8703e55a"), new Guid("18398daa-9149-429a-a761-e6c76eb65dd8"), 1 },
                    { new Guid("51ba16df-e980-4ce3-8da0-a85f24b58f82"), new Guid("f7dc0e37-864d-4de0-b686-7cda0f64717f"), 1 },
                    { new Guid("65d0f32a-01ce-4a1c-9591-3fe89f15c0dc"), new Guid("89013fb3-ace7-4bd1-bca1-abee97e7e753"), 2 },
                    { new Guid("6e0fc074-6235-4b26-9f55-614495ad7701"), new Guid("fdfc575f-377b-4f5b-98e5-aff7363b9800"), 1 },
                    { new Guid("784f28db-1c82-493b-97b0-eaf1373438eb"), new Guid("aaacbb53-40a6-46b6-9557-be8c85a6354c"), 2 },
                    { new Guid("81380f51-1feb-45ab-a94b-fba33eb7d47b"), new Guid("f7dc0e37-864d-4de0-b686-7cda0f64717f"), 2 },
                    { new Guid("82dbe600-3f09-4cda-b262-3d4a7891bd01"), new Guid("18398daa-9149-429a-a761-e6c76eb65dd8"), 2 },
                    { new Guid("950628e0-e89d-4d41-9cee-819bf0f951f2"), new Guid("aaacbb53-40a6-46b6-9557-be8c85a6354c"), 1 },
                    { new Guid("a0edf15d-da2c-4e46-bc00-99db87094634"), new Guid("f9f83d43-940b-4aba-ad57-8b3cd0044c51"), 1 },
                    { new Guid("a7cf52c3-d18f-4c75-8f6f-857f36be1985"), new Guid("fdfc575f-377b-4f5b-98e5-aff7363b9800"), 2 },
                    { new Guid("a9c22a4f-b126-48fb-913e-9d209eb79979"), new Guid("c4fcc62f-ae61-41da-aded-db3ca03eb63f"), 2 },
                    { new Guid("b1f89303-733e-4ffd-bba2-93f2591a4c61"), new Guid("1e30bf01-c0ef-4c23-91ab-fd8ec9e461f2"), 2 },
                    { new Guid("e0879f37-6590-4be4-8012-2eac2f62e64c"), new Guid("9f47b622-69fc-4414-a710-325364ce4e4e"), 2 },
                    { new Guid("e25ee8b8-ef5a-423d-819c-cb7a5862a9ae"), new Guid("89013fb3-ace7-4bd1-bca1-abee97e7e753"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SemesterId" },
                values: new object[] { new Guid("466a4243-8a73-4536-a5df-0c55bea46eba"), "Проектирование и дизайн информационных систем", new Guid("e25ee8b8-ef5a-423d-819c-cb7a5862a9ae") });

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
