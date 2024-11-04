using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentFileManagment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("05abe942-b603-4dab-9f8b-99b7c13c23ac"), "Магистратура" },
                    { new Guid("c7616c99-233d-4ac8-ac42-7a1e317a8d2d"), "Бакалавриат" },
                    { new Guid("d01241ad-e80b-4bfd-9473-020f6710c48c"), "СПО" }
                });

            migrationBuilder.InsertData(
                table: "Institutions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("66fdf08d-10d9-42c2-a8cf-02a0a06505da"), "ВГЛТУ" });

            migrationBuilder.InsertData(
                table: "InstitutionAndEducations",
                columns: new[] { "Id", "DirectionsId", "EducationId", "InstitutionId" },
                values: new object[,]
                {
                    { new Guid("1d9d1b7a-9e03-4c27-abae-4914e183ed54"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("d01241ad-e80b-4bfd-9473-020f6710c48c"), new Guid("66fdf08d-10d9-42c2-a8cf-02a0a06505da") },
                    { new Guid("58255230-8f22-41a7-8dce-f03c0933d610"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("05abe942-b603-4dab-9f8b-99b7c13c23ac"), new Guid("66fdf08d-10d9-42c2-a8cf-02a0a06505da") },
                    { new Guid("caf7cffa-c435-4034-a286-1dbb26d5ff32"), new Guid("00000000-0000-0000-0000-000000000000"), new Guid("c7616c99-233d-4ac8-ac42-7a1e317a8d2d"), new Guid("66fdf08d-10d9-42c2-a8cf-02a0a06505da") }
                });

            migrationBuilder.InsertData(
                table: "EducationDirections",
                columns: new[] { "Id", "InstitutionAndEducationId", "Name" },
                values: new object[,]
                {
                    { new Guid("3613288f-3b03-4d40-bc83-3e0a05755896"), new Guid("58255230-8f22-41a7-8dce-f03c0933d610"), "Информационные системы и программирование" },
                    { new Guid("c37058ac-5dd7-41b3-9cf9-5572d734a64b"), new Guid("1d9d1b7a-9e03-4c27-abae-4914e183ed54"), "Информационные системы и программирование" },
                    { new Guid("cea6189b-558a-43e5-9e5e-306186795de6"), new Guid("caf7cffa-c435-4034-a286-1dbb26d5ff32"), "Информационные системы и программирование" }
                });

            migrationBuilder.InsertData(
                table: "Cources",
                columns: new[] { "Id", "EducationDirectionId", "Number" },
                values: new object[,]
                {
                    { new Guid("3b98ae3d-02b2-4812-9a08-ad940a33da15"), new Guid("c37058ac-5dd7-41b3-9cf9-5572d734a64b"), 2 },
                    { new Guid("468adf17-3a5c-41da-86e0-28c6232f8e16"), new Guid("3613288f-3b03-4d40-bc83-3e0a05755896"), 2 },
                    { new Guid("56f48ee5-5950-44c7-8c35-036f78c9624f"), new Guid("cea6189b-558a-43e5-9e5e-306186795de6"), 4 },
                    { new Guid("5b66dbc6-691a-4d66-bed4-a8d39ec2a4a2"), new Guid("c37058ac-5dd7-41b3-9cf9-5572d734a64b"), 3 },
                    { new Guid("67f9d45f-9cd2-4489-9d33-93d26f0c0b84"), new Guid("cea6189b-558a-43e5-9e5e-306186795de6"), 2 },
                    { new Guid("8d5f8c4d-ea0f-4ba0-97df-2ea97e45950b"), new Guid("c37058ac-5dd7-41b3-9cf9-5572d734a64b"), 4 },
                    { new Guid("9d399f47-e840-40d9-a159-6e2e6bbcbed3"), new Guid("c37058ac-5dd7-41b3-9cf9-5572d734a64b"), 1 },
                    { new Guid("cee68c2e-d5a1-4a94-9976-9256bf1363b2"), new Guid("3613288f-3b03-4d40-bc83-3e0a05755896"), 1 },
                    { new Guid("edc4b7fc-df64-4cdb-a687-38b7cd9b042b"), new Guid("cea6189b-558a-43e5-9e5e-306186795de6"), 1 },
                    { new Guid("fa016b7a-0a10-4f51-84c7-7d676efe1d35"), new Guid("cea6189b-558a-43e5-9e5e-306186795de6"), 3 }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CourceId", "Number" },
                values: new object[,]
                {
                    { new Guid("118c8549-2cf5-486d-8f90-da00e125504d"), new Guid("468adf17-3a5c-41da-86e0-28c6232f8e16"), 2 },
                    { new Guid("1924050d-042b-4a91-b4a6-9e8aff18081a"), new Guid("468adf17-3a5c-41da-86e0-28c6232f8e16"), 1 },
                    { new Guid("2e8ea62a-8edb-4291-9944-1eddcc2d7ad7"), new Guid("9d399f47-e840-40d9-a159-6e2e6bbcbed3"), 2 },
                    { new Guid("3872bdd2-08cf-4452-ab6c-a36b2974a2b5"), new Guid("fa016b7a-0a10-4f51-84c7-7d676efe1d35"), 1 },
                    { new Guid("39cc24c3-17d8-4493-8870-6b235b4f371b"), new Guid("9d399f47-e840-40d9-a159-6e2e6bbcbed3"), 1 },
                    { new Guid("3cabebb5-558d-443e-946a-07f708887f1d"), new Guid("edc4b7fc-df64-4cdb-a687-38b7cd9b042b"), 1 },
                    { new Guid("43ef8818-1a69-49b8-8cda-7f0d13e0ebaa"), new Guid("8d5f8c4d-ea0f-4ba0-97df-2ea97e45950b"), 1 },
                    { new Guid("46a547ae-c02c-4239-b88d-29a61ba6ee47"), new Guid("5b66dbc6-691a-4d66-bed4-a8d39ec2a4a2"), 1 },
                    { new Guid("53c8a24f-caf1-47e9-8083-4ccb342058df"), new Guid("cee68c2e-d5a1-4a94-9976-9256bf1363b2"), 2 },
                    { new Guid("64ae2b2a-e220-450f-8848-3a6a86a9d84c"), new Guid("3b98ae3d-02b2-4812-9a08-ad940a33da15"), 1 },
                    { new Guid("78e3aeb3-a34c-4de6-a6fe-5096ac6a8f64"), new Guid("67f9d45f-9cd2-4489-9d33-93d26f0c0b84"), 1 },
                    { new Guid("7bc709ca-6a17-496c-ad0c-a783b95cbdb8"), new Guid("cee68c2e-d5a1-4a94-9976-9256bf1363b2"), 1 },
                    { new Guid("8f03ad28-5f0d-4c72-88d1-969578644e20"), new Guid("edc4b7fc-df64-4cdb-a687-38b7cd9b042b"), 2 },
                    { new Guid("95ae6a17-5452-4548-88bb-b54d36dc14ed"), new Guid("56f48ee5-5950-44c7-8c35-036f78c9624f"), 2 },
                    { new Guid("991dc8f3-1676-4f7f-9a35-dcb029ddfdd6"), new Guid("3b98ae3d-02b2-4812-9a08-ad940a33da15"), 2 },
                    { new Guid("9aad3171-d0e2-43ec-9229-f671a88f6621"), new Guid("8d5f8c4d-ea0f-4ba0-97df-2ea97e45950b"), 2 },
                    { new Guid("d7da980c-3e04-40aa-a6a2-252255eaefcd"), new Guid("56f48ee5-5950-44c7-8c35-036f78c9624f"), 1 },
                    { new Guid("da0eaf8b-b463-4363-87dd-da54e4b59065"), new Guid("fa016b7a-0a10-4f51-84c7-7d676efe1d35"), 2 },
                    { new Guid("f2baa983-44f4-4cbf-b8f3-ebecfb303ac8"), new Guid("67f9d45f-9cd2-4489-9d33-93d26f0c0b84"), 2 },
                    { new Guid("f8ec1b2b-7dbd-4c4c-9db6-5b3c2204c241"), new Guid("5b66dbc6-691a-4d66-bed4-a8d39ec2a4a2"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SemesterId" },
                values: new object[] { new Guid("1f122923-d1f1-4434-adb3-a1f3e743f46e"), "Проектирование и дизайн информационных систем", new Guid("64ae2b2a-e220-450f-8848-3a6a86a9d84c") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("118c8549-2cf5-486d-8f90-da00e125504d"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("1924050d-042b-4a91-b4a6-9e8aff18081a"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("2e8ea62a-8edb-4291-9944-1eddcc2d7ad7"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("3872bdd2-08cf-4452-ab6c-a36b2974a2b5"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("39cc24c3-17d8-4493-8870-6b235b4f371b"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("3cabebb5-558d-443e-946a-07f708887f1d"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("43ef8818-1a69-49b8-8cda-7f0d13e0ebaa"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("46a547ae-c02c-4239-b88d-29a61ba6ee47"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("53c8a24f-caf1-47e9-8083-4ccb342058df"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("78e3aeb3-a34c-4de6-a6fe-5096ac6a8f64"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("7bc709ca-6a17-496c-ad0c-a783b95cbdb8"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("8f03ad28-5f0d-4c72-88d1-969578644e20"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("95ae6a17-5452-4548-88bb-b54d36dc14ed"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("991dc8f3-1676-4f7f-9a35-dcb029ddfdd6"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("9aad3171-d0e2-43ec-9229-f671a88f6621"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("d7da980c-3e04-40aa-a6a2-252255eaefcd"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("da0eaf8b-b463-4363-87dd-da54e4b59065"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("f2baa983-44f4-4cbf-b8f3-ebecfb303ac8"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("f8ec1b2b-7dbd-4c4c-9db6-5b3c2204c241"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("1f122923-d1f1-4434-adb3-a1f3e743f46e"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("468adf17-3a5c-41da-86e0-28c6232f8e16"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("56f48ee5-5950-44c7-8c35-036f78c9624f"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("5b66dbc6-691a-4d66-bed4-a8d39ec2a4a2"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("67f9d45f-9cd2-4489-9d33-93d26f0c0b84"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("8d5f8c4d-ea0f-4ba0-97df-2ea97e45950b"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("9d399f47-e840-40d9-a159-6e2e6bbcbed3"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("cee68c2e-d5a1-4a94-9976-9256bf1363b2"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("edc4b7fc-df64-4cdb-a687-38b7cd9b042b"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("fa016b7a-0a10-4f51-84c7-7d676efe1d35"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("64ae2b2a-e220-450f-8848-3a6a86a9d84c"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("3b98ae3d-02b2-4812-9a08-ad940a33da15"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("3613288f-3b03-4d40-bc83-3e0a05755896"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("cea6189b-558a-43e5-9e5e-306186795de6"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("c37058ac-5dd7-41b3-9cf9-5572d734a64b"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("58255230-8f22-41a7-8dce-f03c0933d610"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("caf7cffa-c435-4034-a286-1dbb26d5ff32"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("05abe942-b603-4dab-9f8b-99b7c13c23ac"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("c7616c99-233d-4ac8-ac42-7a1e317a8d2d"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("1d9d1b7a-9e03-4c27-abae-4914e183ed54"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("d01241ad-e80b-4bfd-9473-020f6710c48c"));

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "Id",
                keyValue: new Guid("66fdf08d-10d9-42c2-a8cf-02a0a06505da"));
        }
    }
}
