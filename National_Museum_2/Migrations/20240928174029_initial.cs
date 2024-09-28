using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace National_Museum_2.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    categoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.categoryId);
                });

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
                name: "gender",
                columns: table => new
                {
                    genderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gender", x => x.genderId);
                });

            migrationBuilder.CreateTable(
                name: "identificationType",
                columns: table => new
                {
                    identificationTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identification_Type = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_identificationType", x => x.identificationTypeId);
                });

            migrationBuilder.CreateTable(
                name: "location",
                columns: table => new
                {
                    locationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_location", x => x.locationId);
                });

            migrationBuilder.CreateTable(
                name: "state",
                columns: table => new
                {
                    stateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_state", x => x.stateId);
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
                name: "userType",
                columns: table => new
                {
                    userTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userType", x => x.userTypeId);
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
                name: "artRoom",
                columns: table => new
                {
                    artRoomId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    location_IdlocationId = table.Column<int>(type: "int", nullable: false),
                    numberExhibitions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    collection_IdcollectionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_artRoom", x => x.artRoomId);
                    table.ForeignKey(
                        name: "FK_artRoom_collection_collection_IdcollectionId",
                        column: x => x.collection_IdcollectionId,
                        principalTable: "collection",
                        principalColumn: "collectionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_artRoom_location_location_IdlocationId",
                        column: x => x.location_IdlocationId,
                        principalTable: "location",
                        principalColumn: "locationId",
                        onDelete: ReferentialAction.Cascade);
                });

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
                        name: "FK_user_gender_gender_IdgenderId",
                        column: x => x.gender_IdgenderId,
                        principalTable: "gender",
                        principalColumn: "genderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_identificationType_identificationType_IdidentificationTypeId",
                        column: x => x.identificationType_IdidentificationTypeId,
                        principalTable: "identificationType",
                        principalColumn: "identificationTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_userType_user_Type_IduserTypeId",
                        column: x => x.user_Type_IduserTypeId,
                        principalTable: "userType",
                        principalColumn: "userTypeId",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_employeesXArtRoom_artRoom_artRoomId",
                        column: x => x.artRoomId,
                        principalTable: "artRoom",
                        principalColumn: "artRoomId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "exhibition",
                columns: table => new
                {
                    exhibitionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    artRoom_IdartRoomId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_exhibition", x => x.exhibitionId);
                    table.ForeignKey(
                        name: "FK_exhibition_artRoom_artRoom_IdartRoomId",
                        column: x => x.artRoom_IdartRoomId,
                        principalTable: "artRoom",
                        principalColumn: "artRoomId",
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

            migrationBuilder.CreateTable(
                name: "contact",
                columns: table => new
                {
                    contactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_IduserId = table.Column<int>(type: "int", nullable: false),
                    contactType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_contact", x => x.contactId);
                    table.ForeignKey(
                        name: "FK_contact_user_user_IduserId",
                        column: x => x.user_IduserId,
                        principalTable: "user",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "artObject",
                columns: table => new
                {
                    artObjectId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    artist = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    creationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    origin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    category_IdcategoryId = table.Column<int>(type: "int", nullable: false),
                    state_IdstateId = table.Column<int>(type: "int", nullable: false),
                    exhibition_IdexhibitionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_artObject", x => x.artObjectId);
                    table.ForeignKey(
                        name: "FK_artObject_categories_category_IdcategoryId",
                        column: x => x.category_IdcategoryId,
                        principalTable: "categories",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_artObject_exhibition_exhibition_IdexhibitionId",
                        column: x => x.exhibition_IdexhibitionId,
                        principalTable: "exhibition",
                        principalColumn: "exhibitionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_artObject_state_state_IdstateId",
                        column: x => x.state_IdstateId,
                        principalTable: "state",
                        principalColumn: "stateId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "maintenance",
                columns: table => new
                {
                    maintenanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    artObject_IdartObjectId = table.Column<int>(type: "int", nullable: false),
                    starDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_maintenance", x => x.maintenanceId);
                    table.ForeignKey(
                        name: "FK_maintenance_artObject_artObject_IdartObjectId",
                        column: x => x.artObject_IdartObjectId,
                        principalTable: "artObject",
                        principalColumn: "artObjectId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    employeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_IduserId = table.Column<int>(type: "int", nullable: false),
                    typeEmployee_IdtypeEmployeeId = table.Column<int>(type: "int", nullable: false),
                    workShedule_IdworkSheduleId = table.Column<int>(type: "int", nullable: false),
                    hiringDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    employeesXArtRoom_IdemployeesXArtRoomId = table.Column<int>(type: "int", nullable: false),
                    maintenance_IdmaintenanceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.employeeId);
                    table.ForeignKey(
                        name: "FK_employee_employeesXArtRoom_employeesXArtRoom_IdemployeesXArtRoomId",
                        column: x => x.employeesXArtRoom_IdemployeesXArtRoomId,
                        principalTable: "employeesXArtRoom",
                        principalColumn: "employeesXArtRoomId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employee_maintenance_maintenance_IdmaintenanceId",
                        column: x => x.maintenance_IdmaintenanceId,
                        principalTable: "maintenance",
                        principalColumn: "maintenanceId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_employee_typeEmployee_typeEmployee_IdtypeEmployeeId",
                        column: x => x.typeEmployee_IdtypeEmployeeId,
                        principalTable: "typeEmployee",
                        principalColumn: "typeEmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employee_user_user_IduserId",
                        column: x => x.user_IduserId,
                        principalTable: "user",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employee_workShedule_workShedule_IdworkSheduleId",
                        column: x => x.workShedule_IdworkSheduleId,
                        principalTable: "workShedule",
                        principalColumn: "workSheduleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_artObject_category_IdcategoryId",
                table: "artObject",
                column: "category_IdcategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_artObject_exhibition_IdexhibitionId",
                table: "artObject",
                column: "exhibition_IdexhibitionId");

            migrationBuilder.CreateIndex(
                name: "IX_artObject_state_IdstateId",
                table: "artObject",
                column: "state_IdstateId");

            migrationBuilder.CreateIndex(
                name: "IX_artRoom_collection_IdcollectionId",
                table: "artRoom",
                column: "collection_IdcollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_artRoom_location_IdlocationId",
                table: "artRoom",
                column: "location_IdlocationId");

            migrationBuilder.CreateIndex(
                name: "IX_contact_user_IduserId",
                table: "contact",
                column: "user_IduserId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_employeesXArtRoom_IdemployeesXArtRoomId",
                table: "employee",
                column: "employeesXArtRoom_IdemployeesXArtRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_maintenance_IdmaintenanceId",
                table: "employee",
                column: "maintenance_IdmaintenanceId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_typeEmployee_IdtypeEmployeeId",
                table: "employee",
                column: "typeEmployee_IdtypeEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_user_IduserId",
                table: "employee",
                column: "user_IduserId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_workShedule_IdworkSheduleId",
                table: "employee",
                column: "workShedule_IdworkSheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_employeesXArtRoom_artRoomId",
                table: "employeesXArtRoom",
                column: "artRoomId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_exhibition_artRoom_IdartRoomId",
                table: "exhibition",
                column: "artRoom_IdartRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_maintenance_artObject_IdartObjectId",
                table: "maintenance",
                column: "artObject_IdartObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_permissions_PermissionXUserType_IdpermissionXUserTypeId",
                table: "permissions",
                column: "PermissionXUserType_IdpermissionXUserTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_permissionXUserType_user_Type_IduserTypeId",
                table: "permissionXUserType",
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
                name: "contact");

            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "permissions");

            migrationBuilder.DropTable(
                name: "employeesXArtRoom");

            migrationBuilder.DropTable(
                name: "maintenance");

            migrationBuilder.DropTable(
                name: "typeEmployee");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "workShedule");

            migrationBuilder.DropTable(
                name: "permissionXUserType");

            migrationBuilder.DropTable(
                name: "artObject");

            migrationBuilder.DropTable(
                name: "gender");

            migrationBuilder.DropTable(
                name: "identificationType");

            migrationBuilder.DropTable(
                name: "userType");

            migrationBuilder.DropTable(
                name: "categories");

            migrationBuilder.DropTable(
                name: "exhibition");

            migrationBuilder.DropTable(
                name: "state");

            migrationBuilder.DropTable(
                name: "artRoom");

            migrationBuilder.DropTable(
                name: "collection");

            migrationBuilder.DropTable(
                name: "location");
        }
    }
}
