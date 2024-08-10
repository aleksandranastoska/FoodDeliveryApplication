using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDelivery.Repository.Migrations
{
    /// <inheritdoc />
    public partial class RestaurantOwner : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ac8553b-126c-45ae-8d67-170d647300ae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("2ebd26d1-95e3-4ae9-b732-52f9564da294"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3050f8ee-ebcf-4e71-a067-3bb454ff02f3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("311e8239-86e1-4213-a64d-deba6f074283"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("407ce132-34d2-4628-835b-e8c33a18d32c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7dedb68b-e61d-4e39-a9a4-2ca64c33c6d2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e5759bc-9dd1-4b58-bb60-79f707a18147"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aa5db008-0440-47cb-9fcd-3c638f4f8639"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1112f05-4d6e-41ae-a78a-4611d6044652"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d69afa0e-810b-44ad-94a2-23224779b7d7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ea458488-880f-40ad-89d0-8038efcce21a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ed12cdb5-ba1a-466d-af91-f495a8fd15bc"));

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Restaurants",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("05bc536f-14d8-49d8-8806-1e3a49d3c041"), "italian.jpg", "Italian" },
                    { new Guid("3b57b1fd-8e59-4027-a652-24dc147b1e71"), "chinese.jpg", "Chinese" },
                    { new Guid("50f90525-5a30-49d7-ad4a-8a063429476b"), "indian.jpg", "Indian" },
                    { new Guid("6cd92d05-6a28-4dba-ba59-1e26b9dcc4ff"), "greek.jpg", "Greek" },
                    { new Guid("80432401-7215-411d-a6fe-799d8bea4b00"), "vegetarian.jpg", "Vegetarian" },
                    { new Guid("90b7f384-54d0-43d5-915d-531ccd599492"), "mexican.jpg", "Mexican" },
                    { new Guid("a38cecbf-643d-4bcd-a546-63750f0f4f5c"), "desserts.jpg", "Desserts" },
                    { new Guid("aea320f8-5389-42f8-af02-91b406ed9cc7"), "asian.jpg", "Asian" },
                    { new Guid("b7b0bb30-f41c-424c-83fa-ca4c49500fbf"), "healthy.jpg", "Healthy" },
                    { new Guid("eb4e3e31-afb5-438d-b73c-4eb27df26c29"), "breakfast.jpg", "Breakfast" },
                    { new Guid("f6602b6e-2b2e-43b6-a6fb-9a39c9aacd40"), "vegan.jpg", "Vegan" },
                    { new Guid("fa88acaa-1479-414a-a279-d4726bdb4684"), "american.jpg", "American" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_OwnerId",
                table: "Restaurants",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_AspNetUsers_OwnerId",
                table: "Restaurants",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_AspNetUsers_OwnerId",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_OwnerId",
                table: "Restaurants");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("05bc536f-14d8-49d8-8806-1e3a49d3c041"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3b57b1fd-8e59-4027-a652-24dc147b1e71"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("50f90525-5a30-49d7-ad4a-8a063429476b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6cd92d05-6a28-4dba-ba59-1e26b9dcc4ff"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("80432401-7215-411d-a6fe-799d8bea4b00"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("90b7f384-54d0-43d5-915d-531ccd599492"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a38cecbf-643d-4bcd-a546-63750f0f4f5c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("aea320f8-5389-42f8-af02-91b406ed9cc7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b7b0bb30-f41c-424c-83fa-ca4c49500fbf"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eb4e3e31-afb5-438d-b73c-4eb27df26c29"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6602b6e-2b2e-43b6-a6fb-9a39c9aacd40"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa88acaa-1479-414a-a279-d4726bdb4684"));

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Restaurants");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("2ac8553b-126c-45ae-8d67-170d647300ae"), "vegetarian.jpg", "Vegetarian" },
                    { new Guid("2ebd26d1-95e3-4ae9-b732-52f9564da294"), "breakfast.jpg", "Breakfast" },
                    { new Guid("3050f8ee-ebcf-4e71-a067-3bb454ff02f3"), "american.jpg", "American" },
                    { new Guid("311e8239-86e1-4213-a64d-deba6f074283"), "indian.jpg", "Indian" },
                    { new Guid("407ce132-34d2-4628-835b-e8c33a18d32c"), "italian.jpg", "Italian" },
                    { new Guid("7dedb68b-e61d-4e39-a9a4-2ca64c33c6d2"), "asian.jpg", "Asian" },
                    { new Guid("7e5759bc-9dd1-4b58-bb60-79f707a18147"), "mexican.jpg", "Mexican" },
                    { new Guid("aa5db008-0440-47cb-9fcd-3c638f4f8639"), "chinese.jpg", "Chinese" },
                    { new Guid("c1112f05-4d6e-41ae-a78a-4611d6044652"), "healthy.jpg", "Healthy" },
                    { new Guid("d69afa0e-810b-44ad-94a2-23224779b7d7"), "desserts.jpg", "Desserts" },
                    { new Guid("ea458488-880f-40ad-89d0-8038efcce21a"), "greek.jpg", "Greek" },
                    { new Guid("ed12cdb5-ba1a-466d-af91-f495a8fd15bc"), "vegan.jpg", "Vegan" }
                });
        }
    }
}
