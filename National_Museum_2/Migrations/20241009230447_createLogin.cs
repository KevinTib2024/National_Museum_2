using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace National_Museum_2.Migrations
{
    /// <inheritdoc />
    public partial class createLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_permissions_permissionXUserType_PermissionXUserType_IdpermissionXUserTypeId",
                table: "permissions");

            migrationBuilder.DropIndex(
                name: "IX_permissions_PermissionXUserType_IdpermissionXUserTypeId",
                table: "permissions");

            migrationBuilder.DropColumn(
                name: "PermissionXUserType_IdpermissionXUserTypeId",
                table: "permissions");

            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "user",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "user",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "permissions_IdpermissionsId",
                table: "permissionXUserType",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_permissionXUserType_permissions_IdpermissionsId",
                table: "permissionXUserType",
                column: "permissions_IdpermissionsId");

            migrationBuilder.AddForeignKey(
                name: "FK_permissionXUserType_permissions_permissions_IdpermissionsId",
                table: "permissionXUserType",
                column: "permissions_IdpermissionsId",
                principalTable: "permissions",
                principalColumn: "permissionsId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_permissionXUserType_permissions_permissions_IdpermissionsId",
                table: "permissionXUserType");

            migrationBuilder.DropIndex(
                name: "IX_permissionXUserType_permissions_IdpermissionsId",
                table: "permissionXUserType");

            migrationBuilder.DropColumn(
                name: "email",
                table: "user");

            migrationBuilder.DropColumn(
                name: "password",
                table: "user");

            migrationBuilder.DropColumn(
                name: "permissions_IdpermissionsId",
                table: "permissionXUserType");

            migrationBuilder.AddColumn<int>(
                name: "PermissionXUserType_IdpermissionXUserTypeId",
                table: "permissions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_permissions_PermissionXUserType_IdpermissionXUserTypeId",
                table: "permissions",
                column: "PermissionXUserType_IdpermissionXUserTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_permissions_permissionXUserType_PermissionXUserType_IdpermissionXUserTypeId",
                table: "permissions",
                column: "PermissionXUserType_IdpermissionXUserTypeId",
                principalTable: "permissionXUserType",
                principalColumn: "permissionXUserTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
