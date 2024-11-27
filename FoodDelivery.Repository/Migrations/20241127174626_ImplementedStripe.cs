using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDelivery.Repository.Migrations
{
    /// <inheritdoc />
    public partial class ImplementedStripe : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49909140-a95c-448e-8abd-5ce892a28913"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("604989ee-bd07-4b41-b5a3-833a1539ec96"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6dcaa933-b2b9-4ad0-800d-4cc4ee16c0ae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7f48a6e9-9182-40ca-b172-8fb799a03b66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8e03cbe7-20fa-4735-8b43-2a8b9dcd54ac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("97df656e-75dd-428b-9ecb-e8dd012d55d4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a5e520f9-e7d4-40fc-a3c6-80e0e63a451b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("abae47a3-97e8-4efb-ab28-94c65617ad74"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b2206ff6-a063-41ea-9d24-e79ee14d6742"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d09d4d8b-39e9-454b-83a3-3cf2fb869b6d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eefef9a5-d186-4859-b4f1-3cfbdccea8f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("faf38c0e-2684-4d22-92aa-4bd205d48077"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("03c495e0-f62c-4018-94d2-70236727a149"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("0f389b76-1051-47eb-bd9b-ff5a5d351ae3"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("1b870857-8ec8-42a3-a9e2-6069c6f960ed"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("1eebac13-2d52-4f1f-b0a1-5ef0ed99dd94"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("383a7619-3585-435a-a189-c7dd7dd168f0"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("558f19b6-dc79-49cd-a171-0c6760079ffd"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("6cba875c-e448-44d2-b7fd-c7988f8a8d20"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("889691b7-0d50-434d-8c62-cd0ea640a17c"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("a68c71bd-ec00-4801-a6e2-7c09552a6cf9"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("a947a6da-cf66-4a33-b718-7c8856b33ad9"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("b79366d0-0b02-4f93-8249-9214fc737c88"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("c8cfe882-aa85-47b4-aadb-5ecb096593aa"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("d885d5e1-5e61-465a-8a69-2dec3cf5b60a"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("e7727243-1403-4013-8eb1-c17fe7959b07"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("fc81990b-b07b-46fa-b4b9-8a7ff97b2a51"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("08a60845-cd70-4662-9226-da238c48cd70"), "../Images/desserts.png", "Desserts" },
                    { new Guid("19d21bc8-47b4-4caa-b756-a027c31a55c1"), "../Images/mexican.png", "Mexican" },
                    { new Guid("3045b2c5-c59c-43b2-91ad-20d1b4c69121"), "../Images/chinese.png", "Chinese" },
                    { new Guid("3da12252-f8b9-43ba-9be6-539bb882f967"), "../Images/greek.jfif", "Greek" },
                    { new Guid("575bbfbe-60f0-49ce-a3cf-dbdf6adfb463"), "../Images/healthy.png", "Healthy" },
                    { new Guid("64553ebf-80e3-42bf-b206-b8e35ab3c3bf"), "../Images/vegan.png", "Vegan" },
                    { new Guid("710229f3-686f-4b13-8913-d9f56e5cd759"), "../Images/italian.png", "Italian" },
                    { new Guid("88fa25b2-ef8c-44bd-91b1-437a7dd5084c"), "../Images/breakfast.png", "Breakfast" },
                    { new Guid("9a4fd450-22fa-4416-be48-20898476cb0f"), "../Images/asian.png", "Asian" },
                    { new Guid("ac4f01fe-ece4-49cc-938f-5562d8d3462c"), "../Images/american.png", "American" },
                    { new Guid("b387c001-d651-42c9-b833-64625db4b601"), "../Images/indian.png", "Indian" },
                    { new Guid("c05c710d-c8e6-4aba-b96c-c0b2bafe92be"), "../Images/vegetarian.png", "Vegetarian" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("036450d4-20be-42d1-b1e5-f29a33b81954"), "Main Course" },
                    { new Guid("0521c8cb-e081-4edb-beb4-ae2a10ba6f0a"), "Pasta" },
                    { new Guid("1e27f86c-72c7-4c7f-a5f5-f4ef65c1da3e"), "Burgers" },
                    { new Guid("2d18d0ff-919c-4e37-9590-4a1298c3c3d3"), "Brunch" },
                    { new Guid("4973ed8c-e1e7-4c7e-afba-f15c50626fda"), "Sandwiches" },
                    { new Guid("4e053558-888f-46e3-a6a7-0e459764f348"), "Soft Drinks" },
                    { new Guid("6435ce45-3fab-422f-97f8-1533770d6657"), "Starters" },
                    { new Guid("6dbf38e9-ea3c-4c6c-beb8-f718255ae8d5"), "Breakfast" },
                    { new Guid("71363c59-1ffd-414b-8260-a4bb73ff2fba"), "Juices" },
                    { new Guid("a1a2dd5a-35ad-4dcd-bddd-c3ec9c917473"), "Salads" },
                    { new Guid("bee1c023-c279-4a1f-bbc2-87aed191142c"), "Desserts" },
                    { new Guid("d034cd5a-b527-4b45-80d9-d0ec6f9b3859"), "Hot Drinks" },
                    { new Guid("d5b8f048-7b71-4b89-aa77-305ba24309d3"), "Coffee" },
                    { new Guid("e40ca626-9409-4a70-ae4f-4edfb1987ae1"), "Alcoholic Beverages" },
                    { new Guid("f464cf82-e37d-4564-b868-14a43856b824"), "Pizza" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("08a60845-cd70-4662-9226-da238c48cd70"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("19d21bc8-47b4-4caa-b756-a027c31a55c1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3045b2c5-c59c-43b2-91ad-20d1b4c69121"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3da12252-f8b9-43ba-9be6-539bb882f967"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("575bbfbe-60f0-49ce-a3cf-dbdf6adfb463"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("64553ebf-80e3-42bf-b206-b8e35ab3c3bf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("710229f3-686f-4b13-8913-d9f56e5cd759"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88fa25b2-ef8c-44bd-91b1-437a7dd5084c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a4fd450-22fa-4416-be48-20898476cb0f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ac4f01fe-ece4-49cc-938f-5562d8d3462c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b387c001-d651-42c9-b833-64625db4b601"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c05c710d-c8e6-4aba-b96c-c0b2bafe92be"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("036450d4-20be-42d1-b1e5-f29a33b81954"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("0521c8cb-e081-4edb-beb4-ae2a10ba6f0a"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("1e27f86c-72c7-4c7f-a5f5-f4ef65c1da3e"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("2d18d0ff-919c-4e37-9590-4a1298c3c3d3"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("4973ed8c-e1e7-4c7e-afba-f15c50626fda"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("4e053558-888f-46e3-a6a7-0e459764f348"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("6435ce45-3fab-422f-97f8-1533770d6657"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("6dbf38e9-ea3c-4c6c-beb8-f718255ae8d5"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("71363c59-1ffd-414b-8260-a4bb73ff2fba"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("a1a2dd5a-35ad-4dcd-bddd-c3ec9c917473"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("bee1c023-c279-4a1f-bbc2-87aed191142c"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("d034cd5a-b527-4b45-80d9-d0ec6f9b3859"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("d5b8f048-7b71-4b89-aa77-305ba24309d3"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("e40ca626-9409-4a70-ae4f-4edfb1987ae1"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("f464cf82-e37d-4564-b868-14a43856b824"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("49909140-a95c-448e-8abd-5ce892a28913"), "../Images/vegan.png", "Vegan" },
                    { new Guid("604989ee-bd07-4b41-b5a3-833a1539ec96"), "../Images/mexican.png", "Mexican" },
                    { new Guid("6dcaa933-b2b9-4ad0-800d-4cc4ee16c0ae"), "../Images/indian.png", "Indian" },
                    { new Guid("7f48a6e9-9182-40ca-b172-8fb799a03b66"), "../Images/vegetarian.png", "Vegetarian" },
                    { new Guid("8e03cbe7-20fa-4735-8b43-2a8b9dcd54ac"), "../Images/breakfast.png", "Breakfast" },
                    { new Guid("97df656e-75dd-428b-9ecb-e8dd012d55d4"), "../Images/greek.jfif", "Greek" },
                    { new Guid("a5e520f9-e7d4-40fc-a3c6-80e0e63a451b"), "../Images/american.png", "American" },
                    { new Guid("abae47a3-97e8-4efb-ab28-94c65617ad74"), "../Images/chinese.png", "Chinese" },
                    { new Guid("b2206ff6-a063-41ea-9d24-e79ee14d6742"), "../Images/healthy.png", "Healthy" },
                    { new Guid("d09d4d8b-39e9-454b-83a3-3cf2fb869b6d"), "../Images/asian.png", "Asian" },
                    { new Guid("eefef9a5-d186-4859-b4f1-3cfbdccea8f7"), "../Images/desserts.png", "Desserts" },
                    { new Guid("faf38c0e-2684-4d22-92aa-4bd205d48077"), "../Images/italian.png", "Italian" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("03c495e0-f62c-4018-94d2-70236727a149"), "Starters" },
                    { new Guid("0f389b76-1051-47eb-bd9b-ff5a5d351ae3"), "Alcoholic Beverages" },
                    { new Guid("1b870857-8ec8-42a3-a9e2-6069c6f960ed"), "Main Course" },
                    { new Guid("1eebac13-2d52-4f1f-b0a1-5ef0ed99dd94"), "Desserts" },
                    { new Guid("383a7619-3585-435a-a189-c7dd7dd168f0"), "Coffee" },
                    { new Guid("558f19b6-dc79-49cd-a171-0c6760079ffd"), "Breakfast" },
                    { new Guid("6cba875c-e448-44d2-b7fd-c7988f8a8d20"), "Sandwiches" },
                    { new Guid("889691b7-0d50-434d-8c62-cd0ea640a17c"), "Juices" },
                    { new Guid("a68c71bd-ec00-4801-a6e2-7c09552a6cf9"), "Pasta" },
                    { new Guid("a947a6da-cf66-4a33-b718-7c8856b33ad9"), "Brunch" },
                    { new Guid("b79366d0-0b02-4f93-8249-9214fc737c88"), "Pizza" },
                    { new Guid("c8cfe882-aa85-47b4-aadb-5ecb096593aa"), "Hot Drinks" },
                    { new Guid("d885d5e1-5e61-465a-8a69-2dec3cf5b60a"), "Salads" },
                    { new Guid("e7727243-1403-4013-8eb1-c17fe7959b07"), "Soft Drinks" },
                    { new Guid("fc81990b-b07b-46fa-b4b9-8a7ff97b2a51"), "Burgers" }
                });
        }
    }
}
