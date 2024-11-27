using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDelivery.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01a67b4c-9209-4b07-a79a-5662a86dddc8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("020558e8-de25-4614-9a25-98f06bc1fe2a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3407100d-84b5-460e-aff0-500270a9890d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("39913ac2-3d19-402d-a2b6-bfe812ca6002"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("430ac5bb-538a-48c8-b7d3-acd8aeeac29f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47d7c20f-2b58-478f-bae4-86663f243c1a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5360ef5d-ab8d-48d0-b707-c1e2f2d82247"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8246aa33-a908-4076-828f-0834fca13259"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("99303db5-e273-4c8a-b330-0da6bb87b358"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3c2682a-fb43-45bc-bf23-7648565dd755"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c4a6f3c2-82f4-4aa4-a914-39fdde2cb9aa"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f3fd17ca-31fb-4ee9-8adb-a798d63e92c7"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("103beeef-e0bb-44b7-aa30-f6775c7620e8"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("17c7ea51-960f-4844-99ab-bbe46f2f259a"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("26de6d45-d62b-49b7-b0b6-5fbb8798ea84"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("34a95f8a-2a2b-48d6-9ea0-2b5281dc8d7c"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("3895227d-61c9-4ab3-a39a-feb0214f57f2"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("4a5a1573-23b3-4761-9123-65a0384cf1b2"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("4b00593c-a191-4a2e-96da-57c81fcd5999"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("4f080ebb-6f1a-4c64-8d05-9d9d329908ec"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("8d548878-7c7a-4fb6-990c-cee2a3a95dec"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("a2635d53-0862-4941-82df-67e2f727e807"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("c80e6c68-49f4-45c3-9021-50704b474f46"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("db8fab4d-e2c7-4520-9e7f-26b4d207cdff"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("e0bb69fe-a6bc-4c58-a344-8a652ea83dab"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("f9c90629-9a1e-4ff3-a9fe-152259fb9b6d"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("fd69d569-beb8-47be-9d8a-10d7516a52ab"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("01a67b4c-9209-4b07-a79a-5662a86dddc8"), "../Images/chinese.png", "Chinese" },
                    { new Guid("020558e8-de25-4614-9a25-98f06bc1fe2a"), "../Images/italian.png", "Italian" },
                    { new Guid("3407100d-84b5-460e-aff0-500270a9890d"), "../Images/indian.png", "Indian" },
                    { new Guid("39913ac2-3d19-402d-a2b6-bfe812ca6002"), "../Images/healthy.png", "Healthy" },
                    { new Guid("430ac5bb-538a-48c8-b7d3-acd8aeeac29f"), "../Images/asian.png", "Asian" },
                    { new Guid("47d7c20f-2b58-478f-bae4-86663f243c1a"), "../Images/desserts.png", "Desserts" },
                    { new Guid("5360ef5d-ab8d-48d0-b707-c1e2f2d82247"), "../Images/breakfast.png", "Breakfast" },
                    { new Guid("8246aa33-a908-4076-828f-0834fca13259"), "../Images/mexican.png", "Mexican" },
                    { new Guid("99303db5-e273-4c8a-b330-0da6bb87b358"), "../Images/american.png", "American" },
                    { new Guid("b3c2682a-fb43-45bc-bf23-7648565dd755"), "../Images/vegetarian.png", "Vegetarian" },
                    { new Guid("c4a6f3c2-82f4-4aa4-a914-39fdde2cb9aa"), "../Images/greek.jfif", "Greek" },
                    { new Guid("f3fd17ca-31fb-4ee9-8adb-a798d63e92c7"), "../Images/vegan.png", "Vegan" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("103beeef-e0bb-44b7-aa30-f6775c7620e8"), "Coffee" },
                    { new Guid("17c7ea51-960f-4844-99ab-bbe46f2f259a"), "Alcoholic Beverages" },
                    { new Guid("26de6d45-d62b-49b7-b0b6-5fbb8798ea84"), "Pizza" },
                    { new Guid("34a95f8a-2a2b-48d6-9ea0-2b5281dc8d7c"), "Starters" },
                    { new Guid("3895227d-61c9-4ab3-a39a-feb0214f57f2"), "Juices" },
                    { new Guid("4a5a1573-23b3-4761-9123-65a0384cf1b2"), "Burgers" },
                    { new Guid("4b00593c-a191-4a2e-96da-57c81fcd5999"), "Main Course" },
                    { new Guid("4f080ebb-6f1a-4c64-8d05-9d9d329908ec"), "Hot Drinks" },
                    { new Guid("8d548878-7c7a-4fb6-990c-cee2a3a95dec"), "Desserts" },
                    { new Guid("a2635d53-0862-4941-82df-67e2f727e807"), "Sandwiches" },
                    { new Guid("c80e6c68-49f4-45c3-9021-50704b474f46"), "Breakfast" },
                    { new Guid("db8fab4d-e2c7-4520-9e7f-26b4d207cdff"), "Soft Drinks" },
                    { new Guid("e0bb69fe-a6bc-4c58-a344-8a652ea83dab"), "Pasta" },
                    { new Guid("f9c90629-9a1e-4ff3-a9fe-152259fb9b6d"), "Salads" },
                    { new Guid("fd69d569-beb8-47be-9d8a-10d7516a52ab"), "Brunch" }
                });
        }
    }
}
