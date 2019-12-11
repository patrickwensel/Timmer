using Microsoft.EntityFrameworkCore.Migrations;

namespace Timmer.Web.Migrations
{
    public partial class AddProductPhoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductPhoto",
                columns: table => new
                {
                    ProductPhotoID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhotoURL = table.Column<string>(nullable: true),
                    Order = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductPhoto", x => x.ProductPhotoID);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55b0bdc5-4d84-49fc-af9a-fb7d203b0a18",
                column: "ConcurrencyStamp",
                value: "cceeaff5-7b41-419d-bab2-be32d0544c4b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56e7b432-2e9d-4704-8b18-a4f8a2433147",
                column: "ConcurrencyStamp",
                value: "511f9b18-4aa2-4650-8b3a-de24abecf6ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "208d8e27-bcce-459d-bcab-b77e1327f5d6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6e826e52-f837-49e3-97e3-dedbf41362cc", "AQAAAAEAACcQAAAAECNEsPtpfQJQWYOkPAVjVnsWObjaYjyxTOESI3nJro/xXVB5yuYLEoM+zpjza5gmJQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductPhoto");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55b0bdc5-4d84-49fc-af9a-fb7d203b0a18",
                column: "ConcurrencyStamp",
                value: "316a1db1-80a8-42e1-b89b-c7018dce3df2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56e7b432-2e9d-4704-8b18-a4f8a2433147",
                column: "ConcurrencyStamp",
                value: "efa75165-e942-49f8-acfb-bbcda465470d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "208d8e27-bcce-459d-bcab-b77e1327f5d6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f79bb09c-0269-40d7-9f8a-bc6f8896ec38", "AQAAAAEAACcQAAAAEIfSWOM1Cmn+kjK2T/2vJEFOKJ0W0oRVYbfNkkYvo0oTxje2kXaMszqVN/cdV7Gl4A==" });
        }
    }
}
