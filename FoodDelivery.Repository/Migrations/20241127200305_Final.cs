using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDelivery.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Final : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("00a68c38-bba0-4262-ba7a-9d03bbd18c29"), "../Images/asian.png", "Asian" },
                    { new Guid("0aae4d7d-7234-4fb7-86f1-f8611ed0d6e6"), "../Images/desserts.png", "Desserts" },
                    { new Guid("0fee258f-f438-40ff-959d-cfad8753b7a5"), "../Images/vegan.png", "Vegan" },
                    { new Guid("1db37b24-f7c4-4c0d-8de3-2c8ff669d232"), "../Images/vegetarian.png", "Vegetarian" },
                    { new Guid("5874eee4-137a-45e2-a379-efb79d4a5018"), "../Images/healthy.png", "Healthy" },
                    { new Guid("60f2687c-d2fc-431d-9b9b-4ae59c1e751b"), "../Images/american.png", "American" },
                    { new Guid("757edbe9-e29a-4af1-96b7-602609b90ac1"), "../Images/indian.png", "Indian" },
                    { new Guid("7b8514df-2879-4969-93f0-f7dfa35923b7"), "../Images/greek.jfif", "Greek" },
                    { new Guid("7c017b31-9774-44d3-888f-ae95dedbd308"), "../Images/mexican.png", "Mexican" },
                    { new Guid("8fad6114-f063-47fd-bd1d-c69986edfd21"), "../Images/italian.png", "Italian" },
                    { new Guid("96010e16-dc44-4cb5-a1bd-aac1ba73abfc"), "../Images/breakfast.png", "Breakfast" },
                    { new Guid("ab9b315a-a4c4-40e7-ab87-a3e77496c366"), "../Images/chinese.png", "Chinese" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2cb85a90-fdc6-4dd5-8c3c-f6606ccfa4b3"), "Starters" },
                    { new Guid("359592a1-3621-4848-be2a-66cf22963578"), "Coffee" },
                    { new Guid("3cb15651-deaa-4ce8-81e4-d638b6d88609"), "Breakfast" },
                    { new Guid("6e031bdc-de8a-4f6e-89fe-132cd565167f"), "Burgers" },
                    { new Guid("8cf54d9f-4dd3-4a69-8dd7-d32c0d3fcc8f"), "Brunch" },
                    { new Guid("9084ffb8-559e-4782-8253-9fc7ffc32cf4"), "Juices" },
                    { new Guid("91b1e7d0-084e-4767-b774-1d9da33bb932"), "Soft Drinks" },
                    { new Guid("a69ecc4b-2dac-4169-96b8-df3618f33cb7"), "Desserts" },
                    { new Guid("ab5d8210-83ac-4e60-a2f8-b59dd9928acc"), "Main Course" },
                    { new Guid("baf73acb-9c01-487c-b55c-8c7b35955266"), "Alcoholic Beverages" },
                    { new Guid("bbff7f30-402d-4d5a-9599-3df2edfa3b8b"), "Sandwiches" },
                    { new Guid("ccf0683d-6ec8-4208-a176-6fa87860e745"), "Hot Drinks" },
                    { new Guid("cd593ba3-35bb-4a6b-8694-2a08ee320c04"), "Pasta" },
                    { new Guid("ec9fdf8c-41d4-4514-8a97-c0d4d6f0c9ae"), "Pizza" },
                    { new Guid("edc65410-a5a6-4b28-9eda-b8cc0e7387ec"), "Salads" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00a68c38-bba0-4262-ba7a-9d03bbd18c29"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0aae4d7d-7234-4fb7-86f1-f8611ed0d6e6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0fee258f-f438-40ff-959d-cfad8753b7a5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1db37b24-f7c4-4c0d-8de3-2c8ff669d232"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5874eee4-137a-45e2-a379-efb79d4a5018"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("60f2687c-d2fc-431d-9b9b-4ae59c1e751b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("757edbe9-e29a-4af1-96b7-602609b90ac1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7b8514df-2879-4969-93f0-f7dfa35923b7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7c017b31-9774-44d3-888f-ae95dedbd308"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8fad6114-f063-47fd-bd1d-c69986edfd21"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("96010e16-dc44-4cb5-a1bd-aac1ba73abfc"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ab9b315a-a4c4-40e7-ab87-a3e77496c366"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("2cb85a90-fdc6-4dd5-8c3c-f6606ccfa4b3"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("359592a1-3621-4848-be2a-66cf22963578"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("3cb15651-deaa-4ce8-81e4-d638b6d88609"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("6e031bdc-de8a-4f6e-89fe-132cd565167f"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("8cf54d9f-4dd3-4a69-8dd7-d32c0d3fcc8f"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("9084ffb8-559e-4782-8253-9fc7ffc32cf4"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("91b1e7d0-084e-4767-b774-1d9da33bb932"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("a69ecc4b-2dac-4169-96b8-df3618f33cb7"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("ab5d8210-83ac-4e60-a2f8-b59dd9928acc"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("baf73acb-9c01-487c-b55c-8c7b35955266"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("bbff7f30-402d-4d5a-9599-3df2edfa3b8b"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("ccf0683d-6ec8-4208-a176-6fa87860e745"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("cd593ba3-35bb-4a6b-8694-2a08ee320c04"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("ec9fdf8c-41d4-4514-8a97-c0d4d6f0c9ae"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("edc65410-a5a6-4b28-9eda-b8cc0e7387ec"));

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
    }
}
