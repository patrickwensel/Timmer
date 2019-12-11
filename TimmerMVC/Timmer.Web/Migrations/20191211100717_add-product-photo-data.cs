using Microsoft.EntityFrameworkCore.Migrations;

namespace Timmer.Web.Migrations
{
    public partial class addproductphotodata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55b0bdc5-4d84-49fc-af9a-fb7d203b0a18",
                column: "ConcurrencyStamp",
                value: "9c0dda69-fe5c-4890-ac50-8c3f06cfff59");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56e7b432-2e9d-4704-8b18-a4f8a2433147",
                column: "ConcurrencyStamp",
                value: "a3f281da-0844-4b49-a74d-7f2dad7b26fa");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "208d8e27-bcce-459d-bcab-b77e1327f5d6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a20fb6f4-c5ed-414b-9c83-b0fa2521286d", "AQAAAAEAACcQAAAAEM4Z6aAvbOjdDNHK0KXlDDgamaj/ANi3nAqnOvDKSzKcxUJm3glsCFESjnGi3a/h1A==" });

            migrationBuilder.InsertData(
                table: "ProductPhoto",
                columns: new[] { "ProductPhotoID", "Order", "PhotoURL", "ProductID" },
                values: new object[,]
                {
                    { 1, 1, "https://user-images.githubusercontent.com/41929050/61567051-13938600-aa33-11e9-8ae7-0b5c19aafab4.jpeg", 1 },
                    { 2, 2, "https://user-images.githubusercontent.com/41929050/61567053-13938600-aa33-11e9-9780-104fe4019659.png", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductPhoto_ProductID",
                table: "ProductPhoto",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPhoto_Products_ProductID",
                table: "ProductPhoto",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "ProductID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPhoto_Products_ProductID",
                table: "ProductPhoto");

            migrationBuilder.DropIndex(
                name: "IX_ProductPhoto_ProductID",
                table: "ProductPhoto");

            migrationBuilder.DeleteData(
                table: "ProductPhoto",
                keyColumn: "ProductPhotoID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductPhoto",
                keyColumn: "ProductPhotoID",
                keyValue: 2);

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
    }
}
