using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDelivery.Repository.Migrations
{
    /// <inheritdoc />
    public partial class FixOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1e62d490-81d3-4cf1-827a-4d0a64d46212"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("310b214d-82bd-4943-9525-17788c7ccfec"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5e414e8c-e3b7-42b0-a59e-a81ca4e3127b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7621333a-3bc2-4d1a-b8ec-e883313c5742"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("84886685-38dc-4d64-b992-37e7947e8600"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8baec1ab-6bc4-400c-b1b8-f90bc0957884"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a164d43f-1df5-4fbe-adc6-7134a97e22f2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a7cd10c1-4ec4-4fe8-9673-90416736bd2b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b5074f24-fb2a-493a-a34e-aa4a1b987074"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bc033c9a-f8bc-46b3-a4ed-eed20b83cff9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ce5fb02c-1aa4-4b5f-9e7e-aa48a7336515"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e4a58d3d-bd7e-4586-bd67-448b450308fb"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("0bac2a2d-7581-4803-9bc9-f165a92de540"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("140603b7-3f87-48cb-b193-0a29be192313"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("32cf1593-e114-4bc5-8b8c-db0c7ee54df0"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("4283d0f6-02b7-4926-b5b0-7226ab5c4841"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("5a737934-93e7-410b-b44d-17c761631dbc"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("5ec1053c-50b4-4546-b1d4-f0d77d598c08"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("95dd8dac-5ce0-4814-80bb-f133b64eb7d0"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("a1e861b7-86a6-4f5f-81f1-612488b0fdb5"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("a7102bd8-f75e-4a76-a1be-8e922a7f9e8a"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("bfc68038-b613-4479-8991-b033a4d4d6a9"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("c6db7bd5-0b25-44b5-9e58-6ae3fbbb26e6"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("cc6fc09e-7961-4960-b00b-a5071477ca7d"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("d3ac0d97-c4c4-4543-8fc0-7c34227fe608"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("d431eeea-ef68-49f6-b1d6-33c9c74bff75"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("f1938b19-cc95-492f-8b83-a81213407b2b"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("1e62d490-81d3-4cf1-827a-4d0a64d46212"), "../Images/asian.png", "Asian" },
                    { new Guid("310b214d-82bd-4943-9525-17788c7ccfec"), "../Images/vegan.png", "Vegan" },
                    { new Guid("5e414e8c-e3b7-42b0-a59e-a81ca4e3127b"), "../Images/indian.png", "Indian" },
                    { new Guid("7621333a-3bc2-4d1a-b8ec-e883313c5742"), "../Images/chinese.png", "Chinese" },
                    { new Guid("84886685-38dc-4d64-b992-37e7947e8600"), "../Images/breakfast.png", "Breakfast" },
                    { new Guid("8baec1ab-6bc4-400c-b1b8-f90bc0957884"), "../Images/desserts.png", "Desserts" },
                    { new Guid("a164d43f-1df5-4fbe-adc6-7134a97e22f2"), "../Images/greek.jfif", "Greek" },
                    { new Guid("a7cd10c1-4ec4-4fe8-9673-90416736bd2b"), "../Images/healthy.png", "Healthy" },
                    { new Guid("b5074f24-fb2a-493a-a34e-aa4a1b987074"), "../Images/mexican.png", "Mexican" },
                    { new Guid("bc033c9a-f8bc-46b3-a4ed-eed20b83cff9"), "../Images/vegetarian.png", "Vegetarian" },
                    { new Guid("ce5fb02c-1aa4-4b5f-9e7e-aa48a7336515"), "../Images/american.png", "American" },
                    { new Guid("e4a58d3d-bd7e-4586-bd67-448b450308fb"), "../Images/italian.png", "Italian" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0bac2a2d-7581-4803-9bc9-f165a92de540"), "Burgers" },
                    { new Guid("140603b7-3f87-48cb-b193-0a29be192313"), "Coffee" },
                    { new Guid("32cf1593-e114-4bc5-8b8c-db0c7ee54df0"), "Hot Drinks" },
                    { new Guid("4283d0f6-02b7-4926-b5b0-7226ab5c4841"), "Desserts" },
                    { new Guid("5a737934-93e7-410b-b44d-17c761631dbc"), "Juices" },
                    { new Guid("5ec1053c-50b4-4546-b1d4-f0d77d598c08"), "Salads" },
                    { new Guid("95dd8dac-5ce0-4814-80bb-f133b64eb7d0"), "Alcoholic Beverages" },
                    { new Guid("a1e861b7-86a6-4f5f-81f1-612488b0fdb5"), "Breakfast" },
                    { new Guid("a7102bd8-f75e-4a76-a1be-8e922a7f9e8a"), "Pizza" },
                    { new Guid("bfc68038-b613-4479-8991-b033a4d4d6a9"), "Starters" },
                    { new Guid("c6db7bd5-0b25-44b5-9e58-6ae3fbbb26e6"), "Pasta" },
                    { new Guid("cc6fc09e-7961-4960-b00b-a5071477ca7d"), "Sandwiches" },
                    { new Guid("d3ac0d97-c4c4-4543-8fc0-7c34227fe608"), "Brunch" },
                    { new Guid("d431eeea-ef68-49f6-b1d6-33c9c74bff75"), "Main Course" },
                    { new Guid("f1938b19-cc95-492f-8b83-a81213407b2b"), "Soft Drinks" }
                });
        }
    }
}
