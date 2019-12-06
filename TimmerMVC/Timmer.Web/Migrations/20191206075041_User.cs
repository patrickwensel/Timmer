using Microsoft.EntityFrameworkCore.Migrations;

namespace Timmer.Web.Migrations
{
    public partial class User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "049cd165-caf4-4ead-afcc-b03187e1975d");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a86e84d8-030e-4f8d-8ace-f76d18b93e73");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55b0bdc5-4d84-49fc-af9a-fb7d203b0a18",
                column: "ConcurrencyStamp",
                value: "86f5a11e-681f-4a27-a051-ca8e0c097d81");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "56e7b432-2e9d-4704-8b18-a4f8a2433147",
                column: "ConcurrencyStamp",
                value: "882a22fe-e53a-4eba-a0e6-544d6d251814");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "049cd165-caf4-4ead-afcc-b03187e1975d", 0, "e23080be-91b6-4993-b86d-f3d50e368261", "admin@timmer.com", true, null, null, false, null, "admin@timmer.com", "admin@timmer.com", "AQAAAAEAACcQAAAAEHV/Rk9zPra+/NUpcTxDqdH72uKwtVCFbRseh06+T0EoRvAH2dU1/HNvxVQ6DdMwIQ==", null, false, "", false, "admin@timmer.com" });
        }
    }
}
