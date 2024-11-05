using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProductDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "Id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 1L, "Categoria registro 1", "Descrição registro 1", "TesteURL registro 1", "Registro 1", 81.1m },
                    { 2L, "Categoria registro 2", "Descrição registro 2", "TesteURL registro 2", "Registro 2", 82.1m },
                    { 3L, "Categoria registro 3", "Descrição registro 3", "TesteURL registro 3", "Registro 3", 83.1m },
                    { 4L, "Categoria registro 4", "Descrição registro 4", "TesteURL registro 4", "Registro 4", 84.1m },
                    { 5L, "Categoria registro 5", "Descrição registro 5", "TesteURL registro 5", "Registro 5", 85.1m },
                    { 6L, "Categoria registro 6", "Descrição registro 6", "TesteURL registro 6", "Registro 6", 86.1m },
                    { 7L, "Categoria registro 7", "Descrição registro 7", "TesteURL registro 7", "Registro 7", 87.1m },
                    { 8L, "Categoria registro 8", "Descrição registro 8", "TesteURL registro 8", "Registro 8", 88.1m },
                    { 9L, "Categoria registro 9", "Descrição registro 9", "TesteURL registro 9", "Registro 9", 89.1m },
                    { 10L, "Categoria registro 10", "Descrição registro 10", "TesteURL registro 10", "Registro 10", 90.1m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "Id",
                keyValue: 10L);
        }
    }
}
