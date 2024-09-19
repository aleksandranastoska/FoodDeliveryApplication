using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDelivery.Repository.Migrations
{
    /// <inheritdoc />
    public partial class RestaurantImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0e78a8ba-3ece-4c8a-9aac-4b89a627b387"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ed54c17-242a-422a-8dec-d9b4e2458e44"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1ff749fc-84de-4e17-a5f2-50729b01d477"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("251fc0db-938c-4313-bcf9-ce6fa53c6217"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("52fecafd-0337-48a7-acb1-235ced024aca"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60705633-8f10-4892-a2ec-efdbe14cd0ec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6cf72789-a673-45b0-a102-9f099d7c2b97"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a4badf53-5d2e-4f69-a997-558bd938db45"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d2c585ea-6e80-4abf-91c9-0e83baea2d8a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d54d69ec-a01a-40df-bad4-0cd5547fc634"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d651ab1b-cef2-4db0-94e5-e0303b2fda20"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("dba2474f-c42b-4eac-9c07-2f14e0728fe7"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("02a21863-600a-4289-b850-abfdefa2d151"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("1232522d-628e-4a62-a9d6-d70a16cc0975"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("2168a8a4-34f8-49b4-bdf3-71b4764a7f33"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("391afc2a-3bd8-4c96-b8e5-911cebd49f09"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("3ceb2b3a-1e4f-48a1-b064-d4660b0d6741"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("52e71a8c-5aa8-4bad-b18d-d888fa0026d4"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("58518393-014d-4cdc-a7c7-3a1da775a992"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("630fc521-5b63-4cd4-99b8-9eea377542c2"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("6a871b3d-484a-4304-b95b-d3c5715a3ee1"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("ab48720a-5cc1-4586-8774-cf848f3df1f3"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("af833888-1ba5-49f5-b2b9-49f6f3a7ffcb"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("cb0b21f3-51e8-4f80-91e9-b36f3c8dde72"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("d5ff2a03-e375-4c33-bb02-15452073faa9"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("e9326043-cfd6-4cbf-b5dd-5f6f887df569"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("fd06fc83-9fa8-4298-b098-92058bd1cbaa"));

            migrationBuilder.AddColumn<string>(
                name: "RestaurantImage",
                table: "Restaurants",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "RestaurantImage",
                table: "Restaurants");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("0e78a8ba-3ece-4c8a-9aac-4b89a627b387"), "mexican.jpg", "Mexican" },
                    { new Guid("1ed54c17-242a-422a-8dec-d9b4e2458e44"), "italian.jpg", "Italian" },
                    { new Guid("1ff749fc-84de-4e17-a5f2-50729b01d477"), "breakfast.jpg", "Breakfast" },
                    { new Guid("251fc0db-938c-4313-bcf9-ce6fa53c6217"), "indian.jpg", "Indian" },
                    { new Guid("52fecafd-0337-48a7-acb1-235ced024aca"), "american.jpg", "American" },
                    { new Guid("60705633-8f10-4892-a2ec-efdbe14cd0ec"), "vegetarian.jpg", "Vegetarian" },
                    { new Guid("6cf72789-a673-45b0-a102-9f099d7c2b97"), "asian.jpg", "Asian" },
                    { new Guid("a4badf53-5d2e-4f69-a997-558bd938db45"), "healthy.jpg", "Healthy" },
                    { new Guid("d2c585ea-6e80-4abf-91c9-0e83baea2d8a"), "chinese.jpg", "Chinese" },
                    { new Guid("d54d69ec-a01a-40df-bad4-0cd5547fc634"), "greek.jpg", "Greek" },
                    { new Guid("d651ab1b-cef2-4db0-94e5-e0303b2fda20"), "desserts.jpg", "Desserts" },
                    { new Guid("dba2474f-c42b-4eac-9c07-2f14e0728fe7"), "vegan.jpg", "Vegan" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("02a21863-600a-4289-b850-abfdefa2d151"), "Salads" },
                    { new Guid("1232522d-628e-4a62-a9d6-d70a16cc0975"), "Main Course" },
                    { new Guid("2168a8a4-34f8-49b4-bdf3-71b4764a7f33"), "Coffee" },
                    { new Guid("391afc2a-3bd8-4c96-b8e5-911cebd49f09"), "Sandwiches" },
                    { new Guid("3ceb2b3a-1e4f-48a1-b064-d4660b0d6741"), "Juices" },
                    { new Guid("52e71a8c-5aa8-4bad-b18d-d888fa0026d4"), "Hot Drinks" },
                    { new Guid("58518393-014d-4cdc-a7c7-3a1da775a992"), "Breakfast" },
                    { new Guid("630fc521-5b63-4cd4-99b8-9eea377542c2"), "Soft Drinks" },
                    { new Guid("6a871b3d-484a-4304-b95b-d3c5715a3ee1"), "Starters" },
                    { new Guid("ab48720a-5cc1-4586-8774-cf848f3df1f3"), "Pizza" },
                    { new Guid("af833888-1ba5-49f5-b2b9-49f6f3a7ffcb"), "Burgers" },
                    { new Guid("cb0b21f3-51e8-4f80-91e9-b36f3c8dde72"), "Alcoholic Beverages" },
                    { new Guid("d5ff2a03-e375-4c33-bb02-15452073faa9"), "Brunch" },
                    { new Guid("e9326043-cfd6-4cbf-b5dd-5f6f887df569"), "Desserts" },
                    { new Guid("fd06fc83-9fa8-4298-b098-92058bd1cbaa"), "Pasta" }
                });
        }
    }
}
