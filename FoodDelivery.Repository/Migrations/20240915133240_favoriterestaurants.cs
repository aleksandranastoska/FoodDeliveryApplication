using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDelivery.Repository.Migrations
{
    /// <inheritdoc />
    public partial class favoriterestaurants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("01746e01-ca3b-4c8a-a441-59f8159dd06a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("1b542084-0197-44b8-8607-6f89793c5834"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("297f7826-cc6c-4e1e-9e96-c95cf4ee6da4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("301b4320-4151-466f-970f-860425d79a09"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("30976ea7-96c6-4d5c-bb17-87be99cdec44"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("37fcebf7-c93e-4740-9a67-a24b553a53ad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("43e2b9d4-bab7-4813-8174-a4edc47e6dfb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7e6d3545-47d5-4c91-809c-c04ea23889a8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b3883314-07f3-48a6-9207-328f7b105825"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c2eef234-7c83-49cb-84d7-c64248116dc3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("eff4f5a4-6eb6-446f-9452-c275fde7cb52"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f8239c04-a15a-4bc4-a6f3-e6ddc481e939"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("1131a63b-b78f-45a6-b21a-d6c041698138"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("1b71ee17-8257-48f3-95ab-b5231fc18c2f"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("25aa873e-f4d0-4f0f-ae6a-9e3c39bff046"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("28f406b2-593e-4d5a-8c03-10dcdca21e5b"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("34850a93-1dc4-4540-bd0c-065b475c0d86"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("40a11c63-48df-4adb-afd8-0730a843db04"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("46e915c6-d1cb-408a-9660-9725ff9886e8"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("689e7919-3b78-4cb4-9533-ec167b12573f"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("8723329a-8d87-4a01-b407-c1585ce27f5a"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("94d2d82f-6b31-46ba-a484-48d6288ca7b9"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("bb758570-43b4-4259-9009-5633339a8b24"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("c37fc0f8-530b-49b5-b241-a843d40944d7"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("e4db70d6-6262-4e1b-ae79-8c5375a78349"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("e521e90d-901c-4250-8ef6-d5712648fb51"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("ef1659a4-d6b0-4501-b208-7486467c4d4d"));

            migrationBuilder.CreateTable(
    name: "FavoriteRestaurants",
    columns: table => new
    {
        Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
        OwnerId = table.Column<string>(type: "nvarchar(450)", nullable: false),
        RestaurantId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
        IsFavorite = table.Column<bool>(type: "bit", nullable: false)
    },
    constraints: table =>
    {
        table.PrimaryKey("PK_FavoriteRestaurants", x => x.Id);
        table.ForeignKey(
            name: "FK_FavoriteRestaurants_AspNetUsers_OwnerId",
            column: x => x.OwnerId,
            principalTable: "AspNetUsers",
            principalColumn: "Id",
            onDelete: ReferentialAction.NoAction);
        table.ForeignKey(
            name: "FK_FavoriteRestaurants_Restaurants_RestaurantId",
            column: x => x.RestaurantId,
            principalTable: "Restaurants",
            principalColumn: "Id",
            onDelete: ReferentialAction.NoAction); 
    });


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

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteRestaurants_OwnerId",
                table: "FavoriteRestaurants",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteRestaurants_RestaurantId",
                table: "FavoriteRestaurants",
                column: "RestaurantId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FavoriteRestaurants");

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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { new Guid("01746e01-ca3b-4c8a-a441-59f8159dd06a"), "../Images/american.png", "American" },
                    { new Guid("1b542084-0197-44b8-8607-6f89793c5834"), "../Images/breakfast.png", "Breakfast" },
                    { new Guid("297f7826-cc6c-4e1e-9e96-c95cf4ee6da4"), "../Images/chinese.png", "Chinese" },
                    { new Guid("301b4320-4151-466f-970f-860425d79a09"), "../Images/mexican.png", "Mexican" },
                    { new Guid("30976ea7-96c6-4d5c-bb17-87be99cdec44"), "../Images/vegetarian.png", "Vegetarian" },
                    { new Guid("37fcebf7-c93e-4740-9a67-a24b553a53ad"), "../Images/healthy.png", "Healthy" },
                    { new Guid("43e2b9d4-bab7-4813-8174-a4edc47e6dfb"), "../Images/vegan.png", "Vegan" },
                    { new Guid("7e6d3545-47d5-4c91-809c-c04ea23889a8"), "../Images/greek.jfif", "Greek" },
                    { new Guid("b3883314-07f3-48a6-9207-328f7b105825"), "../Images/desserts.png", "Desserts" },
                    { new Guid("c2eef234-7c83-49cb-84d7-c64248116dc3"), "../Images/italian.png", "Italian" },
                    { new Guid("eff4f5a4-6eb6-446f-9452-c275fde7cb52"), "../Images/asian.png", "Asian" },
                    { new Guid("f8239c04-a15a-4bc4-a6f3-e6ddc481e939"), "../Images/indian.png", "Indian" }
                });

            migrationBuilder.InsertData(
                table: "FoodCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1131a63b-b78f-45a6-b21a-d6c041698138"), "Pizza" },
                    { new Guid("1b71ee17-8257-48f3-95ab-b5231fc18c2f"), "Breakfast" },
                    { new Guid("25aa873e-f4d0-4f0f-ae6a-9e3c39bff046"), "Alcoholic Beverages" },
                    { new Guid("28f406b2-593e-4d5a-8c03-10dcdca21e5b"), "Hot Drinks" },
                    { new Guid("34850a93-1dc4-4540-bd0c-065b475c0d86"), "Sandwiches" },
                    { new Guid("40a11c63-48df-4adb-afd8-0730a843db04"), "Soft Drinks" },
                    { new Guid("46e915c6-d1cb-408a-9660-9725ff9886e8"), "Desserts" },
                    { new Guid("689e7919-3b78-4cb4-9533-ec167b12573f"), "Salads" },
                    { new Guid("8723329a-8d87-4a01-b407-c1585ce27f5a"), "Brunch" },
                    { new Guid("94d2d82f-6b31-46ba-a484-48d6288ca7b9"), "Juices" },
                    { new Guid("bb758570-43b4-4259-9009-5633339a8b24"), "Starters" },
                    { new Guid("c37fc0f8-530b-49b5-b241-a843d40944d7"), "Pasta" },
                    { new Guid("e4db70d6-6262-4e1b-ae79-8c5375a78349"), "Coffee" },
                    { new Guid("e521e90d-901c-4250-8ef6-d5712648fb51"), "Burgers" },
                    { new Guid("ef1659a4-d6b0-4501-b208-7486467c4d4d"), "Main Course" }
                });
        }
    }
}
