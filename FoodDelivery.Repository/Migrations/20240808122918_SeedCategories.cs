using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDelivery.Repository.Migrations
{
    /// <inheritdoc />
    public partial class SeedCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
