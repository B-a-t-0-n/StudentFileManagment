using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentFileManagment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Update_database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EducationDirections_Educations_EducationId",
                table: "EducationDirections");

            migrationBuilder.RenameColumn(
                name: "EducationId",
                table: "EducationDirections",
                newName: "InstitutionAndEducationId");

            migrationBuilder.RenameIndex(
                name: "IX_EducationDirections_EducationId",
                table: "EducationDirections",
                newName: "IX_EducationDirections_InstitutionAndEducationId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_EducationDirections_InstitutionAndEducations_InstitutionAndEducationId",
                table: "EducationDirections",
                column: "InstitutionAndEducationId",
                principalTable: "InstitutionAndEducations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EducationDirections_InstitutionAndEducations_InstitutionAndEducationId",
                table: "EducationDirections");

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

            migrationBuilder.RenameColumn(
                name: "InstitutionAndEducationId",
                table: "EducationDirections",
                newName: "EducationId");

            migrationBuilder.RenameIndex(
                name: "IX_EducationDirections_InstitutionAndEducationId",
                table: "EducationDirections",
                newName: "IX_EducationDirections_EducationId");

            migrationBuilder.AddForeignKey(
                name: "FK_EducationDirections_Educations_EducationId",
                table: "EducationDirections",
                column: "EducationId",
                principalTable: "Educations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
