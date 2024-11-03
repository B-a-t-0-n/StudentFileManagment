using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentFileManagment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("4f9c4172-cd26-40fa-a71f-f916989d823e"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("7485b3cb-2a57-49d8-a2cd-fa83c63c39f9"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("754b8afc-92d5-462c-abe6-bbd61d654ec4"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("57732f2a-1cf1-4943-ac79-ee682f73f89e"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("6b3186cd-8597-43fe-8572-e995a5457a73"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("a6aa4b03-f6e0-445d-a33d-3e307057cae5"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("29989ee1-ff22-44d0-9243-f5841d2f5beb"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("ae0744c9-f72f-471c-8b1a-5abd8ea98bea"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("c253b784-3f92-4ef3-8514-a52e78345ec1"));

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "Id",
                keyValue: new Guid("cacd1011-4cfc-480e-9f81-3a168efa2f16"));

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("055bf038-e980-46ea-b362-bfc01fc69328"), "Бакалавриат" },
                    { new Guid("1601ecaf-8311-46e8-970d-b62ddec1a509"), "Магистратура" },
                    { new Guid("57f7873d-c03a-406f-8735-f08cb88f97a8"), "СПО" }
                });

            migrationBuilder.InsertData(
                table: "Institutions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ad878326-82bb-4d9b-8e56-c286740e2fad"), "ВГЛТУ" });

            migrationBuilder.InsertData(
                table: "InstitutionAndEducations",
                columns: new[] { "Id", "DirectionsId", "EducationId", "InstitutionId" },
                values: new object[,]
                {
                    { new Guid("02bed09e-c6d9-47e5-83db-d5d60a9dab17"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("57f7873d-c03a-406f-8735-f08cb88f97a8"), new Guid("ad878326-82bb-4d9b-8e56-c286740e2fad") },
                    { new Guid("39fa224f-f625-45bd-b37d-a9a3c1fa9ab9"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("1601ecaf-8311-46e8-970d-b62ddec1a509"), new Guid("ad878326-82bb-4d9b-8e56-c286740e2fad") },
                    { new Guid("760c6066-229e-4aa6-a667-6dab5e606df3"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("055bf038-e980-46ea-b362-bfc01fc69328"), new Guid("ad878326-82bb-4d9b-8e56-c286740e2fad") }
                });

            migrationBuilder.InsertData(
                table: "EducationDirections",
                columns: new[] { "Id", "InstitutionAndEducationId", "Name", "NumberCources", "NumberSemesters" },
                values: new object[,]
                {
                    { new Guid("852261d7-f37d-4cf8-8de5-8f07cb00df26"), new Guid("760c6066-229e-4aa6-a667-6dab5e606df3"), "Информационные системы и программирование", 4, 2 },
                    { new Guid("8c119a64-99c0-4f4d-9968-022aac2b1a08"), new Guid("02bed09e-c6d9-47e5-83db-d5d60a9dab17"), "Информационные системы и программирование", 4, 2 },
                    { new Guid("ee28610f-662f-4a80-b95c-b942526bebe3"), new Guid("39fa224f-f625-45bd-b37d-a9a3c1fa9ab9"), "Информационные системы и программирование", 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Cource", "EducationDirectionId", "Name", "Semester" },
                values: new object[] { new Guid("c6bd1b19-ea3b-4106-b064-261986686631"), 2, new Guid("8c119a64-99c0-4f4d-9968-022aac2b1a08"), "Проектирование и дизайн информационных систем", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("852261d7-f37d-4cf8-8de5-8f07cb00df26"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("ee28610f-662f-4a80-b95c-b942526bebe3"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("c6bd1b19-ea3b-4106-b064-261986686631"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("8c119a64-99c0-4f4d-9968-022aac2b1a08"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("39fa224f-f625-45bd-b37d-a9a3c1fa9ab9"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("760c6066-229e-4aa6-a667-6dab5e606df3"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("055bf038-e980-46ea-b362-bfc01fc69328"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("1601ecaf-8311-46e8-970d-b62ddec1a509"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("02bed09e-c6d9-47e5-83db-d5d60a9dab17"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("57f7873d-c03a-406f-8735-f08cb88f97a8"));

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "Id",
                keyValue: new Guid("ad878326-82bb-4d9b-8e56-c286740e2fad"));

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
        }
    }
}
