using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDelivery.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UserRoleAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0b2f5077-0455-4220-895f-44ed0e5c76ab"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("11ab992f-96f8-4b03-81cc-9565c5957bc6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("484d5db2-80ba-48e3-bcc6-966aa4d7a548"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("49fe0301-ee0f-4e2a-be96-1dd9aeb910f9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("900dea7c-499d-46e1-a9cc-c32278e4c1f4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("982ed4e9-8132-4fbc-a343-ba61aa2ef788"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a985725a-e058-49a9-a9a6-9deb308b8ead"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a9f90f96-7b65-44ac-8d1c-af7671fdc782"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca6fe31a-ab69-43ad-b8bf-ed622b5f5422"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cd5f105c-092c-4716-8e4c-ba0770015ee6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cdc6a2fc-5f40-467a-9296-85457875b393"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f8fb0615-cb93-4839-9158-911ced49faac"));

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Role",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("0b2f5077-0455-4220-895f-44ed0e5c76ab"), "italian.jpg", "Italian" },
                    { new Guid("11ab992f-96f8-4b03-81cc-9565c5957bc6"), "vegan.jpg", "Vegan" },
                    { new Guid("484d5db2-80ba-48e3-bcc6-966aa4d7a548"), "vegetarian.jpg", "Vegetarian" },
                    { new Guid("49fe0301-ee0f-4e2a-be96-1dd9aeb910f9"), "desserts.jpg", "Desserts" },
                    { new Guid("900dea7c-499d-46e1-a9cc-c32278e4c1f4"), "greek.jpg", "Greek" },
                    { new Guid("982ed4e9-8132-4fbc-a343-ba61aa2ef788"), "american.jpg", "American" },
                    { new Guid("a985725a-e058-49a9-a9a6-9deb308b8ead"), "indian.jpg", "Indian" },
                    { new Guid("a9f90f96-7b65-44ac-8d1c-af7671fdc782"), "asian.jpg", "Asian" },
                    { new Guid("ca6fe31a-ab69-43ad-b8bf-ed622b5f5422"), "healthy.jpg", "Healthy" },
                    { new Guid("cd5f105c-092c-4716-8e4c-ba0770015ee6"), "chinese.jpg", "Chinese" },
                    { new Guid("cdc6a2fc-5f40-467a-9296-85457875b393"), "breakfast.jpg", "Breakfast" },
                    { new Guid("f8fb0615-cb93-4839-9158-911ced49faac"), "mexican.jpg", "Mexican" }
                });
        }
    }
}
