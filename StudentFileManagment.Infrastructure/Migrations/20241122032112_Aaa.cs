using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentFileManagment.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Aaa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("001e0d09-5a70-4f5d-bef5-155d5699fa72"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("01b2e251-7fd0-4072-a0ab-92d8bba89aea"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("149ca383-7e54-422d-966c-217f35198b67"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("16e34bd1-ed4b-418f-bcc4-d55d15508989"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("177505d5-33a0-433a-8240-dbd8e5d34fce"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("1a51ccf0-4763-4317-afa2-0ebdb96ebe52"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("1d39b470-e65f-4901-856c-239c8703e55a"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("51ba16df-e980-4ce3-8da0-a85f24b58f82"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("65d0f32a-01ce-4a1c-9591-3fe89f15c0dc"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("6e0fc074-6235-4b26-9f55-614495ad7701"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("784f28db-1c82-493b-97b0-eaf1373438eb"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("81380f51-1feb-45ab-a94b-fba33eb7d47b"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("82dbe600-3f09-4cda-b262-3d4a7891bd01"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("950628e0-e89d-4d41-9cee-819bf0f951f2"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("a0edf15d-da2c-4e46-bc00-99db87094634"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("a7cf52c3-d18f-4c75-8f6f-857f36be1985"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("a9c22a4f-b126-48fb-913e-9d209eb79979"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("b1f89303-733e-4ffd-bba2-93f2591a4c61"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("e0879f37-6590-4be4-8012-2eac2f62e64c"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("466a4243-8a73-4536-a5df-0c55bea46eba"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("18398daa-9149-429a-a761-e6c76eb65dd8"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("1e30bf01-c0ef-4c23-91ab-fd8ec9e461f2"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("3bec3d2f-4b29-490a-84a9-a104ba4219d9"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("9f47b622-69fc-4414-a710-325364ce4e4e"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("aaacbb53-40a6-46b6-9557-be8c85a6354c"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("c4fcc62f-ae61-41da-aded-db3ca03eb63f"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("f7dc0e37-864d-4de0-b686-7cda0f64717f"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("f9f83d43-940b-4aba-ad57-8b3cd0044c51"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("fdfc575f-377b-4f5b-98e5-aff7363b9800"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("e25ee8b8-ef5a-423d-819c-cb7a5862a9ae"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("89013fb3-ace7-4bd1-bca1-abee97e7e753"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("0e15eb64-d669-4c14-b5e0-2e2e952c6520"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("c20ec013-6c94-44d0-a290-ff5b3ddbe26e"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("cc8dbf2f-e9c1-41dc-aedd-6fdfeec33997"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("b1ab7cf2-e1e1-4e96-869c-f96b93c05534"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("c6646a66-5158-44df-b3e0-597cb4b94732"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("274f0879-81b2-48b9-8c83-563129a433b2"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("ca75b47d-168c-48ae-97b1-1d64fbd279c1"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("ebe01add-2ac1-43b4-8957-8e7e95726871"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("b651de1c-b745-4acf-ac8f-b0b2c9a38ce5"));

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "Id",
                keyValue: new Guid("1258b06e-5775-4d50-b776-497a6056d3eb"));

            migrationBuilder.InsertData(
                table: "Educations",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0ca06734-c380-49f0-9494-43f32c554b68"), "Магистратура" },
                    { new Guid("12ad0b99-3533-44d2-ba69-af64448fe7fc"), "СПО" },
                    { new Guid("f8be468f-100b-4aab-93b4-cbf2b182010c"), "Бакалавриат" }
                });

            migrationBuilder.InsertData(
                table: "Institutions",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ef222af5-1e5e-48e0-9c30-23e448437b61"), "ВГЛТУ" });

            migrationBuilder.InsertData(
                table: "InstitutionAndEducations",
                columns: new[] { "Id", "EducationId", "InstitutionId" },
                values: new object[,]
                {
                    { new Guid("0947239c-7486-4a29-9169-fa108fc4d6f5"), new Guid("0ca06734-c380-49f0-9494-43f32c554b68"), new Guid("ef222af5-1e5e-48e0-9c30-23e448437b61") },
                    { new Guid("789f545c-95ba-4aed-9911-84ba308afe61"), new Guid("12ad0b99-3533-44d2-ba69-af64448fe7fc"), new Guid("ef222af5-1e5e-48e0-9c30-23e448437b61") },
                    { new Guid("96e55109-8353-4fc0-bcba-4220d50e1399"), new Guid("f8be468f-100b-4aab-93b4-cbf2b182010c"), new Guid("ef222af5-1e5e-48e0-9c30-23e448437b61") }
                });

            migrationBuilder.InsertData(
                table: "EducationDirections",
                columns: new[] { "Id", "InstitutionAndEducationId", "Name" },
                values: new object[,]
                {
                    { new Guid("0e9ada63-c621-48a2-89d2-df7eb0bfc38d"), new Guid("789f545c-95ba-4aed-9911-84ba308afe61"), "Информационные системы и программирование" },
                    { new Guid("545c1c90-c6ce-4fda-9e00-a799bb03a321"), new Guid("96e55109-8353-4fc0-bcba-4220d50e1399"), "Информационные системы и программирование" },
                    { new Guid("99c3f27c-cc25-48f5-adb5-944762dbac9d"), new Guid("0947239c-7486-4a29-9169-fa108fc4d6f5"), "Информационные системы и программирование" }
                });

            migrationBuilder.InsertData(
                table: "Cources",
                columns: new[] { "Id", "EducationDirectionId", "Number" },
                values: new object[,]
                {
                    { new Guid("019e8657-782f-4ed6-9022-2c7d3fba9f61"), new Guid("0e9ada63-c621-48a2-89d2-df7eb0bfc38d"), 1 },
                    { new Guid("0446d67d-2e72-4a36-996d-f3b394267566"), new Guid("99c3f27c-cc25-48f5-adb5-944762dbac9d"), 2 },
                    { new Guid("2008622c-d216-46f2-9ba8-85818c58830c"), new Guid("545c1c90-c6ce-4fda-9e00-a799bb03a321"), 2 },
                    { new Guid("4990bf26-a836-406b-96eb-7b1da4f6acd0"), new Guid("0e9ada63-c621-48a2-89d2-df7eb0bfc38d"), 2 },
                    { new Guid("b3279ac9-325e-4f06-9705-fe7300fd9c00"), new Guid("545c1c90-c6ce-4fda-9e00-a799bb03a321"), 4 },
                    { new Guid("c0b5c432-9272-43ce-b929-479a73c8378a"), new Guid("545c1c90-c6ce-4fda-9e00-a799bb03a321"), 1 },
                    { new Guid("d385d4ca-7033-45d2-90c7-bc818732ba26"), new Guid("0e9ada63-c621-48a2-89d2-df7eb0bfc38d"), 3 },
                    { new Guid("da81cc99-4753-4f69-9a12-f338cee686e8"), new Guid("545c1c90-c6ce-4fda-9e00-a799bb03a321"), 3 },
                    { new Guid("dee18e93-10e5-49bb-82fb-2bcdeb19b436"), new Guid("99c3f27c-cc25-48f5-adb5-944762dbac9d"), 1 },
                    { new Guid("e327543f-40b0-4cd6-9500-98e7e0d64170"), new Guid("0e9ada63-c621-48a2-89d2-df7eb0bfc38d"), 4 }
                });

            migrationBuilder.InsertData(
                table: "Semesters",
                columns: new[] { "Id", "CourceId", "Number" },
                values: new object[,]
                {
                    { new Guid("0d4030d5-dd4f-46d9-983c-1f7b2c66533b"), new Guid("4990bf26-a836-406b-96eb-7b1da4f6acd0"), 1 },
                    { new Guid("12ca5c70-019a-4e77-bdb4-24b2a2261259"), new Guid("da81cc99-4753-4f69-9a12-f338cee686e8"), 1 },
                    { new Guid("18fff53b-4b99-4e1d-a77f-327a00303d98"), new Guid("2008622c-d216-46f2-9ba8-85818c58830c"), 1 },
                    { new Guid("1e605be8-0c89-4ee2-93c3-8da83478d80c"), new Guid("d385d4ca-7033-45d2-90c7-bc818732ba26"), 2 },
                    { new Guid("215690c2-b086-46ee-8f04-de954581c69d"), new Guid("c0b5c432-9272-43ce-b929-479a73c8378a"), 2 },
                    { new Guid("2172952f-8ffd-48fc-84f4-778fac80f0c4"), new Guid("0446d67d-2e72-4a36-996d-f3b394267566"), 1 },
                    { new Guid("2e5e31c6-2706-4d2d-ad3b-5d4bb49901a1"), new Guid("da81cc99-4753-4f69-9a12-f338cee686e8"), 2 },
                    { new Guid("2e6bb430-bf2b-420e-8d85-e33c973e9525"), new Guid("2008622c-d216-46f2-9ba8-85818c58830c"), 2 },
                    { new Guid("53b228dc-8094-41f4-a793-372b350a4d1f"), new Guid("e327543f-40b0-4cd6-9500-98e7e0d64170"), 2 },
                    { new Guid("59dfc402-039d-4fc8-91d1-59ccf0cc62cd"), new Guid("d385d4ca-7033-45d2-90c7-bc818732ba26"), 1 },
                    { new Guid("7a3cc152-0027-4753-a0ae-dc561992d484"), new Guid("019e8657-782f-4ed6-9022-2c7d3fba9f61"), 1 },
                    { new Guid("92a78185-7f5a-440d-950a-f7c13f4e746f"), new Guid("b3279ac9-325e-4f06-9705-fe7300fd9c00"), 1 },
                    { new Guid("94ccf727-0fc5-48f9-8f1c-4f1f594efc7e"), new Guid("019e8657-782f-4ed6-9022-2c7d3fba9f61"), 2 },
                    { new Guid("a5e2d638-c0e4-4f5a-ae61-ade72dcb045b"), new Guid("dee18e93-10e5-49bb-82fb-2bcdeb19b436"), 2 },
                    { new Guid("ae9c04fd-13c7-4142-a437-e7c41876e722"), new Guid("dee18e93-10e5-49bb-82fb-2bcdeb19b436"), 1 },
                    { new Guid("bca8cbcb-5487-47bb-96ef-43d521ae4294"), new Guid("0446d67d-2e72-4a36-996d-f3b394267566"), 2 },
                    { new Guid("cac7fee5-cb3c-4a4b-bd07-d1d0f819c98a"), new Guid("4990bf26-a836-406b-96eb-7b1da4f6acd0"), 2 },
                    { new Guid("de775b18-1457-4907-a6fe-c675bcecf68e"), new Guid("c0b5c432-9272-43ce-b929-479a73c8378a"), 1 },
                    { new Guid("e9916923-abd8-4cba-b0b3-3e2e9b160bca"), new Guid("e327543f-40b0-4cd6-9500-98e7e0d64170"), 1 },
                    { new Guid("f42d1acf-bc2a-48c3-b9f3-55e3915e3053"), new Guid("b3279ac9-325e-4f06-9705-fe7300fd9c00"), 2 }
                });

            migrationBuilder.InsertData(
                table: "Subjects",
                columns: new[] { "Id", "Name", "SemesterId" },
                values: new object[] { new Guid("f3d765f0-d04f-4ad7-be1f-7fcac9d1e2b4"), "Проектирование и дизайн информационных систем", new Guid("0d4030d5-dd4f-46d9-983c-1f7b2c66533b") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("12ca5c70-019a-4e77-bdb4-24b2a2261259"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("18fff53b-4b99-4e1d-a77f-327a00303d98"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("1e605be8-0c89-4ee2-93c3-8da83478d80c"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("215690c2-b086-46ee-8f04-de954581c69d"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("2172952f-8ffd-48fc-84f4-778fac80f0c4"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("2e5e31c6-2706-4d2d-ad3b-5d4bb49901a1"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("2e6bb430-bf2b-420e-8d85-e33c973e9525"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("53b228dc-8094-41f4-a793-372b350a4d1f"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("59dfc402-039d-4fc8-91d1-59ccf0cc62cd"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("7a3cc152-0027-4753-a0ae-dc561992d484"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("92a78185-7f5a-440d-950a-f7c13f4e746f"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("94ccf727-0fc5-48f9-8f1c-4f1f594efc7e"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("a5e2d638-c0e4-4f5a-ae61-ade72dcb045b"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("ae9c04fd-13c7-4142-a437-e7c41876e722"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("bca8cbcb-5487-47bb-96ef-43d521ae4294"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("cac7fee5-cb3c-4a4b-bd07-d1d0f819c98a"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("de775b18-1457-4907-a6fe-c675bcecf68e"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("e9916923-abd8-4cba-b0b3-3e2e9b160bca"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("f42d1acf-bc2a-48c3-b9f3-55e3915e3053"));

            migrationBuilder.DeleteData(
                table: "Subjects",
                keyColumn: "Id",
                keyValue: new Guid("f3d765f0-d04f-4ad7-be1f-7fcac9d1e2b4"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("019e8657-782f-4ed6-9022-2c7d3fba9f61"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("0446d67d-2e72-4a36-996d-f3b394267566"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("2008622c-d216-46f2-9ba8-85818c58830c"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("b3279ac9-325e-4f06-9705-fe7300fd9c00"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("c0b5c432-9272-43ce-b929-479a73c8378a"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("d385d4ca-7033-45d2-90c7-bc818732ba26"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("da81cc99-4753-4f69-9a12-f338cee686e8"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("dee18e93-10e5-49bb-82fb-2bcdeb19b436"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("e327543f-40b0-4cd6-9500-98e7e0d64170"));

            migrationBuilder.DeleteData(
                table: "Semesters",
                keyColumn: "Id",
                keyValue: new Guid("0d4030d5-dd4f-46d9-983c-1f7b2c66533b"));

            migrationBuilder.DeleteData(
                table: "Cources",
                keyColumn: "Id",
                keyValue: new Guid("4990bf26-a836-406b-96eb-7b1da4f6acd0"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("545c1c90-c6ce-4fda-9e00-a799bb03a321"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("99c3f27c-cc25-48f5-adb5-944762dbac9d"));

            migrationBuilder.DeleteData(
                table: "EducationDirections",
                keyColumn: "Id",
                keyValue: new Guid("0e9ada63-c621-48a2-89d2-df7eb0bfc38d"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("0947239c-7486-4a29-9169-fa108fc4d6f5"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("96e55109-8353-4fc0-bcba-4220d50e1399"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("0ca06734-c380-49f0-9494-43f32c554b68"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("f8be468f-100b-4aab-93b4-cbf2b182010c"));

            migrationBuilder.DeleteData(
                table: "InstitutionAndEducations",
                keyColumn: "Id",
                keyValue: new Guid("789f545c-95ba-4aed-9911-84ba308afe61"));

            migrationBuilder.DeleteData(
                table: "Educations",
                keyColumn: "Id",
                keyValue: new Guid("12ad0b99-3533-44d2-ba69-af64448fe7fc"));

            migrationBuilder.DeleteData(
                table: "Institutions",
                keyColumn: "Id",
                keyValue: new Guid("ef222af5-1e5e-48e0-9c30-23e448437b61"));

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
        }
    }
}
