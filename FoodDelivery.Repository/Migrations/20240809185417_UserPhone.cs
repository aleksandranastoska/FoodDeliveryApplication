using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDelivery.Repository.Migrations
{
    /// <inheritdoc />
    public partial class UserPhone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("1c091413-343a-4619-808d-cd8d0a1f3235"), "vegetarian.jpg", "Vegetarian" },
                    { new Guid("23d513ae-1ff9-4dbb-997f-102ecc100933"), "breakfast.jpg", "Breakfast" },
                    { new Guid("329f8886-2a01-447b-9c0c-82dfc43cd598"), "asian.jpg", "Asian" },
                    { new Guid("52d1e2d6-0f6b-4bb4-b0ed-962424e23fe2"), "indian.jpg", "Indian" },
                    { new Guid("57099bc3-3729-409b-9984-971c5ca0bcf5"), "greek.jpg", "Greek" },
                    { new Guid("67b9d731-e429-4e07-b78a-5c7b287f7947"), "american.jpg", "American" },
                    { new Guid("7a43efa3-39e5-4c92-a4ff-a2bb744d719b"), "italian.jpg", "Italian" },
                    { new Guid("9a46896e-8432-46ad-969e-e361d3bacb88"), "healthy.jpg", "Healthy" },
                    { new Guid("9f9bb46a-4e78-45cd-b9ae-01357862387d"), "vegan.jpg", "Vegan" },
                    { new Guid("cd4b8192-0d21-42b1-aef1-8d66cac01473"), "chinese.jpg", "Chinese" },
                    { new Guid("e9a49937-97c3-42f9-97fc-c9beb10ba2e7"), "desserts.jpg", "Desserts" },
                    { new Guid("fa9e2e7c-10f3-47e4-8093-032449d23d0e"), "mexican.jpg", "Mexican" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1c091413-343a-4619-808d-cd8d0a1f3235"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("23d513ae-1ff9-4dbb-997f-102ecc100933"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("329f8886-2a01-447b-9c0c-82dfc43cd598"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("52d1e2d6-0f6b-4bb4-b0ed-962424e23fe2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("57099bc3-3729-409b-9984-971c5ca0bcf5"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("67b9d731-e429-4e07-b78a-5c7b287f7947"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7a43efa3-39e5-4c92-a4ff-a2bb744d719b"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9a46896e-8432-46ad-969e-e361d3bacb88"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9f9bb46a-4e78-45cd-b9ae-01357862387d"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cd4b8192-0d21-42b1-aef1-8d66cac01473"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e9a49937-97c3-42f9-97fc-c9beb10ba2e7"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("fa9e2e7c-10f3-47e4-8093-032449d23d0e"));

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }
    }
}
