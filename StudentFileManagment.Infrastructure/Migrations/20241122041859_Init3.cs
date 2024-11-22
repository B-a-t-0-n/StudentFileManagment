using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentFileManagment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("62ac135b-e831-4995-88ac-9ae15da30140"), "Бакалавриат" },
                    { new Guid("8d5e99cc-d8cf-422f-8a9c-cbacd5143b27"), "Магистратура" },
                    { new Guid("ce11accd-17a8-4958-a9cc-09ba0c4ce16d"), "СПО" }
                });

            migrationBuilder.InsertData(
                table: "Institutions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("9ec08d6f-f5c7-4628-9ad7-136fd30c2e96"), "ВГЛТУ" });

            migrationBuilder.InsertData(
                table: "InstitutionAndEducations",
                columns: new[] { "Id", "EducationId", "InstitutionId" },
                values: new object[,]
                {
                    { new Guid("1765e7d2-4623-481e-b6d0-b4f1184e29f1"), new Guid("62ac135b-e831-4995-88ac-9ae15da30140"), new Guid("9ec08d6f-f5c7-4628-9ad7-136fd30c2e96") },
                    { new Guid("4a4fc8a9-0d57-4ee3-b27a-3a692d9ca597"), new Guid("ce11accd-17a8-4958-a9cc-09ba0c4ce16d"), new Guid("9ec08d6f-f5c7-4628-9ad7-136fd30c2e96") },
                    { new Guid("c1ee94c4-4ca5-4933-b5cf-1713c8572d2f"), new Guid("8d5e99cc-d8cf-422f-8a9c-cbacd5143b27"), new Guid("9ec08d6f-f5c7-4628-9ad7-136fd30c2e96") }
                });

            migrationBuilder.InsertData(
                table: "EducationDirections",
                columns: new[] { "Id", "InstitutionAndEducationId", "Name" },
                values: new object[,]
                {
                    { new Guid("4c4b78e2-1f97-4910-8310-5c24eb694978"), new Guid("4a4fc8a9-0d57-4ee3-b27a-3a692d9ca597"), "Информационные системы и программирование" },
                    { new Guid("8c3ee3f6-ecd0-49c5-aff8-9886b8e6bce9"), new Guid("1765e7d2-4623-481e-b6d0-b4f1184e29f1"), "Информационные системы и программирование" },
                    { new Guid("dc3abb4d-8790-4160-9b50-16f9623e5529"), new Guid("c1ee94c4-4ca5-4933-b5cf-1713c8572d2f"), "Информационные системы и программирование" }
                });

            migrationBuilder.InsertData(
                table: "Cources",
                columns: new[] { "Id", "EducationDirectionId", "Number" },
                values: new object[,]
                {
                    { new Guid("316ca0c9-cdcf-4d11-b60b-a36ad92c4b03"), new Guid("8c3ee3f6-ecd0-49c5-aff8-9886b8e6bce9"), 3 },
                    { new Guid("393522d4-6a4e-4c5d-aea2-ae9b6b26cb7e"), new Guid("4c4b78e2-1f97-4910-8310-5c24eb694978"), 3 },
                    { new Guid("53ac5424-846c-449d-93f9-a0d40d317b25"), new Guid("8c3ee3f6-ecd0-49c5-aff8-9886b8e6bce9"), 1 },
                    { new Guid("63046d20-a0a7-4443-b18e-887456d59699"), new Guid("4c4b78e2-1f97-4910-8310-5c24eb694978"), 1 },
                    { new Guid("81e63f6c-e16e-49ba-9d78-c2e5b53ea679"), new Guid("dc3abb4d-8790-4160-9b50-16f9623e5529"), 1 },
                    { new Guid("837621a6-e9d0-4885-b7ba-5bf105438826"), new Guid("dc3abb4d-8790-4160-9b50-16f9623e5529"), 2 },
                    { new Guid("973ace7b-94a9-4c17-a6a8-0aab022338a0"), new Guid("4c4b78e2-1f97-4910-8310-5c24eb694978"), 2 },
                    { new Guid("eb5808ea-498f-4ae6-888c-b89be7ed51f8"), new Guid("8c3ee3f6-ecd0-49c5-aff8-9886b8e6bce9"), 2 },
                    { new Guid("f87a4d36-a4aa-4851-8ca0-86a952eb02e9"), new Guid("8c3ee3f6-ecd0-49c5-aff8-9886b8e6bce9"), 4 },
                    { new Guid("ff9181ff-b7d2-4780-8cf5-0a73342d90b9"), new Guid("4c4b78e2-1f97-4910-8310-5c24eb694978"), 4 }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CourceId", "Number" },
                values: new object[,]
                {
                    { new Guid("06b92f4a-202d-43a3-a355-b8d5fcecf698"), new Guid("53ac5424-846c-449d-93f9-a0d40d317b25"), 2 },
                    { new Guid("0b46a346-3f80-4c3f-adea-dc518540d8c7"), new Guid("eb5808ea-498f-4ae6-888c-b89be7ed51f8"), 1 },
                    { new Guid("10778700-63a6-4d01-9332-7219208121cf"), new Guid("f87a4d36-a4aa-4851-8ca0-86a952eb02e9"), 1 },
                    { new Guid("262f0bb4-6d24-401a-885a-bdedeaf2f48e"), new Guid("393522d4-6a4e-4c5d-aea2-ae9b6b26cb7e"), 1 },
                    { new Guid("3bdab25b-176b-42c5-b128-4f84167ebd8f"), new Guid("316ca0c9-cdcf-4d11-b60b-a36ad92c4b03"), 1 },
                    { new Guid("4cc7fd87-039a-47a4-95d6-aaff1eedab2b"), new Guid("316ca0c9-cdcf-4d11-b60b-a36ad92c4b03"), 2 },
                    { new Guid("4fc9a709-b3b4-4ecd-9ed2-65b5e1b1b627"), new Guid("837621a6-e9d0-4885-b7ba-5bf105438826"), 1 },
                    { new Guid("59c9f30b-5a43-4e55-8716-7d456b9026cf"), new Guid("ff9181ff-b7d2-4780-8cf5-0a73342d90b9"), 2 },
                    { new Guid("5da4a2de-646b-4597-bdbe-f2107f7971f8"), new Guid("81e63f6c-e16e-49ba-9d78-c2e5b53ea679"), 2 },
                    { new Guid("a02c2dfe-aae5-4617-a5ad-e076d47cd277"), new Guid("ff9181ff-b7d2-4780-8cf5-0a73342d90b9"), 1 },
                    { new Guid("b398958b-6fda-4cf5-8282-96e26afa3e07"), new Guid("81e63f6c-e16e-49ba-9d78-c2e5b53ea679"), 1 },
                    { new Guid("bcb9e948-82ee-4958-95a2-423bd6413679"), new Guid("63046d20-a0a7-4443-b18e-887456d59699"), 1 },
                    { new Guid("bd4276a8-832d-4bea-b09c-52a9d5b83fe4"), new Guid("53ac5424-846c-449d-93f9-a0d40d317b25"), 1 },
                    { new Guid("c674182b-0fc0-4829-88d1-febf771e3a03"), new Guid("837621a6-e9d0-4885-b7ba-5bf105438826"), 2 },
                    { new Guid("ccbc572e-dc54-4e5a-bdb1-02d39a595ce8"), new Guid("973ace7b-94a9-4c17-a6a8-0aab022338a0"), 1 },
                    { new Guid("dd4e434d-fdc4-4b20-b64c-4a8f661a5081"), new Guid("f87a4d36-a4aa-4851-8ca0-86a952eb02e9"), 2 },
                    { new Guid("de81a93c-715f-4660-bd5d-27590486eceb"), new Guid("973ace7b-94a9-4c17-a6a8-0aab022338a0"), 2 },
                    { new Guid("e996bba8-2a93-4867-b741-ba233352ddce"), new Guid("63046d20-a0a7-4443-b18e-887456d59699"), 2 },
                    { new Guid("f44f0f7a-e1fb-4368-a555-912966479d11"), new Guid("eb5808ea-498f-4ae6-888c-b89be7ed51f8"), 2 },
                    { new Guid("f6b2fc48-d121-4dcb-9d5c-cbc15a795a0d"), new Guid("393522d4-6a4e-4c5d-aea2-ae9b6b26cb7e"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SemesterId" },
                values: new object[] { new Guid("45fe859a-38d6-495d-9e05-e641ad47ffe5"), "Проектирование и дизайн информационных систем", new Guid("ccbc572e-dc54-4e5a-bdb1-02d39a595ce8") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("06b92f4a-202d-43a3-a355-b8d5fcecf698"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("0b46a346-3f80-4c3f-adea-dc518540d8c7"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("10778700-63a6-4d01-9332-7219208121cf"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("262f0bb4-6d24-401a-885a-bdedeaf2f48e"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("3bdab25b-176b-42c5-b128-4f84167ebd8f"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("4cc7fd87-039a-47a4-95d6-aaff1eedab2b"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("4fc9a709-b3b4-4ecd-9ed2-65b5e1b1b627"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("59c9f30b-5a43-4e55-8716-7d456b9026cf"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("5da4a2de-646b-4597-bdbe-f2107f7971f8"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("a02c2dfe-aae5-4617-a5ad-e076d47cd277"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("b398958b-6fda-4cf5-8282-96e26afa3e07"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("bcb9e948-82ee-4958-95a2-423bd6413679"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("bd4276a8-832d-4bea-b09c-52a9d5b83fe4"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("c674182b-0fc0-4829-88d1-febf771e3a03"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("dd4e434d-fdc4-4b20-b64c-4a8f661a5081"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("de81a93c-715f-4660-bd5d-27590486eceb"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("e996bba8-2a93-4867-b741-ba233352ddce"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("f44f0f7a-e1fb-4368-a555-912966479d11"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("f6b2fc48-d121-4dcb-9d5c-cbc15a795a0d"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("45fe859a-38d6-495d-9e05-e641ad47ffe5"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("316ca0c9-cdcf-4d11-b60b-a36ad92c4b03"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("393522d4-6a4e-4c5d-aea2-ae9b6b26cb7e"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("53ac5424-846c-449d-93f9-a0d40d317b25"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("63046d20-a0a7-4443-b18e-887456d59699"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("81e63f6c-e16e-49ba-9d78-c2e5b53ea679"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("837621a6-e9d0-4885-b7ba-5bf105438826"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("eb5808ea-498f-4ae6-888c-b89be7ed51f8"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("f87a4d36-a4aa-4851-8ca0-86a952eb02e9"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("ff9181ff-b7d2-4780-8cf5-0a73342d90b9"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("ccbc572e-dc54-4e5a-bdb1-02d39a595ce8"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("973ace7b-94a9-4c17-a6a8-0aab022338a0"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("8c3ee3f6-ecd0-49c5-aff8-9886b8e6bce9"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("dc3abb4d-8790-4160-9b50-16f9623e5529"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("4c4b78e2-1f97-4910-8310-5c24eb694978"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("1765e7d2-4623-481e-b6d0-b4f1184e29f1"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("c1ee94c4-4ca5-4933-b5cf-1713c8572d2f"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("62ac135b-e831-4995-88ac-9ae15da30140"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("8d5e99cc-d8cf-422f-8a9c-cbacd5143b27"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("4a4fc8a9-0d57-4ee3-b27a-3a692d9ca597"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("ce11accd-17a8-4958-a9cc-09ba0c4ce16d"));

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "Id",
                keyValue: new Guid("9ec08d6f-f5c7-4628-9ad7-136fd30c2e96"));

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
    }
}
