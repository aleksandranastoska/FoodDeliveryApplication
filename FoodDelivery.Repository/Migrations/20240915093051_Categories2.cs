using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDelivery.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Categories2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("15f5cc6c-f39b-4972-b0dd-6bd026ede949"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1d234a70-c79b-46a8-a7ef-48bf9676f984"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2043d9b8-4b25-4b58-974c-5ea75fc401ca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("26cce5eb-bf6a-4b6f-86ca-98ac1229345a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("276d7650-602a-45da-b688-47795a593825"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("44e5faf5-14a2-47d7-b7ee-09cdf7ebe86e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6d9fdda7-8608-44db-9e99-36aee797e63c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("74e9bd2b-2475-4f63-9204-8cbb28e24cd6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("763b0190-5d1b-4719-9859-e9076874dc35"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bb911ed5-8b88-4f41-9cff-991f256e8097"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d29b34e6-9ecb-4931-9271-8e60721afd0a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffca2d0b-9ddf-4f61-921e-a2c912434887"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("12e37f60-1f34-4d72-ab30-abef6466585c"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("1b5394cd-6386-40a9-84d2-a1833a9bb8f5"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("605cffa7-8dd3-4c2b-8e84-01d8d6f3ce4f"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("6c050399-09e3-4080-98f8-6ee4b81c6e9e"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("7de0ef2b-6834-4efc-9313-050c12c818b9"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("7e4ac0a9-efc3-4e57-84b7-aca83b5706f8"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("882b5982-63a3-440c-a181-205cb55ff6ec"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("92d80b43-76c3-4774-a92e-90db43b7d1a7"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("935eea15-e765-4adc-9a10-771814063a8a"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("96e723c9-5cf5-4fe8-920c-feeb1d00c173"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("98093d83-7b6a-4a2d-b2dc-764f0499e0e5"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("9f3beb1f-6d8f-4d94-adbb-445175210f41"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("a4aff9d0-def1-4141-808d-7f9e741616c1"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("a5f1ac25-f88e-4b24-966d-79ad5f797b12"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("fbdfb737-c870-47f5-b116-9cd5c2e56ba1"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("15f5cc6c-f39b-4972-b0dd-6bd026ede949"), "breakfast.jpg", "Breakfast" },
                    { new Guid("1d234a70-c79b-46a8-a7ef-48bf9676f984"), "asian.jpg", "Asian" },
                    { new Guid("2043d9b8-4b25-4b58-974c-5ea75fc401ca"), "vegan.jpg", "Vegan" },
                    { new Guid("26cce5eb-bf6a-4b6f-86ca-98ac1229345a"), "healthy.jpg", "Healthy" },
                    { new Guid("276d7650-602a-45da-b688-47795a593825"), "desserts.jpg", "Desserts" },
                    { new Guid("44e5faf5-14a2-47d7-b7ee-09cdf7ebe86e"), "chinese.jpg", "Chinese" },
                    { new Guid("6d9fdda7-8608-44db-9e99-36aee797e63c"), "indian.jpg", "Indian" },
                    { new Guid("74e9bd2b-2475-4f63-9204-8cbb28e24cd6"), "italian.jpg", "Italian" },
                    { new Guid("763b0190-5d1b-4719-9859-e9076874dc35"), "mexican.jpg", "Mexican" },
                    { new Guid("bb911ed5-8b88-4f41-9cff-991f256e8097"), "vegetarian.jpg", "Vegetarian" },
                    { new Guid("d29b34e6-9ecb-4931-9271-8e60721afd0a"), "american.jpg", "American" },
                    { new Guid("ffca2d0b-9ddf-4f61-921e-a2c912434887"), "greek.jpg", "Greek" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("12e37f60-1f34-4d72-ab30-abef6466585c"), "Salads" },
                    { new Guid("1b5394cd-6386-40a9-84d2-a1833a9bb8f5"), "Sandwiches" },
                    { new Guid("605cffa7-8dd3-4c2b-8e84-01d8d6f3ce4f"), "Hot Drinks" },
                    { new Guid("6c050399-09e3-4080-98f8-6ee4b81c6e9e"), "Pasta" },
                    { new Guid("7de0ef2b-6834-4efc-9313-050c12c818b9"), "Coffee" },
                    { new Guid("7e4ac0a9-efc3-4e57-84b7-aca83b5706f8"), "Brunch" },
                    { new Guid("882b5982-63a3-440c-a181-205cb55ff6ec"), "Desserts" },
                    { new Guid("92d80b43-76c3-4774-a92e-90db43b7d1a7"), "Juices" },
                    { new Guid("935eea15-e765-4adc-9a10-771814063a8a"), "Burgers" },
                    { new Guid("96e723c9-5cf5-4fe8-920c-feeb1d00c173"), "Breakfast" },
                    { new Guid("98093d83-7b6a-4a2d-b2dc-764f0499e0e5"), "Starters" },
                    { new Guid("9f3beb1f-6d8f-4d94-adbb-445175210f41"), "Main Course" },
                    { new Guid("a4aff9d0-def1-4141-808d-7f9e741616c1"), "Alcoholic Beverages" },
                    { new Guid("a5f1ac25-f88e-4b24-966d-79ad5f797b12"), "Pizza" },
                    { new Guid("fbdfb737-c870-47f5-b116-9cd5c2e56ba1"), "Soft Drinks" }
                });
        }
    }
}
