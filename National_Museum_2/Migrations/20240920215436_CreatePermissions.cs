using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace National_Museum_2.Migrations
{
    /// <inheritdoc />
    public partial class CreatePermissions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_Gender_gender_IdgenderId",
                table: "user");

            migrationBuilder.DropForeignKey(
                name: "FK_user_IdentificationType_identificationType_IdidentificationTypeId",
                table: "user");

            migrationBuilder.DropForeignKey(
                name: "FK_user_UserType_user_Type_IduserTypeId",
                table: "user");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserType",
                table: "UserType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentificationType",
                table: "IdentificationType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gender",
                table: "Gender");

            migrationBuilder.RenameTable(
                name: "UserType",
                newName: "userType");

            migrationBuilder.RenameTable(
                name: "IdentificationType",
                newName: "identificationType");

            migrationBuilder.RenameTable(
                name: "Gender",
                newName: "gender");

            migrationBuilder.AddPrimaryKey(
                name: "PK_userType",
                table: "userType",
                column: "userTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_identificationType",
                table: "identificationType",
                column: "identificationTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_gender",
                table: "gender",
                column: "genderId");

            migrationBuilder.CreateTable(
                name: "permissionXUserType",
                columns: table => new
                {
                    permissionXUserTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_Type_IduserTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permissionXUserType", x => x.permissionXUserTypeId);
                    table.ForeignKey(
                        name: "FK_permissionXUserType_userType_user_Type_IduserTypeId",
                        column: x => x.user_Type_IduserTypeId,
                        principalTable: "userType",
                        principalColumn: "userTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "permissions",
                columns: table => new
                {
                    permissionsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionXUserType_IdpermissionXUserTypeId = table.Column<int>(type: "int", nullable: false),
                    Permission = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permissions", x => x.permissionsId);
                    table.ForeignKey(
                        name: "FK_permissions_permissionXUserType_PermissionXUserType_IdpermissionXUserTypeId",
                        column: x => x.PermissionXUserType_IdpermissionXUserTypeId,
                        principalTable: "permissionXUserType",
                        principalColumn: "permissionXUserTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_permissions_PermissionXUserType_IdpermissionXUserTypeId",
                table: "permissions",
                column: "PermissionXUserType_IdpermissionXUserTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_permissionXUserType_user_Type_IduserTypeId",
                table: "permissionXUserType",
                column: "user_Type_IduserTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_user_gender_gender_IdgenderId",
                table: "user",
                column: "gender_IdgenderId",
                principalTable: "gender",
                principalColumn: "genderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_identificationType_identificationType_IdidentificationTypeId",
                table: "user",
                column: "identificationType_IdidentificationTypeId",
                principalTable: "identificationType",
                principalColumn: "identificationTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_userType_user_Type_IduserTypeId",
                table: "user",
                column: "user_Type_IduserTypeId",
                principalTable: "userType",
                principalColumn: "userTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_user_gender_gender_IdgenderId",
                table: "user");

            migrationBuilder.DropForeignKey(
                name: "FK_user_identificationType_identificationType_IdidentificationTypeId",
                table: "user");

            migrationBuilder.DropForeignKey(
                name: "FK_user_userType_user_Type_IduserTypeId",
                table: "user");

            migrationBuilder.DropTable(
                name: "permissions");

            migrationBuilder.DropTable(
                name: "permissionXUserType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userType",
                table: "userType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_identificationType",
                table: "identificationType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_gender",
                table: "gender");

            migrationBuilder.RenameTable(
                name: "userType",
                newName: "UserType");

            migrationBuilder.RenameTable(
                name: "identificationType",
                newName: "IdentificationType");

            migrationBuilder.RenameTable(
                name: "gender",
                newName: "Gender");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserType",
                table: "UserType",
                column: "userTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentificationType",
                table: "IdentificationType",
                column: "identificationTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gender",
                table: "Gender",
                column: "genderId");

            migrationBuilder.AddForeignKey(
                name: "FK_user_Gender_gender_IdgenderId",
                table: "user",
                column: "gender_IdgenderId",
                principalTable: "Gender",
                principalColumn: "genderId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_IdentificationType_identificationType_IdidentificationTypeId",
                table: "user",
                column: "identificationType_IdidentificationTypeId",
                principalTable: "IdentificationType",
                principalColumn: "identificationTypeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_UserType_user_Type_IduserTypeId",
                table: "user",
                column: "user_Type_IduserTypeId",
                principalTable: "UserType",
                principalColumn: "userTypeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
