using Microsoft.EntityFrameworkCore.Migrations;

namespace Timmer.Web.Migrations
{
    public partial class userrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a86e84d8-030e-4f8d-8ace-f76d18b93e73");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55b0bdc5-4d84-49fc-af9a-fb7d203b0a18",
                column: "ConcurrencyStamp",
                value: "8f51dfb7-5789-4c3a-8b49-17c60f12347c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56e7b432-2e9d-4704-8b18-a4f8a2433147",
                column: "ConcurrencyStamp",
                value: "102ad9d8-c20e-4506-ae9a-c7d358c3313b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "208d8e27-bcce-459d-bcab-b77e1327f5d6", 0, "00b75216-69e3-48c7-b2b3-0c8a9d1371b4", "admin@timmer.com", true, false, null, "admin@timmer.com", "admin@timmer.com", "AQAAAAEAACcQAAAAEGwgZJb98aGhJQ5rznbf71wlwpnPOOQ6CFz2KpOq+lgS3yRurYvS+dnuw/wFVa321g==", null, false, "", false, "admin@timmer.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "208d8e27-bcce-459d-bcab-b77e1327f5d6", "55b0bdc5-4d84-49fc-af9a-fb7d203b0a18" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "208d8e27-bcce-459d-bcab-b77e1327f5d6", "55b0bdc5-4d84-49fc-af9a-fb7d203b0a18" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "208d8e27-bcce-459d-bcab-b77e1327f5d6");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55b0bdc5-4d84-49fc-af9a-fb7d203b0a18",
                column: "ConcurrencyStamp",
                value: "05081087-e9b9-4c75-ad5a-92de3ad20d1b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56e7b432-2e9d-4704-8b18-a4f8a2433147",
                column: "ConcurrencyStamp",
                value: "76ff0c09-fb1d-4653-8ed8-9e8cd01d29dd");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "FirstName", "LastName" },
                values: new object[] { "a86e84d8-030e-4f8d-8ace-f76d18b93e73", 0, "f033e300-293a-44f6-add9-732aa80fc2e3", "ApplicationUser", "admin@timmer.com", true, false, null, "admin@timmer.com", "admin@timmer.com", "AQAAAAEAACcQAAAAEGLc/pj4uJ1g0i5jsdMq+sb00k7U0iBQofRvvbQSTgz9HzHk7osrQ9f359YA6rGgVg==", null, false, "", false, "admin@timmer.com", null, null });
        }
    }
}
