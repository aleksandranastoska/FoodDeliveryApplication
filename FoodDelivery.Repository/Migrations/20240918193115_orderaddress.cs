using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDelivery.Repository.Migrations
{
    /// <inheritdoc />
    public partial class orderaddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("04b1db63-c8a7-47c8-9437-62925f5d2cee"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("07c6e409-48c2-47a7-93b5-2706341d22ba"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("16018e6b-eebb-464d-a4e5-a5cfca3d92a8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2efb20c9-3c50-4ac2-b869-015e03738529"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3b2b2427-d40a-4e6f-98f6-930285cf1632"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4e447f00-0e01-4d35-911e-58d24ebaa0dd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("557e71e4-7aa3-42d0-8969-fcacc7aabce1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("764538a3-fd8b-41c1-801c-e164418c12c4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("85338b36-abcc-42e1-aa51-58af04dec3d9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8c2c89b5-48b1-40e1-84c1-84d31e3ae46c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d477f411-7846-4f0e-bfd4-f03e0d1ac3bf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f3edf42b-81f0-4449-906e-8a50086d655e"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("0caab6b8-2320-417b-8b01-a5e67a270528"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("0dad64f3-a369-46b5-886d-f2bb74d500ae"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("25f77294-5784-4302-97d6-e443712bfffd"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("49b5ef3e-38db-4288-8845-e812500b68fd"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("69ea4594-e20d-481f-96aa-ee60cbf51776"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("6c8db840-7dad-4aa5-95b7-99f5da87824b"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("79127a4a-5c60-42a8-9c59-468690e94c2c"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("8c70f60f-d4b7-4fce-aee8-02711dc1d495"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("95ca0dd0-8e49-491e-9b56-c776d9dbd3a8"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("995ec756-d536-4ec0-9e50-3f9f7829cb77"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("c1508fb7-7200-4253-93fc-c1b6838e0233"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("d1d7a6ec-7844-442c-b7b3-3b062a83fe4b"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("d626d3d1-8805-4c2a-8acf-00d7f8916ae0"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("e93ad38e-2ebe-4655-9772-b88ff23aaccf"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("f08fefc0-2216-452f-ae8a-c5466dc75295"));

            migrationBuilder.AddColumn<Guid>(
                name: "AddressId",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressId",
                table: "Orders",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_AddressId",
                table: "Orders");

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

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Orders");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("04b1db63-c8a7-47c8-9437-62925f5d2cee"), "../Images/vegetarian.png", "Vegetarian" },
                    { new Guid("07c6e409-48c2-47a7-93b5-2706341d22ba"), "../Images/american.png", "American" },
                    { new Guid("16018e6b-eebb-464d-a4e5-a5cfca3d92a8"), "../Images/greek.jfif", "Greek" },
                    { new Guid("2efb20c9-3c50-4ac2-b869-015e03738529"), "../Images/mexican.png", "Mexican" },
                    { new Guid("3b2b2427-d40a-4e6f-98f6-930285cf1632"), "../Images/desserts.png", "Desserts" },
                    { new Guid("4e447f00-0e01-4d35-911e-58d24ebaa0dd"), "../Images/chinese.png", "Chinese" },
                    { new Guid("557e71e4-7aa3-42d0-8969-fcacc7aabce1"), "../Images/vegan.png", "Vegan" },
                    { new Guid("764538a3-fd8b-41c1-801c-e164418c12c4"), "../Images/breakfast.png", "Breakfast" },
                    { new Guid("85338b36-abcc-42e1-aa51-58af04dec3d9"), "../Images/italian.png", "Italian" },
                    { new Guid("8c2c89b5-48b1-40e1-84c1-84d31e3ae46c"), "../Images/healthy.png", "Healthy" },
                    { new Guid("d477f411-7846-4f0e-bfd4-f03e0d1ac3bf"), "../Images/asian.png", "Asian" },
                    { new Guid("f3edf42b-81f0-4449-906e-8a50086d655e"), "../Images/indian.png", "Indian" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0caab6b8-2320-417b-8b01-a5e67a270528"), "Coffee" },
                    { new Guid("0dad64f3-a369-46b5-886d-f2bb74d500ae"), "Starters" },
                    { new Guid("25f77294-5784-4302-97d6-e443712bfffd"), "Main Course" },
                    { new Guid("49b5ef3e-38db-4288-8845-e812500b68fd"), "Desserts" },
                    { new Guid("69ea4594-e20d-481f-96aa-ee60cbf51776"), "Juices" },
                    { new Guid("6c8db840-7dad-4aa5-95b7-99f5da87824b"), "Salads" },
                    { new Guid("79127a4a-5c60-42a8-9c59-468690e94c2c"), "Alcoholic Beverages" },
                    { new Guid("8c70f60f-d4b7-4fce-aee8-02711dc1d495"), "Brunch" },
                    { new Guid("95ca0dd0-8e49-491e-9b56-c776d9dbd3a8"), "Soft Drinks" },
                    { new Guid("995ec756-d536-4ec0-9e50-3f9f7829cb77"), "Burgers" },
                    { new Guid("c1508fb7-7200-4253-93fc-c1b6838e0233"), "Hot Drinks" },
                    { new Guid("d1d7a6ec-7844-442c-b7b3-3b062a83fe4b"), "Breakfast" },
                    { new Guid("d626d3d1-8805-4c2a-8acf-00d7f8916ae0"), "Pizza" },
                    { new Guid("e93ad38e-2ebe-4655-9772-b88ff23aaccf"), "Pasta" },
                    { new Guid("f08fefc0-2216-452f-ae8a-c5466dc75295"), "Sandwiches" }
                });
        }
    }
}
