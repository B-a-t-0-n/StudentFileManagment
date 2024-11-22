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
                keyValue: new Guid("048fc602-06bd-4546-83fe-ac2dfd03bd06"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("0c1ae663-8ec3-4d4a-84e6-49c2ed69442f"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("11e05565-0801-4731-94f3-1eb56eec066b"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("1925dd62-44a2-4a27-b839-7e5d0d3dfb67"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("25b5ebf6-1943-42d1-9e2f-95513b69ad8e"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("38c96775-3563-4115-b14e-6a8e8f7ea33b"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("3edb59fc-a2c5-4a0e-8f2e-483e4b5522b6"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("4b9f5382-c8d7-4cf2-990e-ec744f588e42"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("5987f1b6-c471-46a7-8a37-5e8dbe651675"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("5e2d855a-2c91-40b7-bc32-28ce152413ab"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("5e6ce3d8-f3db-4628-93f5-608339dd059c"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("67f2ba2b-c62c-4ee1-a46f-3b085c01ec93"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("7d2bca41-ea57-4666-a789-9ce6976106c2"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("97e2d592-ceef-419b-af15-a509a775a858"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("a05d7b1b-3c08-4cbb-9b87-5b30a9988e36"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("b6bc29cc-b782-4aab-9402-344ec9ce599d"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("bb9408e2-cdd4-4dbe-9430-c806fdd1f1b7"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("d3a94cea-8e41-45a1-8255-ab31d27c3b46"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("da1947c5-f0a8-46f9-ae52-3b2ec892f795"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f8aa72d8-738c-47c6-9fd1-c48b02a8d586"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("1f07b9e0-f800-4d8b-a1cb-b02732b68bae"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("5eda3bd3-b1f1-4edb-9453-4fff11df7617"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("cfb0261e-d827-4f6e-8c64-fd251d2bf79b"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("d34c7208-9cc3-4dd9-860c-de5c472c4f93"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("d450f6f4-5bab-499f-a111-a376fad406e3"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("e149fc88-fb37-419b-a859-9b1e520165ae"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("eb4689fc-8497-4f02-ab68-ae0b6fc93738"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("edcc98af-c10c-4e0e-ad68-3e14f00ffba9"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("fe34a4b7-7cdc-46a7-91ba-59d3b0c13427"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("11d654eb-9b5d-4306-a943-47bdce930037"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("d6fa4a2d-c30c-42c2-a3f0-934041a02fa9"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("4e6e4bb6-0c77-4062-9608-c7fae54092a2"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("e988d82f-e651-44dc-895d-d9edaed12a86"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("75bc3e41-baf5-431a-93f9-7b624dceda44"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("3318a0f2-d00e-42f8-8306-d73093028e27"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("c8fa1238-cb3e-47d9-8c77-3a8f08ab8e2b"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("d32b6309-87ef-4c5a-bd2a-8e4ea6976d8e"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("dc53de74-366d-49b3-b931-2ebc0661a050"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("fb6c59c9-e801-407a-811d-de0e46e3ed43"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("4522c28e-14c4-4b30-a977-216851c83931"));

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "Id",
                keyValue: new Guid("e93635a6-1fc0-49ad-919a-1ece65082e2e"));

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("29da5a12-b661-4ddd-841f-42ca9e487c41"), "Магистратура" },
                    { new Guid("341ea082-a120-4710-9815-9acb47f58ec6"), "Бакалавриат" },
                    { new Guid("42276573-6062-4e7f-89e8-a1c13962a46f"), "СПО" }
                });

            migrationBuilder.InsertData(
                table: "Institutions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("65576c21-6e3e-4225-b63c-ac4d04b076bf"), "ВГЛТУ" });

            migrationBuilder.InsertData(
                table: "InstitutionAndEducations",
                columns: new[] { "Id", "EducationId", "InstitutionId" },
                values: new object[,]
                {
                    { new Guid("967abed4-8bda-49b0-b41f-e8413f445ee9"), new Guid("341ea082-a120-4710-9815-9acb47f58ec6"), new Guid("65576c21-6e3e-4225-b63c-ac4d04b076bf") },
                    { new Guid("b0735c1f-b9d3-4075-8d4c-ff28a955bf50"), new Guid("29da5a12-b661-4ddd-841f-42ca9e487c41"), new Guid("65576c21-6e3e-4225-b63c-ac4d04b076bf") },
                    { new Guid("dffa7668-2ec2-41d0-9d17-99c63980dcd3"), new Guid("42276573-6062-4e7f-89e8-a1c13962a46f"), new Guid("65576c21-6e3e-4225-b63c-ac4d04b076bf") }
                });

            migrationBuilder.InsertData(
                table: "EducationDirections",
                columns: new[] { "Id", "InstitutionAndEducationId", "Name" },
                values: new object[,]
                {
                    { new Guid("018cf2c7-646d-47bc-a6b7-43d74d738876"), new Guid("b0735c1f-b9d3-4075-8d4c-ff28a955bf50"), "Информационные системы и программирование" },
                    { new Guid("2b2d68f8-d5ff-4643-8479-ce2c4cb6665d"), new Guid("967abed4-8bda-49b0-b41f-e8413f445ee9"), "Информационные системы и программирование" },
                    { new Guid("4e33851d-9298-48ab-a5f4-16426b69ff99"), new Guid("dffa7668-2ec2-41d0-9d17-99c63980dcd3"), "Информационные системы и программирование" }
                });

            migrationBuilder.InsertData(
                table: "Cources",
                columns: new[] { "Id", "EducationDirectionId", "Number" },
                values: new object[,]
                {
                    { new Guid("3120e7ce-ca53-4fc1-bf56-1552eb487837"), new Guid("018cf2c7-646d-47bc-a6b7-43d74d738876"), 2 },
                    { new Guid("32ee008f-1573-490c-b1de-7f9fb00d31a1"), new Guid("4e33851d-9298-48ab-a5f4-16426b69ff99"), 2 },
                    { new Guid("341f7b16-7b23-42dc-bd28-6234ab3bc426"), new Guid("4e33851d-9298-48ab-a5f4-16426b69ff99"), 3 },
                    { new Guid("533ba51b-868e-4054-8ea8-a901287163b5"), new Guid("2b2d68f8-d5ff-4643-8479-ce2c4cb6665d"), 2 },
                    { new Guid("7d4b6ca5-a7fd-49c6-a7a2-0006d101ad55"), new Guid("2b2d68f8-d5ff-4643-8479-ce2c4cb6665d"), 4 },
                    { new Guid("8e6ca696-f421-4f6b-838f-560fdf32414e"), new Guid("018cf2c7-646d-47bc-a6b7-43d74d738876"), 1 },
                    { new Guid("b8c8439d-57df-4870-a861-47938e9a75dd"), new Guid("4e33851d-9298-48ab-a5f4-16426b69ff99"), 4 },
                    { new Guid("d2978955-8014-4130-9a62-8c6c2c53c722"), new Guid("2b2d68f8-d5ff-4643-8479-ce2c4cb6665d"), 1 },
                    { new Guid("fa6b9d42-79ec-4ced-9ef5-aed6caf5cec3"), new Guid("4e33851d-9298-48ab-a5f4-16426b69ff99"), 1 },
                    { new Guid("fe480e7a-00e9-4c3e-949f-d6f2041d62bd"), new Guid("2b2d68f8-d5ff-4643-8479-ce2c4cb6665d"), 3 }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CourceId", "Number" },
                values: new object[,]
                {
                    { new Guid("008f61ee-e39d-4f58-a671-c231aa12e6d0"), new Guid("533ba51b-868e-4054-8ea8-a901287163b5"), 2 },
                    { new Guid("086ab7bb-387c-4bf9-b1ac-9b19ac3ba806"), new Guid("3120e7ce-ca53-4fc1-bf56-1552eb487837"), 1 },
                    { new Guid("0e0076d8-c9eb-483b-9568-40abe2180c9b"), new Guid("d2978955-8014-4130-9a62-8c6c2c53c722"), 2 },
                    { new Guid("40cfc1b0-59bb-4215-9929-496adfbcf119"), new Guid("fa6b9d42-79ec-4ced-9ef5-aed6caf5cec3"), 1 },
                    { new Guid("42890e83-7634-4542-8a9d-0bb20f4c31e6"), new Guid("8e6ca696-f421-4f6b-838f-560fdf32414e"), 2 },
                    { new Guid("58f2dd28-5b59-410e-a9e6-c6692f5b548d"), new Guid("fe480e7a-00e9-4c3e-949f-d6f2041d62bd"), 2 },
                    { new Guid("6344e587-f811-40cb-86d2-34d98078173e"), new Guid("32ee008f-1573-490c-b1de-7f9fb00d31a1"), 2 },
                    { new Guid("68cc9936-8b42-46e9-afaa-2c876ac7962d"), new Guid("341f7b16-7b23-42dc-bd28-6234ab3bc426"), 1 },
                    { new Guid("72427a9a-d194-4441-b8e4-82f6ad976237"), new Guid("7d4b6ca5-a7fd-49c6-a7a2-0006d101ad55"), 2 },
                    { new Guid("77082d37-0412-48b6-82f4-4ad643c589b6"), new Guid("32ee008f-1573-490c-b1de-7f9fb00d31a1"), 1 },
                    { new Guid("89d34d16-560c-4abd-93b3-97d918cc797f"), new Guid("8e6ca696-f421-4f6b-838f-560fdf32414e"), 1 },
                    { new Guid("9713d17a-5c14-4901-b868-a9c5f705d19b"), new Guid("d2978955-8014-4130-9a62-8c6c2c53c722"), 1 },
                    { new Guid("99100956-2b7e-4a4e-942b-a1e477ad8482"), new Guid("3120e7ce-ca53-4fc1-bf56-1552eb487837"), 2 },
                    { new Guid("b555eae8-8fae-4ade-83a7-04e93c7dd557"), new Guid("341f7b16-7b23-42dc-bd28-6234ab3bc426"), 2 },
                    { new Guid("b65cbb59-4623-4a32-a3b1-6eaf6c23aeff"), new Guid("fa6b9d42-79ec-4ced-9ef5-aed6caf5cec3"), 2 },
                    { new Guid("d6bca7b5-ad34-46cc-bc71-e6ee3ed7aa8c"), new Guid("7d4b6ca5-a7fd-49c6-a7a2-0006d101ad55"), 1 },
                    { new Guid("f59dea25-3bcc-4bd8-bc1c-9dc3d1daf0e7"), new Guid("533ba51b-868e-4054-8ea8-a901287163b5"), 1 },
                    { new Guid("f91a78e0-11a1-4878-8503-6f32c081f6a8"), new Guid("fe480e7a-00e9-4c3e-949f-d6f2041d62bd"), 1 },
                    { new Guid("fa004cb7-3b3b-4e35-a9c2-fe534196db9d"), new Guid("b8c8439d-57df-4870-a861-47938e9a75dd"), 2 },
                    { new Guid("fd40017b-008e-478b-bb31-e6324f9237b2"), new Guid("b8c8439d-57df-4870-a861-47938e9a75dd"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SemesterId" },
                values: new object[] { new Guid("7c55f50a-339e-40b9-9402-7ec483c94c10"), "Проектирование и дизайн информационных систем", new Guid("77082d37-0412-48b6-82f4-4ad643c589b6") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("008f61ee-e39d-4f58-a671-c231aa12e6d0"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("086ab7bb-387c-4bf9-b1ac-9b19ac3ba806"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("0e0076d8-c9eb-483b-9568-40abe2180c9b"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("40cfc1b0-59bb-4215-9929-496adfbcf119"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("42890e83-7634-4542-8a9d-0bb20f4c31e6"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("58f2dd28-5b59-410e-a9e6-c6692f5b548d"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("6344e587-f811-40cb-86d2-34d98078173e"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("68cc9936-8b42-46e9-afaa-2c876ac7962d"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("72427a9a-d194-4441-b8e4-82f6ad976237"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("89d34d16-560c-4abd-93b3-97d918cc797f"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("9713d17a-5c14-4901-b868-a9c5f705d19b"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("99100956-2b7e-4a4e-942b-a1e477ad8482"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("b555eae8-8fae-4ade-83a7-04e93c7dd557"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("b65cbb59-4623-4a32-a3b1-6eaf6c23aeff"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("d6bca7b5-ad34-46cc-bc71-e6ee3ed7aa8c"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("f59dea25-3bcc-4bd8-bc1c-9dc3d1daf0e7"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("f91a78e0-11a1-4878-8503-6f32c081f6a8"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("fa004cb7-3b3b-4e35-a9c2-fe534196db9d"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("fd40017b-008e-478b-bb31-e6324f9237b2"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("7c55f50a-339e-40b9-9402-7ec483c94c10"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("3120e7ce-ca53-4fc1-bf56-1552eb487837"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("341f7b16-7b23-42dc-bd28-6234ab3bc426"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("533ba51b-868e-4054-8ea8-a901287163b5"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("7d4b6ca5-a7fd-49c6-a7a2-0006d101ad55"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("8e6ca696-f421-4f6b-838f-560fdf32414e"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("b8c8439d-57df-4870-a861-47938e9a75dd"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("d2978955-8014-4130-9a62-8c6c2c53c722"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("fa6b9d42-79ec-4ced-9ef5-aed6caf5cec3"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("fe480e7a-00e9-4c3e-949f-d6f2041d62bd"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("77082d37-0412-48b6-82f4-4ad643c589b6"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("32ee008f-1573-490c-b1de-7f9fb00d31a1"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("018cf2c7-646d-47bc-a6b7-43d74d738876"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("2b2d68f8-d5ff-4643-8479-ce2c4cb6665d"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("4e33851d-9298-48ab-a5f4-16426b69ff99"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("967abed4-8bda-49b0-b41f-e8413f445ee9"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("b0735c1f-b9d3-4075-8d4c-ff28a955bf50"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("29da5a12-b661-4ddd-841f-42ca9e487c41"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("341ea082-a120-4710-9815-9acb47f58ec6"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("dffa7668-2ec2-41d0-9d17-99c63980dcd3"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("42276573-6062-4e7f-89e8-a1c13962a46f"));

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "Id",
                keyValue: new Guid("65576c21-6e3e-4225-b63c-ac4d04b076bf"));

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("4522c28e-14c4-4b30-a977-216851c83931"), "СПО" },
                    { new Guid("d32b6309-87ef-4c5a-bd2a-8e4ea6976d8e"), "Магистратура" },
                    { new Guid("dc53de74-366d-49b3-b931-2ebc0661a050"), "Бакалавриат" }
                });

            migrationBuilder.InsertData(
                table: "Institutions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("e93635a6-1fc0-49ad-919a-1ece65082e2e"), "ВГЛТУ" });

            migrationBuilder.InsertData(
                table: "InstitutionAndEducations",
                columns: new[] { "Id", "EducationId", "InstitutionId" },
                values: new object[,]
                {
                    { new Guid("3318a0f2-d00e-42f8-8306-d73093028e27"), new Guid("d32b6309-87ef-4c5a-bd2a-8e4ea6976d8e"), new Guid("e93635a6-1fc0-49ad-919a-1ece65082e2e") },
                    { new Guid("c8fa1238-cb3e-47d9-8c77-3a8f08ab8e2b"), new Guid("dc53de74-366d-49b3-b931-2ebc0661a050"), new Guid("e93635a6-1fc0-49ad-919a-1ece65082e2e") },
                    { new Guid("fb6c59c9-e801-407a-811d-de0e46e3ed43"), new Guid("4522c28e-14c4-4b30-a977-216851c83931"), new Guid("e93635a6-1fc0-49ad-919a-1ece65082e2e") }
                });

            migrationBuilder.InsertData(
                table: "EducationDirections",
                columns: new[] { "Id", "InstitutionAndEducationId", "Name" },
                values: new object[,]
                {
                    { new Guid("4e6e4bb6-0c77-4062-9608-c7fae54092a2"), new Guid("c8fa1238-cb3e-47d9-8c77-3a8f08ab8e2b"), "Информационные системы и программирование" },
                    { new Guid("75bc3e41-baf5-431a-93f9-7b624dceda44"), new Guid("fb6c59c9-e801-407a-811d-de0e46e3ed43"), "Информационные системы и программирование" },
                    { new Guid("e988d82f-e651-44dc-895d-d9edaed12a86"), new Guid("3318a0f2-d00e-42f8-8306-d73093028e27"), "Информационные системы и программирование" }
                });

            migrationBuilder.InsertData(
                table: "Cources",
                columns: new[] { "Id", "EducationDirectionId", "Number" },
                values: new object[,]
                {
                    { new Guid("1f07b9e0-f800-4d8b-a1cb-b02732b68bae"), new Guid("4e6e4bb6-0c77-4062-9608-c7fae54092a2"), 3 },
                    { new Guid("5eda3bd3-b1f1-4edb-9453-4fff11df7617"), new Guid("e988d82f-e651-44dc-895d-d9edaed12a86"), 2 },
                    { new Guid("cfb0261e-d827-4f6e-8c64-fd251d2bf79b"), new Guid("4e6e4bb6-0c77-4062-9608-c7fae54092a2"), 4 },
                    { new Guid("d34c7208-9cc3-4dd9-860c-de5c472c4f93"), new Guid("e988d82f-e651-44dc-895d-d9edaed12a86"), 1 },
                    { new Guid("d450f6f4-5bab-499f-a111-a376fad406e3"), new Guid("4e6e4bb6-0c77-4062-9608-c7fae54092a2"), 1 },
                    { new Guid("d6fa4a2d-c30c-42c2-a3f0-934041a02fa9"), new Guid("75bc3e41-baf5-431a-93f9-7b624dceda44"), 2 },
                    { new Guid("e149fc88-fb37-419b-a859-9b1e520165ae"), new Guid("75bc3e41-baf5-431a-93f9-7b624dceda44"), 1 },
                    { new Guid("eb4689fc-8497-4f02-ab68-ae0b6fc93738"), new Guid("75bc3e41-baf5-431a-93f9-7b624dceda44"), 4 },
                    { new Guid("edcc98af-c10c-4e0e-ad68-3e14f00ffba9"), new Guid("4e6e4bb6-0c77-4062-9608-c7fae54092a2"), 2 },
                    { new Guid("fe34a4b7-7cdc-46a7-91ba-59d3b0c13427"), new Guid("75bc3e41-baf5-431a-93f9-7b624dceda44"), 3 }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CourceId", "Number" },
                values: new object[,]
                {
                    { new Guid("048fc602-06bd-4546-83fe-ac2dfd03bd06"), new Guid("5eda3bd3-b1f1-4edb-9453-4fff11df7617"), 1 },
                    { new Guid("0c1ae663-8ec3-4d4a-84e6-49c2ed69442f"), new Guid("eb4689fc-8497-4f02-ab68-ae0b6fc93738"), 1 },
                    { new Guid("11d654eb-9b5d-4306-a943-47bdce930037"), new Guid("d6fa4a2d-c30c-42c2-a3f0-934041a02fa9"), 1 },
                    { new Guid("11e05565-0801-4731-94f3-1eb56eec066b"), new Guid("cfb0261e-d827-4f6e-8c64-fd251d2bf79b"), 2 },
                    { new Guid("1925dd62-44a2-4a27-b839-7e5d0d3dfb67"), new Guid("fe34a4b7-7cdc-46a7-91ba-59d3b0c13427"), 1 },
                    { new Guid("25b5ebf6-1943-42d1-9e2f-95513b69ad8e"), new Guid("eb4689fc-8497-4f02-ab68-ae0b6fc93738"), 2 },
                    { new Guid("38c96775-3563-4115-b14e-6a8e8f7ea33b"), new Guid("edcc98af-c10c-4e0e-ad68-3e14f00ffba9"), 2 },
                    { new Guid("3edb59fc-a2c5-4a0e-8f2e-483e4b5522b6"), new Guid("cfb0261e-d827-4f6e-8c64-fd251d2bf79b"), 1 },
                    { new Guid("4b9f5382-c8d7-4cf2-990e-ec744f588e42"), new Guid("d450f6f4-5bab-499f-a111-a376fad406e3"), 1 },
                    { new Guid("5987f1b6-c471-46a7-8a37-5e8dbe651675"), new Guid("1f07b9e0-f800-4d8b-a1cb-b02732b68bae"), 2 },
                    { new Guid("5e2d855a-2c91-40b7-bc32-28ce152413ab"), new Guid("d6fa4a2d-c30c-42c2-a3f0-934041a02fa9"), 2 },
                    { new Guid("5e6ce3d8-f3db-4628-93f5-608339dd059c"), new Guid("e149fc88-fb37-419b-a859-9b1e520165ae"), 2 },
                    { new Guid("67f2ba2b-c62c-4ee1-a46f-3b085c01ec93"), new Guid("edcc98af-c10c-4e0e-ad68-3e14f00ffba9"), 1 },
                    { new Guid("7d2bca41-ea57-4666-a789-9ce6976106c2"), new Guid("d34c7208-9cc3-4dd9-860c-de5c472c4f93"), 2 },
                    { new Guid("97e2d592-ceef-419b-af15-a509a775a858"), new Guid("fe34a4b7-7cdc-46a7-91ba-59d3b0c13427"), 2 },
                    { new Guid("a05d7b1b-3c08-4cbb-9b87-5b30a9988e36"), new Guid("1f07b9e0-f800-4d8b-a1cb-b02732b68bae"), 1 },
                    { new Guid("b6bc29cc-b782-4aab-9402-344ec9ce599d"), new Guid("5eda3bd3-b1f1-4edb-9453-4fff11df7617"), 2 },
                    { new Guid("bb9408e2-cdd4-4dbe-9430-c806fdd1f1b7"), new Guid("d450f6f4-5bab-499f-a111-a376fad406e3"), 2 },
                    { new Guid("d3a94cea-8e41-45a1-8255-ab31d27c3b46"), new Guid("d34c7208-9cc3-4dd9-860c-de5c472c4f93"), 1 },
                    { new Guid("da1947c5-f0a8-46f9-ae52-3b2ec892f795"), new Guid("e149fc88-fb37-419b-a859-9b1e520165ae"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SemesterId" },
                values: new object[] { new Guid("f8aa72d8-738c-47c6-9fd1-c48b02a8d586"), "Проектирование и дизайн информационных систем", new Guid("11d654eb-9b5d-4306-a943-47bdce930037") });
        }
    }
}
