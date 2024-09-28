using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace National_Museum_2.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "collection",
                columns: table => new
                {
                    collectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_collection", x => x.collectionId);
                });

            migrationBuilder.CreateTable(
                name: "employeesXArtRoom",
                columns: table => new
                {
                    employeesXArtRoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    employeeId = table.Column<int>(type: "int", nullable: false),
                    artRoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeesXArtRoom", x => x.employeesXArtRoomId);
                });

            migrationBuilder.CreateTable(
                name: "Gender",
                columns: table => new
                {
                    genderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gender", x => x.genderId);
                });

            migrationBuilder.CreateTable(
                name: "IdentificationType",
                columns: table => new
                {
                    identificationTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identification_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentificationType", x => x.identificationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "maintenances",
                columns: table => new
                {
                    maintenanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtObject_Id = table.Column<int>(type: "int", nullable: false),
                    StarDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cost = table.Column<int>(type: "int", nullable: false),
                    Employee_Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maintenances", x => x.maintenanceId);
                });

            migrationBuilder.CreateTable(
                name: "typeEmployee",
                columns: table => new
                {
                    typeEmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typeEmployee = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_typeEmployee", x => x.typeEmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "UserType",
                columns: table => new
                {
                    userTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserType", x => x.userTypeId);
                });

            migrationBuilder.CreateTable(
                name: "workShedule",
                columns: table => new
                {
                    workSheduleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    workShedule = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workShedule", x => x.workSheduleId);
                });

            migrationBuilder.CreateTable(
                name: "PermissionXUserType",
                columns: table => new
                {
                    permissionXUserTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_Type_IduserTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PermissionXUserType", x => x.permissionXUserTypeId);
                    table.ForeignKey(
                        name: "FK_PermissionXUserType_UserType_user_Type_IduserTypeId",
                        column: x => x.user_Type_IduserTypeId,
                        principalTable: "UserType",
                        principalColumn: "userTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    userId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_Type_IduserTypeId = table.Column<int>(type: "int", nullable: false),
                    identificationType_IdidentificationTypeId = table.Column<int>(type: "int", nullable: false),
                    identificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    names = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender_IdgenderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.userId);
                    table.ForeignKey(
                        name: "FK_user_Gender_gender_IdgenderId",
                        column: x => x.gender_IdgenderId,
                        principalTable: "Gender",
                        principalColumn: "genderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_IdentificationType_identificationType_IdidentificationTypeId",
                        column: x => x.identificationType_IdidentificationTypeId,
                        principalTable: "IdentificationType",
                        principalColumn: "identificationTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_UserType_user_Type_IduserTypeId",
                        column: x => x.user_Type_IduserTypeId,
                        principalTable: "UserType",
                        principalColumn: "userTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    employeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(type: "int", nullable: false),
                    typeEmployee_IdtypeEmployeeId = table.Column<int>(type: "int", nullable: false),
                    workShedule_IdworkSheduleId = table.Column<int>(type: "int", nullable: false),
                    hiringDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    employeesXArtRoom_IdemployeesXArtRoomId = table.Column<int>(type: "int", nullable: false),
                    maintenance_IdmaintenanceId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.employeeId);
                    table.ForeignKey(
                        name: "FK_employees_employeesXArtRoom_employeesXArtRoom_IdemployeesXArtRoomId",
                        column: x => x.employeesXArtRoom_IdemployeesXArtRoomId,
                        principalTable: "employeesXArtRoom",
                        principalColumn: "employeesXArtRoomId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_maintenances_maintenance_IdmaintenanceId",
                        column: x => x.maintenance_IdmaintenanceId,
                        principalTable: "maintenances",
                        principalColumn: "maintenanceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_typeEmployee_typeEmployee_IdtypeEmployeeId",
                        column: x => x.typeEmployee_IdtypeEmployeeId,
                        principalTable: "typeEmployee",
                        principalColumn: "typeEmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_workShedule_workShedule_IdworkSheduleId",
                        column: x => x.workShedule_IdworkSheduleId,
                        principalTable: "workShedule",
                        principalColumn: "workSheduleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    permissionsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PermissionXUserType_IdpermissionXUserTypeId = table.Column<int>(type: "int", nullable: false),
                    Permission = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.permissionsId);
                    table.ForeignKey(
                        name: "FK_Permissions_PermissionXUserType_PermissionXUserType_IdpermissionXUserTypeId",
                        column: x => x.PermissionXUserType_IdpermissionXUserTypeId,
                        principalTable: "PermissionXUserType",
                        principalColumn: "permissionXUserTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    contactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_IduserId = table.Column<int>(type: "int", nullable: false),
                    contactType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.contactId);
                    table.ForeignKey(
                        name: "FK_Contact_user_user_IduserId",
                        column: x => x.user_IduserId,
                        principalTable: "user",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contact_user_IduserId",
                table: "Contact",
                column: "user_IduserId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_employeesXArtRoom_IdemployeesXArtRoomId",
                table: "employees",
                column: "employeesXArtRoom_IdemployeesXArtRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_maintenance_IdmaintenanceId",
                table: "employees",
                column: "maintenance_IdmaintenanceId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_typeEmployee_IdtypeEmployeeId",
                table: "employees",
                column: "typeEmployee_IdtypeEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_employees_workShedule_IdworkSheduleId",
                table: "employees",
                column: "workShedule_IdworkSheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_PermissionXUserType_IdpermissionXUserTypeId",
                table: "Permissions",
                column: "PermissionXUserType_IdpermissionXUserTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PermissionXUserType_user_Type_IduserTypeId",
                table: "PermissionXUserType",
                column: "user_Type_IduserTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_user_gender_IdgenderId",
                table: "user",
                column: "gender_IdgenderId");

            migrationBuilder.CreateIndex(
                name: "IX_user_identificationType_IdidentificationTypeId",
                table: "user",
                column: "identificationType_IdidentificationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_user_user_Type_IduserTypeId",
                table: "user",
                column: "user_Type_IduserTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "collection");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "employeesXArtRoom");

            migrationBuilder.DropTable(
                name: "maintenances");

            migrationBuilder.DropTable(
                name: "typeEmployee");

            migrationBuilder.DropTable(
                name: "workShedule");

            migrationBuilder.DropTable(
                name: "PermissionXUserType");

            migrationBuilder.DropTable(
                name: "Gender");

            migrationBuilder.DropTable(
                name: "IdentificationType");

            migrationBuilder.DropTable(
                name: "UserType");
        }
    }
}
