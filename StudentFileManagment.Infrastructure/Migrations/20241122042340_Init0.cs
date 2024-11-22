using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentFileManagment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Init0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("23f6c36e-1a2a-4d3f-aa41-d1689d7f78e1"), "Магистратура" },
                    { new Guid("4dbe7c6e-2218-4071-8837-699ff20baa24"), "СПО" },
                    { new Guid("72614a3a-cfff-4c26-abce-f43d2f1bc325"), "Бакалавриат" }
                });

            migrationBuilder.InsertData(
                table: "Institutions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("cc377952-3d95-4dab-9207-5a926887f1e5"), "ВГЛТУ" });

            migrationBuilder.InsertData(
                table: "InstitutionAndEducations",
                columns: new[] { "Id", "EducationId", "InstitutionId" },
                values: new object[,]
                {
                    { new Guid("0f809a18-b7bf-49a1-b1f2-5d67e9d04448"), new Guid("23f6c36e-1a2a-4d3f-aa41-d1689d7f78e1"), new Guid("cc377952-3d95-4dab-9207-5a926887f1e5") },
                    { new Guid("3e9372df-7319-4924-83a1-20b1d1b8e848"), new Guid("4dbe7c6e-2218-4071-8837-699ff20baa24"), new Guid("cc377952-3d95-4dab-9207-5a926887f1e5") },
                    { new Guid("f3b52d23-9ad0-41f5-ab38-82e40ada6299"), new Guid("72614a3a-cfff-4c26-abce-f43d2f1bc325"), new Guid("cc377952-3d95-4dab-9207-5a926887f1e5") }
                });

            migrationBuilder.InsertData(
                table: "EducationDirections",
                columns: new[] { "Id", "InstitutionAndEducationId", "Name" },
                values: new object[,]
                {
                    { new Guid("444a4b16-9a48-4a8a-a873-8401e59d7506"), new Guid("0f809a18-b7bf-49a1-b1f2-5d67e9d04448"), "Информационные системы и программирование" },
                    { new Guid("4d11b3ee-b8b3-44e5-b40d-613c0a7c4104"), new Guid("3e9372df-7319-4924-83a1-20b1d1b8e848"), "Информационные системы и программирование" },
                    { new Guid("9e21bea4-5d74-4d10-8fcf-09d1ddcbc5c7"), new Guid("f3b52d23-9ad0-41f5-ab38-82e40ada6299"), "Информационные системы и программирование" }
                });

            migrationBuilder.InsertData(
                table: "Cources",
                columns: new[] { "Id", "EducationDirectionId", "Number" },
                values: new object[,]
                {
                    { new Guid("088148d0-a45f-4877-b2f2-5c66399ae558"), new Guid("9e21bea4-5d74-4d10-8fcf-09d1ddcbc5c7"), 1 },
                    { new Guid("099d014f-82d6-458c-ab3c-5779ad024951"), new Guid("9e21bea4-5d74-4d10-8fcf-09d1ddcbc5c7"), 4 },
                    { new Guid("0b5d8431-3ada-4071-8a26-d95c1d97b504"), new Guid("444a4b16-9a48-4a8a-a873-8401e59d7506"), 2 },
                    { new Guid("0e3754c9-98df-40a2-9dfa-cd18c5cf3d46"), new Guid("444a4b16-9a48-4a8a-a873-8401e59d7506"), 1 },
                    { new Guid("3295510f-0a3c-4dfa-8479-27bbe7b157a4"), new Guid("4d11b3ee-b8b3-44e5-b40d-613c0a7c4104"), 3 },
                    { new Guid("6f70ddcd-b437-4f07-b32b-f551aaac2927"), new Guid("4d11b3ee-b8b3-44e5-b40d-613c0a7c4104"), 1 },
                    { new Guid("b5c91b0c-503d-48f8-8290-947ef9c452e3"), new Guid("4d11b3ee-b8b3-44e5-b40d-613c0a7c4104"), 2 },
                    { new Guid("d2c5e3c5-a0be-47f2-92c6-4c6f5542898d"), new Guid("9e21bea4-5d74-4d10-8fcf-09d1ddcbc5c7"), 2 },
                    { new Guid("da924a5c-cdd3-4c10-907a-42702fe5871f"), new Guid("4d11b3ee-b8b3-44e5-b40d-613c0a7c4104"), 4 },
                    { new Guid("e6ec4ce3-3d0f-46dd-bd71-897c87dba9f4"), new Guid("9e21bea4-5d74-4d10-8fcf-09d1ddcbc5c7"), 3 }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CourceId", "Number" },
                values: new object[,]
                {
                    { new Guid("06c31dd8-0e86-450e-b237-2ae00de9653f"), new Guid("088148d0-a45f-4877-b2f2-5c66399ae558"), 1 },
                    { new Guid("0e53e69e-d2b3-43e2-b591-cdf8ca2a136e"), new Guid("b5c91b0c-503d-48f8-8290-947ef9c452e3"), 2 },
                    { new Guid("114af4ca-0b38-4beb-9fc8-9fa9087a943d"), new Guid("3295510f-0a3c-4dfa-8479-27bbe7b157a4"), 1 },
                    { new Guid("13786a7f-9a8b-40d5-b45e-0eedd876c18e"), new Guid("6f70ddcd-b437-4f07-b32b-f551aaac2927"), 1 },
                    { new Guid("1f2dc88b-45f1-4fea-80b0-c7ad6f6a97b1"), new Guid("099d014f-82d6-458c-ab3c-5779ad024951"), 1 },
                    { new Guid("27187642-1682-44a3-8ba3-7e8392161360"), new Guid("0e3754c9-98df-40a2-9dfa-cd18c5cf3d46"), 2 },
                    { new Guid("2947dc96-6eca-4897-a97f-ea1693811e62"), new Guid("088148d0-a45f-4877-b2f2-5c66399ae558"), 2 },
                    { new Guid("2d3dd94f-84c0-4bf8-93ca-1e3be98282a4"), new Guid("0b5d8431-3ada-4071-8a26-d95c1d97b504"), 1 },
                    { new Guid("2f48910a-2d48-44fa-9e45-7a701d6d2ff4"), new Guid("e6ec4ce3-3d0f-46dd-bd71-897c87dba9f4"), 1 },
                    { new Guid("312ebbf1-dc51-461a-8582-539ddd19a9d4"), new Guid("0e3754c9-98df-40a2-9dfa-cd18c5cf3d46"), 1 },
                    { new Guid("3553d855-5dc5-4b03-98f2-94759f9c7976"), new Guid("6f70ddcd-b437-4f07-b32b-f551aaac2927"), 2 },
                    { new Guid("3c038712-5460-4080-94fb-3753d9eae46f"), new Guid("e6ec4ce3-3d0f-46dd-bd71-897c87dba9f4"), 2 },
                    { new Guid("429b2e03-b8f9-47b5-87b5-2b36b683d26a"), new Guid("d2c5e3c5-a0be-47f2-92c6-4c6f5542898d"), 2 },
                    { new Guid("58c78b85-fd9b-4087-be9a-f0ee40d89cae"), new Guid("3295510f-0a3c-4dfa-8479-27bbe7b157a4"), 2 },
                    { new Guid("68db642e-4cb2-4d52-a528-64ab4f684f81"), new Guid("099d014f-82d6-458c-ab3c-5779ad024951"), 2 },
                    { new Guid("8e0022cb-dd42-4ba3-b5b5-c443858a5ca1"), new Guid("b5c91b0c-503d-48f8-8290-947ef9c452e3"), 1 },
                    { new Guid("e6cfff90-e435-4d07-8af7-36c531cc0db1"), new Guid("da924a5c-cdd3-4c10-907a-42702fe5871f"), 1 },
                    { new Guid("e877546e-d6bb-4d31-99cc-60f025c32b92"), new Guid("d2c5e3c5-a0be-47f2-92c6-4c6f5542898d"), 1 },
                    { new Guid("efb4cb12-3e9b-4409-97d7-87dfe93a4b97"), new Guid("da924a5c-cdd3-4c10-907a-42702fe5871f"), 2 },
                    { new Guid("efd4d226-fa1f-4f9c-b128-b00acd4524b7"), new Guid("0b5d8431-3ada-4071-8a26-d95c1d97b504"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SemesterId" },
                values: new object[] { new Guid("41be0b93-8931-42bb-97d3-57b3f7f7ccd5"), "Проектирование и дизайн информационных систем", new Guid("8e0022cb-dd42-4ba3-b5b5-c443858a5ca1") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("06c31dd8-0e86-450e-b237-2ae00de9653f"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("0e53e69e-d2b3-43e2-b591-cdf8ca2a136e"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("114af4ca-0b38-4beb-9fc8-9fa9087a943d"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("13786a7f-9a8b-40d5-b45e-0eedd876c18e"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("1f2dc88b-45f1-4fea-80b0-c7ad6f6a97b1"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("27187642-1682-44a3-8ba3-7e8392161360"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("2947dc96-6eca-4897-a97f-ea1693811e62"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("2d3dd94f-84c0-4bf8-93ca-1e3be98282a4"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("2f48910a-2d48-44fa-9e45-7a701d6d2ff4"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("312ebbf1-dc51-461a-8582-539ddd19a9d4"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("3553d855-5dc5-4b03-98f2-94759f9c7976"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("3c038712-5460-4080-94fb-3753d9eae46f"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("429b2e03-b8f9-47b5-87b5-2b36b683d26a"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("58c78b85-fd9b-4087-be9a-f0ee40d89cae"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("68db642e-4cb2-4d52-a528-64ab4f684f81"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("e6cfff90-e435-4d07-8af7-36c531cc0db1"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("e877546e-d6bb-4d31-99cc-60f025c32b92"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("efb4cb12-3e9b-4409-97d7-87dfe93a4b97"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("efd4d226-fa1f-4f9c-b128-b00acd4524b7"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("41be0b93-8931-42bb-97d3-57b3f7f7ccd5"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("088148d0-a45f-4877-b2f2-5c66399ae558"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("099d014f-82d6-458c-ab3c-5779ad024951"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("0b5d8431-3ada-4071-8a26-d95c1d97b504"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("0e3754c9-98df-40a2-9dfa-cd18c5cf3d46"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("3295510f-0a3c-4dfa-8479-27bbe7b157a4"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("6f70ddcd-b437-4f07-b32b-f551aaac2927"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("d2c5e3c5-a0be-47f2-92c6-4c6f5542898d"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("da924a5c-cdd3-4c10-907a-42702fe5871f"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("e6ec4ce3-3d0f-46dd-bd71-897c87dba9f4"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("8e0022cb-dd42-4ba3-b5b5-c443858a5ca1"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("b5c91b0c-503d-48f8-8290-947ef9c452e3"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("444a4b16-9a48-4a8a-a873-8401e59d7506"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("9e21bea4-5d74-4d10-8fcf-09d1ddcbc5c7"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("4d11b3ee-b8b3-44e5-b40d-613c0a7c4104"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("0f809a18-b7bf-49a1-b1f2-5d67e9d04448"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("f3b52d23-9ad0-41f5-ab38-82e40ada6299"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("23f6c36e-1a2a-4d3f-aa41-d1689d7f78e1"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("72614a3a-cfff-4c26-abce-f43d2f1bc325"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("3e9372df-7319-4924-83a1-20b1d1b8e848"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("4dbe7c6e-2218-4071-8837-699ff20baa24"));

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "Id",
                keyValue: new Guid("cc377952-3d95-4dab-9207-5a926887f1e5"));

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
    }
}
