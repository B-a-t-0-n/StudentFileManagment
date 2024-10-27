using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentFileManagment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update_file : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LectureFiles_Files_FileId",
                table: "LectureFiles");

            migrationBuilder.DropIndex(
                name: "IX_LectureFiles_FileId",
                table: "LectureFiles");

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("4ea0a665-2666-4a8a-83cf-c1ec050635f3"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("8682d938-9cac-4bbb-a45d-88608c6b2794"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("b103f073-0a33-44c3-a96f-6d976d154963"));

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "Id",
                keyValue: new Guid("3a10b888-5619-4e81-a014-bff5647ec504"));

            migrationBuilder.DropColumn(
                name: "FileId",
                table: "LectureFiles");

            migrationBuilder.AddColumn<Guid>(
                name: "LectureFilesId",
                table: "Files",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5860ea94-49e3-4f48-89cb-76c08615d155"), "Бакалавриат" },
                    { new Guid("b85c89e0-0f54-4b4f-9b3c-3d1ce0d599df"), "Магистратура" },
                    { new Guid("e37dd369-7109-4d40-81ce-b24937a40b55"), "СПО" }
                });

            migrationBuilder.InsertData(
                table: "Institutions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("3cca014b-873d-4800-8b61-092cc95268cc"), "ВГЛТУ" });

            migrationBuilder.CreateIndex(
                name: "IX_Files_LectureFilesId",
                table: "Files",
                column: "LectureFilesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_LectureFiles_LectureFilesId",
                table: "Files",
                column: "LectureFilesId",
                principalTable: "LectureFiles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_LectureFiles_LectureFilesId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_LectureFilesId",
                table: "Files");

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("5860ea94-49e3-4f48-89cb-76c08615d155"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("b85c89e0-0f54-4b4f-9b3c-3d1ce0d599df"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("e37dd369-7109-4d40-81ce-b24937a40b55"));

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "Id",
                keyValue: new Guid("3cca014b-873d-4800-8b61-092cc95268cc"));

            migrationBuilder.DropColumn(
                name: "LectureFilesId",
                table: "Files");

            migrationBuilder.AddColumn<Guid>(
                name: "FileId",
                table: "LectureFiles",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4ea0a665-2666-4a8a-83cf-c1ec050635f3"), "Магистратура" },
                    { new Guid("8682d938-9cac-4bbb-a45d-88608c6b2794"), "Бакалавриат" },
                    { new Guid("b103f073-0a33-44c3-a96f-6d976d154963"), "СПО" }
                });

            migrationBuilder.InsertData(
                table: "Institutions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("3a10b888-5619-4e81-a014-bff5647ec504"), "ВГЛТУ" });

            migrationBuilder.CreateIndex(
                name: "IX_LectureFiles_FileId",
                table: "LectureFiles",
                column: "FileId");

            migrationBuilder.AddForeignKey(
                name: "FK_LectureFiles_Files_FileId",
                table: "LectureFiles",
                column: "FileId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
