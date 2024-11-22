using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentFileManagment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("0f681d4a-1b45-4512-81ae-2e6a558b7152"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("21502598-9d34-45a6-8374-b0dfab91583f"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("22808477-4703-4755-824a-62678b8949da"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("23e36c2b-0fcb-4a43-b8e0-5b3b5025da75"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("28a2bc22-0329-4037-acc5-e98b3277ff39"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("3e9a1798-dd23-4f7b-a6f8-228d6b41c969"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("6c46ca1f-bf53-4b18-9338-c01d3719cf78"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("7f9bdee2-c708-49af-9394-bc06469e386f"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("867eb6ac-c3b6-4d54-80a6-bafd8c7b14e6"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("87f2077a-4bf4-45b7-a1c7-3afbbd9794ec"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("a2cf60a5-f297-45f4-82a0-be33c122b3cc"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("a47c81b4-1f60-4c4c-8982-850e98d7b9fd"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("a9dc4afe-14df-4718-8b51-dc8be277efab"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("c82955e5-23e3-48ce-910a-8261f1c26eae"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("e1fc078d-e074-4d59-ad6a-e876ee97a1e5"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("f9ef0c00-3900-4e42-87db-e5df9341bb68"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("fcf3ad5d-f143-4280-8314-32588a90337e"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("fe57d8b1-e4be-4718-b9db-76a74de311c6"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("ff78d5cc-ae6c-469d-971e-e4653ed4b0c3"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("6845082a-cc42-466c-82b7-f98f5f12a512"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("076d4b72-6a32-4c6a-86b2-196bb9928684"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("0abc8fa6-9cf7-47d4-b37f-67d592816c4c"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("1fbe9a06-f817-4a18-aa60-cfc623557870"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("25be2015-83fd-48cf-998e-a5e52d40a898"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("3c48b7cf-bf44-454c-b1a8-5ee58d8126ea"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("5385ad07-1484-468e-a29b-7286e4f83699"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("7b542ff7-7bbb-4b5c-ba28-55964a284287"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("884296c9-3384-48e6-b470-88bc5bb9e1d2"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("ba5e974b-f9af-4dec-a042-a55d7b9fde5a"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("16e07640-3e7c-4670-bec8-0e74298e53b9"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("df748829-6c5e-403c-8fa6-aeb9ace42ade"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("0c158744-3d02-4b84-b384-d0e90532dce8"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("276cf8e0-9076-4557-b094-d6eb21ffe69e"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("251ce3e0-c57b-4366-88b2-e2f59c78bcff"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("260b4008-3ec5-4595-ac9d-28cdc5edbd43"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("c389974a-d01b-4654-8140-271b5faada06"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("044cebd7-281b-4125-9122-8f8b008d519d"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("fc38c983-80f2-4f8e-8549-03a129618d20"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("b7dddae3-33e4-4b21-bf17-ca1671e7e197"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("51389c89-8dd3-4122-9859-97dbae9a22b2"));

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "Id",
                keyValue: new Guid("a14c2809-777d-4423-a1dd-0028f68065c0"));

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("186e1b42-2d04-4861-ac6a-58c81516d11c"), "СПО" },
                    { new Guid("299c3893-8410-474c-a474-e2632e5d71f7"), "Бакалавриат" },
                    { new Guid("9b04d453-ddb5-464f-b14c-950514b95b64"), "Магистратура" }
                });

            migrationBuilder.InsertData(
                table: "Institutions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("2984d40a-7b27-4863-bd72-a55def5341f0"), "ВГЛТУ" });

            migrationBuilder.InsertData(
                table: "InstitutionAndEducations",
                columns: new[] { "Id", "EducationId", "InstitutionId" },
                values: new object[,]
                {
                    { new Guid("424b2026-d1ae-42d1-bc1b-71b572a1b197"), new Guid("299c3893-8410-474c-a474-e2632e5d71f7"), new Guid("2984d40a-7b27-4863-bd72-a55def5341f0") },
                    { new Guid("576d5746-fdc2-47a5-9a32-f70161f6f8aa"), new Guid("9b04d453-ddb5-464f-b14c-950514b95b64"), new Guid("2984d40a-7b27-4863-bd72-a55def5341f0") },
                    { new Guid("a517a396-1ff2-4e27-9687-abe765205448"), new Guid("186e1b42-2d04-4861-ac6a-58c81516d11c"), new Guid("2984d40a-7b27-4863-bd72-a55def5341f0") }
                });

            migrationBuilder.InsertData(
                table: "EducationDirections",
                columns: new[] { "Id", "InstitutionAndEducationId", "Name" },
                values: new object[,]
                {
                    { new Guid("0693f766-70d8-4ba2-b048-5fc91ba79eb1"), new Guid("576d5746-fdc2-47a5-9a32-f70161f6f8aa"), "Информационные системы и программирование" },
                    { new Guid("5e0716c4-7e58-4b0f-9587-7527a1be9b60"), new Guid("a517a396-1ff2-4e27-9687-abe765205448"), "Информационные системы и программирование" },
                    { new Guid("e12769d9-482e-4e82-aaf5-1188bda2a018"), new Guid("424b2026-d1ae-42d1-bc1b-71b572a1b197"), "Информационные системы и программирование" }
                });

            migrationBuilder.InsertData(
                table: "Cources",
                columns: new[] { "Id", "EducationDirectionId", "Number" },
                values: new object[,]
                {
                    { new Guid("05fcba21-0f9a-4ac5-abb9-439e61172f53"), new Guid("0693f766-70d8-4ba2-b048-5fc91ba79eb1"), 1 },
                    { new Guid("1137c747-cef6-4427-9df4-3770b341ff8e"), new Guid("e12769d9-482e-4e82-aaf5-1188bda2a018"), 1 },
                    { new Guid("2f989096-0137-4948-ade8-8fccf143f482"), new Guid("5e0716c4-7e58-4b0f-9587-7527a1be9b60"), 1 },
                    { new Guid("6cac5cab-7f5f-4723-a1bc-a1b71d4400db"), new Guid("e12769d9-482e-4e82-aaf5-1188bda2a018"), 4 },
                    { new Guid("71edbd03-980f-48c4-a524-ff551439cf09"), new Guid("e12769d9-482e-4e82-aaf5-1188bda2a018"), 3 },
                    { new Guid("76067cb0-6dde-4b41-9c1d-f5a0f404f339"), new Guid("e12769d9-482e-4e82-aaf5-1188bda2a018"), 2 },
                    { new Guid("8ae9dd08-68ac-4919-8a2d-e70158d71989"), new Guid("5e0716c4-7e58-4b0f-9587-7527a1be9b60"), 2 },
                    { new Guid("e90c0d77-6e23-4f45-a1d8-37c27c44a263"), new Guid("5e0716c4-7e58-4b0f-9587-7527a1be9b60"), 3 },
                    { new Guid("f035deef-036b-4121-8e7e-ceea31a5e79c"), new Guid("5e0716c4-7e58-4b0f-9587-7527a1be9b60"), 4 },
                    { new Guid("f59b5220-b594-4aff-84f1-abfc4e3a7f72"), new Guid("0693f766-70d8-4ba2-b048-5fc91ba79eb1"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CourceId", "Number" },
                values: new object[,]
                {
                    { new Guid("028631e4-df97-4571-8a89-e885bf66a064"), new Guid("f59b5220-b594-4aff-84f1-abfc4e3a7f72"), 1 },
                    { new Guid("0467e573-8e83-47db-ad97-d918b8f9ffce"), new Guid("f59b5220-b594-4aff-84f1-abfc4e3a7f72"), 2 },
                    { new Guid("27b008d5-d7db-448b-90e7-a9bdd5342e96"), new Guid("71edbd03-980f-48c4-a524-ff551439cf09"), 1 },
                    { new Guid("2ef7f185-e57e-4c42-a5ca-913710df2f40"), new Guid("6cac5cab-7f5f-4723-a1bc-a1b71d4400db"), 2 },
                    { new Guid("3ca4887a-3e10-4a33-8b6b-c59cb951ced4"), new Guid("76067cb0-6dde-4b41-9c1d-f5a0f404f339"), 1 },
                    { new Guid("4b097680-fd2d-4b9f-85d9-335aef8af587"), new Guid("05fcba21-0f9a-4ac5-abb9-439e61172f53"), 1 },
                    { new Guid("653c85a7-09e6-49ce-b6e5-66186fccb2b7"), new Guid("05fcba21-0f9a-4ac5-abb9-439e61172f53"), 2 },
                    { new Guid("66522245-f2e7-4f1d-b923-1a5c3d50d5b6"), new Guid("f035deef-036b-4121-8e7e-ceea31a5e79c"), 1 },
                    { new Guid("66acc2a8-bfac-4887-9eac-720b4ddff95d"), new Guid("6cac5cab-7f5f-4723-a1bc-a1b71d4400db"), 1 },
                    { new Guid("78b457f0-4c73-49ab-8910-0a80f293c4cb"), new Guid("1137c747-cef6-4427-9df4-3770b341ff8e"), 2 },
                    { new Guid("80cc7377-0064-4094-89ee-2b7d571deaf8"), new Guid("76067cb0-6dde-4b41-9c1d-f5a0f404f339"), 2 },
                    { new Guid("89bf6756-35fe-465c-bc94-65859c8e0e2c"), new Guid("e90c0d77-6e23-4f45-a1d8-37c27c44a263"), 2 },
                    { new Guid("9a3f10eb-a7c9-4d51-90ec-ad213ccfe969"), new Guid("8ae9dd08-68ac-4919-8a2d-e70158d71989"), 1 },
                    { new Guid("9d3251e5-e7c9-4a67-915d-1ce8cc781264"), new Guid("f035deef-036b-4121-8e7e-ceea31a5e79c"), 2 },
                    { new Guid("b17bfb4a-9a9a-44b6-a31e-09026e119b9c"), new Guid("1137c747-cef6-4427-9df4-3770b341ff8e"), 1 },
                    { new Guid("b7042103-a763-41b6-82dc-af603e46e34a"), new Guid("2f989096-0137-4948-ade8-8fccf143f482"), 2 },
                    { new Guid("cb1438dc-d378-453b-9bcb-f5eaf9d52461"), new Guid("e90c0d77-6e23-4f45-a1d8-37c27c44a263"), 1 },
                    { new Guid("db58df59-318b-42f3-a58e-300b8711a953"), new Guid("2f989096-0137-4948-ade8-8fccf143f482"), 1 },
                    { new Guid("e63ed2de-40fd-4c84-8401-7429ef8dac40"), new Guid("8ae9dd08-68ac-4919-8a2d-e70158d71989"), 2 },
                    { new Guid("f4ab845e-4944-412d-ada2-785644d73641"), new Guid("71edbd03-980f-48c4-a524-ff551439cf09"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SemesterId" },
                values: new object[] { new Guid("f0381b59-ae17-432b-abfd-cf8837100e91"), "Проектирование и дизайн информационных систем", new Guid("9a3f10eb-a7c9-4d51-90ec-ad213ccfe969") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("028631e4-df97-4571-8a89-e885bf66a064"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("0467e573-8e83-47db-ad97-d918b8f9ffce"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("27b008d5-d7db-448b-90e7-a9bdd5342e96"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("2ef7f185-e57e-4c42-a5ca-913710df2f40"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("3ca4887a-3e10-4a33-8b6b-c59cb951ced4"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("4b097680-fd2d-4b9f-85d9-335aef8af587"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("653c85a7-09e6-49ce-b6e5-66186fccb2b7"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("66522245-f2e7-4f1d-b923-1a5c3d50d5b6"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("66acc2a8-bfac-4887-9eac-720b4ddff95d"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("78b457f0-4c73-49ab-8910-0a80f293c4cb"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("80cc7377-0064-4094-89ee-2b7d571deaf8"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("89bf6756-35fe-465c-bc94-65859c8e0e2c"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("9d3251e5-e7c9-4a67-915d-1ce8cc781264"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("b17bfb4a-9a9a-44b6-a31e-09026e119b9c"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("b7042103-a763-41b6-82dc-af603e46e34a"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("cb1438dc-d378-453b-9bcb-f5eaf9d52461"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("db58df59-318b-42f3-a58e-300b8711a953"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("e63ed2de-40fd-4c84-8401-7429ef8dac40"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("f4ab845e-4944-412d-ada2-785644d73641"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f0381b59-ae17-432b-abfd-cf8837100e91"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("05fcba21-0f9a-4ac5-abb9-439e61172f53"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("1137c747-cef6-4427-9df4-3770b341ff8e"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("2f989096-0137-4948-ade8-8fccf143f482"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("6cac5cab-7f5f-4723-a1bc-a1b71d4400db"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("71edbd03-980f-48c4-a524-ff551439cf09"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("76067cb0-6dde-4b41-9c1d-f5a0f404f339"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("e90c0d77-6e23-4f45-a1d8-37c27c44a263"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("f035deef-036b-4121-8e7e-ceea31a5e79c"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("f59b5220-b594-4aff-84f1-abfc4e3a7f72"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("9a3f10eb-a7c9-4d51-90ec-ad213ccfe969"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("8ae9dd08-68ac-4919-8a2d-e70158d71989"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("0693f766-70d8-4ba2-b048-5fc91ba79eb1"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("e12769d9-482e-4e82-aaf5-1188bda2a018"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("5e0716c4-7e58-4b0f-9587-7527a1be9b60"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("424b2026-d1ae-42d1-bc1b-71b572a1b197"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("576d5746-fdc2-47a5-9a32-f70161f6f8aa"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("299c3893-8410-474c-a474-e2632e5d71f7"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("9b04d453-ddb5-464f-b14c-950514b95b64"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("a517a396-1ff2-4e27-9687-abe765205448"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("186e1b42-2d04-4861-ac6a-58c81516d11c"));

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "Id",
                keyValue: new Guid("2984d40a-7b27-4863-bd72-a55def5341f0"));

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("044cebd7-281b-4125-9122-8f8b008d519d"), "Бакалавриат" },
                    { new Guid("51389c89-8dd3-4122-9859-97dbae9a22b2"), "СПО" },
                    { new Guid("fc38c983-80f2-4f8e-8549-03a129618d20"), "Магистратура" }
                });

            migrationBuilder.InsertData(
                table: "Institutions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("a14c2809-777d-4423-a1dd-0028f68065c0"), "ВГЛТУ" });

            migrationBuilder.InsertData(
                table: "InstitutionAndEducations",
                columns: new[] { "Id", "EducationId", "InstitutionId" },
                values: new object[,]
                {
                    { new Guid("260b4008-3ec5-4595-ac9d-28cdc5edbd43"), new Guid("fc38c983-80f2-4f8e-8549-03a129618d20"), new Guid("a14c2809-777d-4423-a1dd-0028f68065c0") },
                    { new Guid("b7dddae3-33e4-4b21-bf17-ca1671e7e197"), new Guid("51389c89-8dd3-4122-9859-97dbae9a22b2"), new Guid("a14c2809-777d-4423-a1dd-0028f68065c0") },
                    { new Guid("c389974a-d01b-4654-8140-271b5faada06"), new Guid("044cebd7-281b-4125-9122-8f8b008d519d"), new Guid("a14c2809-777d-4423-a1dd-0028f68065c0") }
                });

            migrationBuilder.InsertData(
                table: "EducationDirections",
                columns: new[] { "Id", "InstitutionAndEducationId", "Name" },
                values: new object[,]
                {
                    { new Guid("0c158744-3d02-4b84-b384-d0e90532dce8"), new Guid("c389974a-d01b-4654-8140-271b5faada06"), "Информационные системы и программирование" },
                    { new Guid("251ce3e0-c57b-4366-88b2-e2f59c78bcff"), new Guid("b7dddae3-33e4-4b21-bf17-ca1671e7e197"), "Информационные системы и программирование" },
                    { new Guid("276cf8e0-9076-4557-b094-d6eb21ffe69e"), new Guid("260b4008-3ec5-4595-ac9d-28cdc5edbd43"), "Информационные системы и программирование" }
                });

            migrationBuilder.InsertData(
                table: "Cources",
                columns: new[] { "Id", "EducationDirectionId", "Number" },
                values: new object[,]
                {
                    { new Guid("076d4b72-6a32-4c6a-86b2-196bb9928684"), new Guid("251ce3e0-c57b-4366-88b2-e2f59c78bcff"), 3 },
                    { new Guid("0abc8fa6-9cf7-47d4-b37f-67d592816c4c"), new Guid("251ce3e0-c57b-4366-88b2-e2f59c78bcff"), 1 },
                    { new Guid("1fbe9a06-f817-4a18-aa60-cfc623557870"), new Guid("276cf8e0-9076-4557-b094-d6eb21ffe69e"), 1 },
                    { new Guid("25be2015-83fd-48cf-998e-a5e52d40a898"), new Guid("251ce3e0-c57b-4366-88b2-e2f59c78bcff"), 4 },
                    { new Guid("3c48b7cf-bf44-454c-b1a8-5ee58d8126ea"), new Guid("0c158744-3d02-4b84-b384-d0e90532dce8"), 4 },
                    { new Guid("5385ad07-1484-468e-a29b-7286e4f83699"), new Guid("0c158744-3d02-4b84-b384-d0e90532dce8"), 2 },
                    { new Guid("7b542ff7-7bbb-4b5c-ba28-55964a284287"), new Guid("0c158744-3d02-4b84-b384-d0e90532dce8"), 3 },
                    { new Guid("884296c9-3384-48e6-b470-88bc5bb9e1d2"), new Guid("0c158744-3d02-4b84-b384-d0e90532dce8"), 1 },
                    { new Guid("ba5e974b-f9af-4dec-a042-a55d7b9fde5a"), new Guid("276cf8e0-9076-4557-b094-d6eb21ffe69e"), 2 },
                    { new Guid("df748829-6c5e-403c-8fa6-aeb9ace42ade"), new Guid("251ce3e0-c57b-4366-88b2-e2f59c78bcff"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CourceId", "Number" },
                values: new object[,]
                {
                    { new Guid("0f681d4a-1b45-4512-81ae-2e6a558b7152"), new Guid("884296c9-3384-48e6-b470-88bc5bb9e1d2"), 2 },
                    { new Guid("16e07640-3e7c-4670-bec8-0e74298e53b9"), new Guid("df748829-6c5e-403c-8fa6-aeb9ace42ade"), 1 },
                    { new Guid("21502598-9d34-45a6-8374-b0dfab91583f"), new Guid("0abc8fa6-9cf7-47d4-b37f-67d592816c4c"), 1 },
                    { new Guid("22808477-4703-4755-824a-62678b8949da"), new Guid("ba5e974b-f9af-4dec-a042-a55d7b9fde5a"), 1 },
                    { new Guid("23e36c2b-0fcb-4a43-b8e0-5b3b5025da75"), new Guid("7b542ff7-7bbb-4b5c-ba28-55964a284287"), 2 },
                    { new Guid("28a2bc22-0329-4037-acc5-e98b3277ff39"), new Guid("5385ad07-1484-468e-a29b-7286e4f83699"), 2 },
                    { new Guid("3e9a1798-dd23-4f7b-a6f8-228d6b41c969"), new Guid("3c48b7cf-bf44-454c-b1a8-5ee58d8126ea"), 2 },
                    { new Guid("6c46ca1f-bf53-4b18-9338-c01d3719cf78"), new Guid("df748829-6c5e-403c-8fa6-aeb9ace42ade"), 2 },
                    { new Guid("7f9bdee2-c708-49af-9394-bc06469e386f"), new Guid("7b542ff7-7bbb-4b5c-ba28-55964a284287"), 1 },
                    { new Guid("867eb6ac-c3b6-4d54-80a6-bafd8c7b14e6"), new Guid("884296c9-3384-48e6-b470-88bc5bb9e1d2"), 1 },
                    { new Guid("87f2077a-4bf4-45b7-a1c7-3afbbd9794ec"), new Guid("3c48b7cf-bf44-454c-b1a8-5ee58d8126ea"), 1 },
                    { new Guid("a2cf60a5-f297-45f4-82a0-be33c122b3cc"), new Guid("076d4b72-6a32-4c6a-86b2-196bb9928684"), 2 },
                    { new Guid("a47c81b4-1f60-4c4c-8982-850e98d7b9fd"), new Guid("5385ad07-1484-468e-a29b-7286e4f83699"), 1 },
                    { new Guid("a9dc4afe-14df-4718-8b51-dc8be277efab"), new Guid("1fbe9a06-f817-4a18-aa60-cfc623557870"), 1 },
                    { new Guid("c82955e5-23e3-48ce-910a-8261f1c26eae"), new Guid("0abc8fa6-9cf7-47d4-b37f-67d592816c4c"), 2 },
                    { new Guid("e1fc078d-e074-4d59-ad6a-e876ee97a1e5"), new Guid("1fbe9a06-f817-4a18-aa60-cfc623557870"), 2 },
                    { new Guid("f9ef0c00-3900-4e42-87db-e5df9341bb68"), new Guid("25be2015-83fd-48cf-998e-a5e52d40a898"), 2 },
                    { new Guid("fcf3ad5d-f143-4280-8314-32588a90337e"), new Guid("ba5e974b-f9af-4dec-a042-a55d7b9fde5a"), 2 },
                    { new Guid("fe57d8b1-e4be-4718-b9db-76a74de311c6"), new Guid("25be2015-83fd-48cf-998e-a5e52d40a898"), 1 },
                    { new Guid("ff78d5cc-ae6c-469d-971e-e4653ed4b0c3"), new Guid("076d4b72-6a32-4c6a-86b2-196bb9928684"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SemesterId" },
                values: new object[] { new Guid("6845082a-cc42-466c-82b7-f98f5f12a512"), "Проектирование и дизайн информационных систем", new Guid("16e07640-3e7c-4670-bec8-0e74298e53b9") });
        }
    }
}
