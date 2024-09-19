using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDelivery.Repository.Migrations
{
    /// <inheritdoc />
    public partial class foodcategories2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("06f7399c-a16e-4ea8-8ef2-6fe211f0e682"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("31f4de0d-ebcd-45c4-8f6d-2f66494adc34"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3c9fcc29-4c2a-4604-b4ed-6942c7d5982d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49302a31-dc28-4814-b31d-a6e0c006b52b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("54b684ec-43ff-4a33-ab50-d3b14d23b6b8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6576b682-c71e-4e28-921b-f7b36d9047e0"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("714ff1b1-d5c8-48fb-ac38-7a1b2b5d30b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("89587414-29cc-4652-b5be-0a8cda692f0d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9b5ac6be-5381-4ee6-a9b4-c6a5a972f1a2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bd04e6f4-e669-4152-83c6-4876ebdf3a8d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c393f130-7469-4e5f-a6dd-a67930a2d783"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d686abc8-9347-4bcb-a049-7b186f833c99"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("274202e6-e4a2-44b9-a19d-255569189574"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("2874c5ed-3a9d-4070-9f30-f782d247a0b0"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("2c194d43-dd6b-4bdd-b89b-da62f939ff16"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("37e162b3-5379-4d67-a400-118ea3c05a8c"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("3e9b526c-62de-4bfb-8a6b-4de93fbbbfb5"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("60309f06-0abc-46a8-b367-dc8848707162"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("65167f47-ef80-4f12-9ce8-d69fd77b810f"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("986ad34f-062a-4cfc-9110-9be2d0082117"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("a9215ab6-d7a1-40b4-936a-532c89864fe5"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("bd5c0dca-fb22-4d0f-bf3f-33f6c53dc6b7"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("e750494c-5d80-4632-ac76-2bf68ec43386"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("f0ab1c4d-e8a4-4711-9906-fbcc641cf1a0"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("f1507d9e-d603-41b2-8a50-3e240544d586"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("f6447345-aaf6-4288-8d2d-4add5aaeee07"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("feeba90d-ddf9-43c6-b1a2-b67f2aa3a15a"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("01746e01-ca3b-4c8a-a441-59f8159dd06a"), "../Images/american.png", "American" },
                    { new Guid("1b542084-0197-44b8-8607-6f89793c5834"), "../Images/breakfast.png", "Breakfast" },
                    { new Guid("297f7826-cc6c-4e1e-9e96-c95cf4ee6da4"), "../Images/chinese.png", "Chinese" },
                    { new Guid("301b4320-4151-466f-970f-860425d79a09"), "../Images/mexican.png", "Mexican" },
                    { new Guid("30976ea7-96c6-4d5c-bb17-87be99cdec44"), "../Images/vegetarian.png", "Vegetarian" },
                    { new Guid("37fcebf7-c93e-4740-9a67-a24b553a53ad"), "../Images/healthy.png", "Healthy" },
                    { new Guid("43e2b9d4-bab7-4813-8174-a4edc47e6dfb"), "../Images/vegan.png", "Vegan" },
                    { new Guid("7e6d3545-47d5-4c91-809c-c04ea23889a8"), "../Images/greek.jfif", "Greek" },
                    { new Guid("b3883314-07f3-48a6-9207-328f7b105825"), "../Images/desserts.png", "Desserts" },
                    { new Guid("c2eef234-7c83-49cb-84d7-c64248116dc3"), "../Images/italian.png", "Italian" },
                    { new Guid("eff4f5a4-6eb6-446f-9452-c275fde7cb52"), "../Images/asian.png", "Asian" },
                    { new Guid("f8239c04-a15a-4bc4-a6f3-e6ddc481e939"), "../Images/indian.png", "Indian" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1131a63b-b78f-45a6-b21a-d6c041698138"), "Pizza" },
                    { new Guid("1b71ee17-8257-48f3-95ab-b5231fc18c2f"), "Breakfast" },
                    { new Guid("25aa873e-f4d0-4f0f-ae6a-9e3c39bff046"), "Alcoholic Beverages" },
                    { new Guid("28f406b2-593e-4d5a-8c03-10dcdca21e5b"), "Hot Drinks" },
                    { new Guid("34850a93-1dc4-4540-bd0c-065b475c0d86"), "Sandwiches" },
                    { new Guid("40a11c63-48df-4adb-afd8-0730a843db04"), "Soft Drinks" },
                    { new Guid("46e915c6-d1cb-408a-9660-9725ff9886e8"), "Desserts" },
                    { new Guid("689e7919-3b78-4cb4-9533-ec167b12573f"), "Salads" },
                    { new Guid("8723329a-8d87-4a01-b407-c1585ce27f5a"), "Brunch" },
                    { new Guid("94d2d82f-6b31-46ba-a484-48d6288ca7b9"), "Juices" },
                    { new Guid("bb758570-43b4-4259-9009-5633339a8b24"), "Starters" },
                    { new Guid("c37fc0f8-530b-49b5-b241-a843d40944d7"), "Pasta" },
                    { new Guid("e4db70d6-6262-4e1b-ae79-8c5375a78349"), "Coffee" },
                    { new Guid("e521e90d-901c-4250-8ef6-d5712648fb51"), "Burgers" },
                    { new Guid("ef1659a4-d6b0-4501-b208-7486467c4d4d"), "Main Course" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01746e01-ca3b-4c8a-a441-59f8159dd06a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b542084-0197-44b8-8607-6f89793c5834"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("297f7826-cc6c-4e1e-9e96-c95cf4ee6da4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("301b4320-4151-466f-970f-860425d79a09"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("30976ea7-96c6-4d5c-bb17-87be99cdec44"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37fcebf7-c93e-4740-9a67-a24b553a53ad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43e2b9d4-bab7-4813-8174-a4edc47e6dfb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e6d3545-47d5-4c91-809c-c04ea23889a8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3883314-07f3-48a6-9207-328f7b105825"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c2eef234-7c83-49cb-84d7-c64248116dc3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eff4f5a4-6eb6-446f-9452-c275fde7cb52"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f8239c04-a15a-4bc4-a6f3-e6ddc481e939"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("1131a63b-b78f-45a6-b21a-d6c041698138"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("1b71ee17-8257-48f3-95ab-b5231fc18c2f"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("25aa873e-f4d0-4f0f-ae6a-9e3c39bff046"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("28f406b2-593e-4d5a-8c03-10dcdca21e5b"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("34850a93-1dc4-4540-bd0c-065b475c0d86"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("40a11c63-48df-4adb-afd8-0730a843db04"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("46e915c6-d1cb-408a-9660-9725ff9886e8"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("689e7919-3b78-4cb4-9533-ec167b12573f"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("8723329a-8d87-4a01-b407-c1585ce27f5a"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("94d2d82f-6b31-46ba-a484-48d6288ca7b9"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("bb758570-43b4-4259-9009-5633339a8b24"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("c37fc0f8-530b-49b5-b241-a843d40944d7"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("e4db70d6-6262-4e1b-ae79-8c5375a78349"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("e521e90d-901c-4250-8ef6-d5712648fb51"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("ef1659a4-d6b0-4501-b208-7486467c4d4d"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("06f7399c-a16e-4ea8-8ef2-6fe211f0e682"), "../Images/healthy.png", "Healthy" },
                    { new Guid("31f4de0d-ebcd-45c4-8f6d-2f66494adc34"), "../Images/chinese.png", "Chinese" },
                    { new Guid("3c9fcc29-4c2a-4604-b4ed-6942c7d5982d"), "../Images/vegan.png", "Vegan" },
                    { new Guid("49302a31-dc28-4814-b31d-a6e0c006b52b"), "../Images/desserts.png", "Desserts" },
                    { new Guid("54b684ec-43ff-4a33-ab50-d3b14d23b6b8"), "../Images/mexican.png", "Mexican" },
                    { new Guid("6576b682-c71e-4e28-921b-f7b36d9047e0"), "../Images/asian.png", "Asian" },
                    { new Guid("714ff1b1-d5c8-48fb-ac38-7a1b2b5d30b2"), "../Images/breakfast.png", "Breakfast" },
                    { new Guid("89587414-29cc-4652-b5be-0a8cda692f0d"), "../Images/indian.png", "Indian" },
                    { new Guid("9b5ac6be-5381-4ee6-a9b4-c6a5a972f1a2"), "../Images/italian.png", "Italian" },
                    { new Guid("bd04e6f4-e669-4152-83c6-4876ebdf3a8d"), "../Images/vegetarian.png", "Vegetarian" },
                    { new Guid("c393f130-7469-4e5f-a6dd-a67930a2d783"), "../Images/american.png", "American" },
                    { new Guid("d686abc8-9347-4bcb-a049-7b186f833c99"), "../Images/greek.jfif", "Greek" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("274202e6-e4a2-44b9-a19d-255569189574"), "Breakfast" },
                    { new Guid("2874c5ed-3a9d-4070-9f30-f782d247a0b0"), "Brunch" },
                    { new Guid("2c194d43-dd6b-4bdd-b89b-da62f939ff16"), "Juices" },
                    { new Guid("37e162b3-5379-4d67-a400-118ea3c05a8c"), "Burgers" },
                    { new Guid("3e9b526c-62de-4bfb-8a6b-4de93fbbbfb5"), "Sandwiches" },
                    { new Guid("60309f06-0abc-46a8-b367-dc8848707162"), "Desserts" },
                    { new Guid("65167f47-ef80-4f12-9ce8-d69fd77b810f"), "Alcoholic Beverages" },
                    { new Guid("986ad34f-062a-4cfc-9110-9be2d0082117"), "Hot Drinks" },
                    { new Guid("a9215ab6-d7a1-40b4-936a-532c89864fe5"), "Soft Drinks" },
                    { new Guid("bd5c0dca-fb22-4d0f-bf3f-33f6c53dc6b7"), "Starters" },
                    { new Guid("e750494c-5d80-4632-ac76-2bf68ec43386"), "Pasta" },
                    { new Guid("f0ab1c4d-e8a4-4711-9906-fbcc641cf1a0"), "Salads" },
                    { new Guid("f1507d9e-d603-41b2-8a50-3e240544d586"), "Main Course" },
                    { new Guid("f6447345-aaf6-4288-8d2d-4add5aaeee07"), "Coffee" },
                    { new Guid("feeba90d-ddf9-43c6-b1a2-b67f2aa3a15a"), "Pizza" }
                });
        }
    }
}
