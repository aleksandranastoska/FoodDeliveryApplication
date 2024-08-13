using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FoodDelivery.Repository.Migrations
{
    /// <inheritdoc />
    public partial class MenuColumnAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("1096a2f9-a75e-4c6a-a26c-4442a219a753"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("1687f0f2-158f-487f-90aa-5ee084a8c561"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("24a5d8bc-b123-44c6-af7e-aafea5a40151"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("32f9d6e3-6d56-4362-a028-473058070322"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("387c4800-1092-4808-abf2-c256674d489a"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("3d5e124f-795c-484d-a1e1-9e3dbbe056cf"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("556ef99b-f76b-419e-93f7-95a675a619ba"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("7d1d8aef-d217-41e3-b4f0-8f7c7cb4a814"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("8660c831-2d09-4af1-b54d-49b7e1638434"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("895488aa-2322-414e-b0cf-379e9f571be2"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("9bbb8900-ef9b-4b61-a7bf-ae0c6986a783"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("9e019ef1-f0e5-4f2a-bef4-75dfeaaf680a"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("c66e1223-ead4-4c77-80c9-3806f90cf44f"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("d730c473-dee2-4127-bc82-ea63509eefc6"));

            migrationBuilder.DeleteData(
                table: "FoodCategories",
                keyColumn: "Id",
                keyValue: new Guid("f4e1967e-6623-480e-91b0-366a2fd2378d"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
