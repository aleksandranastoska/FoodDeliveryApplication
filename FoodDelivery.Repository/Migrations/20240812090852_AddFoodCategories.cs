using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDelivery.Repository.Migrations
{
    /// <inheritdoc />
    public partial class AddFoodCategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "FoodCategoryId",
                table: "Foods",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "FoodCategories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategories", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("09383e83-3d6c-4b6c-9a1f-b3ab673667fb"), "healthy.jpg", "Healthy" },
                    { new Guid("1cd0ae48-2bb8-4cf7-8fa3-42691b8d1b70"), "asian.jpg", "Asian" },
                    { new Guid("3a4d3462-6458-418a-8a0b-cd5c16e63548"), "chinese.jpg", "Chinese" },
                    { new Guid("47399d80-4aa2-4a70-9a0b-83aaa04909eb"), "indian.jpg", "Indian" },
                    { new Guid("81308382-0d2c-49b9-83fd-c52b1183eb51"), "vegetarian.jpg", "Vegetarian" },
                    { new Guid("8f3a5db5-b268-47ed-871f-2f35a7cf66cd"), "mexican.jpg", "Mexican" },
                    { new Guid("a2e088da-e338-4194-a70e-2970d69f7164"), "desserts.jpg", "Desserts" },
                    { new Guid("b4f5f679-f570-4b21-b14e-7313de863ac8"), "greek.jpg", "Greek" },
                    { new Guid("c2150289-066e-431a-a55a-e41adbdccc3c"), "vegan.jpg", "Vegan" },
                    { new Guid("c9900113-0447-4af8-b401-347189a853d6"), "italian.jpg", "Italian" },
                    { new Guid("d280fd46-614e-4d4b-b58c-01b0d81d9b59"), "american.jpg", "American" },
                    { new Guid("ee62be3c-79d8-409a-b121-73af49641046"), "breakfast.jpg", "Breakfast" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1096a2f9-a75e-4c6a-a26c-4442a219a753"), "Breakfast" },
                    { new Guid("1687f0f2-158f-487f-90aa-5ee084a8c561"), "Brunch" },
                    { new Guid("24a5d8bc-b123-44c6-af7e-aafea5a40151"), "Soft Drinks" },
                    { new Guid("32f9d6e3-6d56-4362-a028-473058070322"), "Alcoholic Beverages" },
                    { new Guid("387c4800-1092-4808-abf2-c256674d489a"), "Pasta" },
                    { new Guid("3d5e124f-795c-484d-a1e1-9e3dbbe056cf"), "Desserts" },
                    { new Guid("556ef99b-f76b-419e-93f7-95a675a619ba"), "Burgers" },
                    { new Guid("7d1d8aef-d217-41e3-b4f0-8f7c7cb4a814"), "Hot Drinks" },
                    { new Guid("8660c831-2d09-4af1-b54d-49b7e1638434"), "Salads" },
                    { new Guid("895488aa-2322-414e-b0cf-379e9f571be2"), "Coffee" },
                    { new Guid("9bbb8900-ef9b-4b61-a7bf-ae0c6986a783"), "Starters" },
                    { new Guid("9e019ef1-f0e5-4f2a-bef4-75dfeaaf680a"), "Sandwiches" },
                    { new Guid("c66e1223-ead4-4c77-80c9-3806f90cf44f"), "Pizza" },
                    { new Guid("d730c473-dee2-4127-bc82-ea63509eefc6"), "Main Course" },
                    { new Guid("f4e1967e-6623-480e-91b0-366a2fd2378d"), "Juices" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_FoodCategoryId",
                table: "Foods",
                column: "FoodCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_FoodCategories_FoodCategoryId",
                table: "Foods",
                column: "FoodCategoryId",
                principalTable: "FoodCategories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_FoodCategories_FoodCategoryId",
                table: "Foods");

            migrationBuilder.DropTable(
                name: "FoodCategories");

            migrationBuilder.DropIndex(
                name: "IX_Foods_FoodCategoryId",
                table: "Foods");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("09383e83-3d6c-4b6c-9a1f-b3ab673667fb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1cd0ae48-2bb8-4cf7-8fa3-42691b8d1b70"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3a4d3462-6458-418a-8a0b-cd5c16e63548"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("47399d80-4aa2-4a70-9a0b-83aaa04909eb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("81308382-0d2c-49b9-83fd-c52b1183eb51"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8f3a5db5-b268-47ed-871f-2f35a7cf66cd"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a2e088da-e338-4194-a70e-2970d69f7164"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b4f5f679-f570-4b21-b14e-7313de863ac8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c2150289-066e-431a-a55a-e41adbdccc3c"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c9900113-0447-4af8-b401-347189a853d6"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d280fd46-614e-4d4b-b58c-01b0d81d9b59"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ee62be3c-79d8-409a-b121-73af49641046"));

            migrationBuilder.DropColumn(
                name: "FoodCategoryId",
                table: "Foods");

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
    }
}
