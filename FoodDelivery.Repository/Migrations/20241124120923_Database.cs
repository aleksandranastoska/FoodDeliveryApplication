using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDelivery.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Database : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1221b41d-d47f-4f15-84be-5ad9b102cde8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3e129d97-f161-4d4e-b36c-0faaf64dec81"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7796a6f3-34ed-4dff-95c3-1621ae247a66"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("845c2c76-ac76-48b9-b40e-34fabd5c280b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("88aa04e4-becd-4493-948d-4602e7cf54f7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("945ee943-2235-4d87-9657-7bd93ea75e2b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca662c08-4550-4dbc-b8af-1e7115fe347e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca67057d-4e89-42fc-85ed-a333091935c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d8b55955-d833-4af1-85d6-45de6378c707"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d955df1f-1142-4d37-b383-796c36bee97d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("df65e69e-bb0a-4f95-aeeb-e6f214031b9e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eb07a81a-c291-4bf3-880e-8d3ae8fb9c25"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("223282a4-886c-4ad1-89cf-430c37245f86"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("25b39bbc-bed9-48fe-9d58-11023ff550be"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("32c191f9-d5aa-4bcc-8ad9-f54c4e1820be"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("3b0ec47b-26a7-466c-9e2c-d8cb197257d7"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("76ac6ab1-52f5-416e-a0bf-6dbe90682d19"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("80845bdd-2fba-4fcf-ac5e-4d7d81d7ad6b"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("8769386e-0d3c-48af-96f2-372e6101abb1"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("994a821a-3646-4a2d-aff0-9ec79acd8f0c"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("9be9623e-36cd-4863-a958-db69456f868f"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("aeba8cf9-0046-463e-bd66-1544afebbd6d"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("c0864636-ca63-4d78-87c2-25e9ffc1cc6a"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("c961e24f-9b53-462f-b2d4-681cb87aee1f"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("e015f570-572a-4e71-b8c6-3a0aa9c4635f"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0799c20-d08b-4588-9c0b-4de898d591b5"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("f397e044-3c22-4c83-b3d6-be76a5c8806e"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("1221b41d-d47f-4f15-84be-5ad9b102cde8"), "../Images/healthy.png", "Healthy" },
                    { new Guid("3e129d97-f161-4d4e-b36c-0faaf64dec81"), "../Images/mexican.png", "Mexican" },
                    { new Guid("7796a6f3-34ed-4dff-95c3-1621ae247a66"), "../Images/breakfast.png", "Breakfast" },
                    { new Guid("845c2c76-ac76-48b9-b40e-34fabd5c280b"), "../Images/desserts.png", "Desserts" },
                    { new Guid("88aa04e4-becd-4493-948d-4602e7cf54f7"), "../Images/asian.png", "Asian" },
                    { new Guid("945ee943-2235-4d87-9657-7bd93ea75e2b"), "../Images/chinese.png", "Chinese" },
                    { new Guid("ca662c08-4550-4dbc-b8af-1e7115fe347e"), "../Images/vegan.png", "Vegan" },
                    { new Guid("ca67057d-4e89-42fc-85ed-a333091935c9"), "../Images/vegetarian.png", "Vegetarian" },
                    { new Guid("d8b55955-d833-4af1-85d6-45de6378c707"), "../Images/indian.png", "Indian" },
                    { new Guid("d955df1f-1142-4d37-b383-796c36bee97d"), "../Images/italian.png", "Italian" },
                    { new Guid("df65e69e-bb0a-4f95-aeeb-e6f214031b9e"), "../Images/american.png", "American" },
                    { new Guid("eb07a81a-c291-4bf3-880e-8d3ae8fb9c25"), "../Images/greek.jfif", "Greek" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("223282a4-886c-4ad1-89cf-430c37245f86"), "Burgers" },
                    { new Guid("25b39bbc-bed9-48fe-9d58-11023ff550be"), "Coffee" },
                    { new Guid("32c191f9-d5aa-4bcc-8ad9-f54c4e1820be"), "Desserts" },
                    { new Guid("3b0ec47b-26a7-466c-9e2c-d8cb197257d7"), "Main Course" },
                    { new Guid("76ac6ab1-52f5-416e-a0bf-6dbe90682d19"), "Brunch" },
                    { new Guid("80845bdd-2fba-4fcf-ac5e-4d7d81d7ad6b"), "Salads" },
                    { new Guid("8769386e-0d3c-48af-96f2-372e6101abb1"), "Alcoholic Beverages" },
                    { new Guid("994a821a-3646-4a2d-aff0-9ec79acd8f0c"), "Breakfast" },
                    { new Guid("9be9623e-36cd-4863-a958-db69456f868f"), "Hot Drinks" },
                    { new Guid("aeba8cf9-0046-463e-bd66-1544afebbd6d"), "Starters" },
                    { new Guid("c0864636-ca63-4d78-87c2-25e9ffc1cc6a"), "Juices" },
                    { new Guid("c961e24f-9b53-462f-b2d4-681cb87aee1f"), "Sandwiches" },
                    { new Guid("e015f570-572a-4e71-b8c6-3a0aa9c4635f"), "Pizza" },
                    { new Guid("f0799c20-d08b-4588-9c0b-4de898d591b5"), "Soft Drinks" },
                    { new Guid("f397e044-3c22-4c83-b3d6-be76a5c8806e"), "Pasta" }
                });
        }
    }
}
