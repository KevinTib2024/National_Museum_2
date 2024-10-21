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
                    category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    artRoomId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employeesXArtRoom", x => x.employeesXArtRoomId);
                });

            migrationBuilder.CreateTable(
                name: "gameProgresses",
                columns: table => new
                {
                    gameProgressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gameProgress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gameProgresses", x => x.gameProgressId);
                });

            migrationBuilder.CreateTable(
                name: "gameStates",
                columns: table => new
                {
                    gameStateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gameState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gameStates", x => x.gameStateId);
                });

            migrationBuilder.CreateTable(
                name: "gender",
                columns: table => new
                {
                    genderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gender", x => x.genderId);
                });

            migrationBuilder.CreateTable(
                name: "historicMaintenance",
                columns: table => new
                {
                    historicMaintenanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maintenance_Id = table.Column<int>(type: "int", nullable: false),
                    artObject_Id = table.Column<int>(type: "int", nullable: false),
                    starDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost = table.Column<int>(type: "int", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModicationBy = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historicMaintenance", x => x.historicMaintenanceId);
                });

            migrationBuilder.CreateTable(
                name: "historicTickets",
                columns: table => new
                {
                    historicTicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ticket_Id = table.Column<int>(type: "int", nullable: false),
                    user_Id = table.Column<int>(type: "int", nullable: false),
                    visitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ticketType_Id = table.Column<int>(type: "int", nullable: false),
                    paymentMethod_Id = table.Column<int>(type: "int", nullable: false),
                    employeeId = table.Column<int>(type: "int", nullable: false),
                    ticketXCollection_Id = table.Column<int>(type: "int", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModicationBy = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historicTickets", x => x.historicTicketId);
                });

            migrationBuilder.CreateTable(
                name: "historicUser",
                columns: table => new
                {
                    historicUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_Id = table.Column<int>(type: "int", nullable: false),
                    user_Type_Id = table.Column<int>(type: "int", nullable: false),
                    identificationType_Id = table.Column<int>(type: "int", nullable: false),
                    identificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    names = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender_Id = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModicationBy = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historicUser", x => x.historicUserId);
                });

            migrationBuilder.CreateTable(
                name: "identificationType",
                columns: table => new
                {
                    identificationTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Identification_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_location", x => x.locationId);
                });

            migrationBuilder.CreateTable(
                name: "paymentMethods",
                columns: table => new
                {
                    paymentMethodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_paymentMethods", x => x.paymentMethodId);
                });

            migrationBuilder.CreateTable(
                name: "permissions",
                columns: table => new
                {
                    permissionsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Permission = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permissions", x => x.permissionsId);
                });

            migrationBuilder.CreateTable(
                name: "scenary",
                columns: table => new
                {
                    scenaryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    scenaryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    order = table.Column<int>(type: "int", nullable: false),
                    achievementsobtained = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scenary", x => x.scenaryId);
                });

            migrationBuilder.CreateTable(
                name: "state",
                columns: table => new
                {
                    stateId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_state", x => x.stateId);
                });

            migrationBuilder.CreateTable(
                name: "ticketType",
                columns: table => new
                {
                    ticketTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ticketType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<float>(type: "real", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticketType", x => x.ticketTypeId);
                });

            migrationBuilder.CreateTable(
                name: "typeEmployee",
                columns: table => new
                {
                    typeEmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    typeEmployee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    userType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    workShedule = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workShedule", x => x.workSheduleId);
                });

            migrationBuilder.CreateTable(
                name: "ticketXCollection",
                columns: table => new
                {
                    ticketXCollectionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ticket_Id = table.Column<int>(type: "int", nullable: false),
                    collection_IdcollectionId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticketXCollection", x => x.ticketXCollectionId);
                    table.ForeignKey(
                        name: "FK_ticketXCollection_collection_collection_IdcollectionId",
                        column: x => x.collection_IdcollectionId,
                        principalTable: "collection",
                        principalColumn: "collectionId",
                        onDelete: ReferentialAction.Cascade);
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
                    collection_IdcollectionId = table.Column<int>(type: "int", nullable: false),
                    employeesXArtRoom_Id = table.Column<int>(type: "int", nullable: false),
                    employeesXArtRoomId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                        name: "FK_artRoom_employeesXArtRoom_employeesXArtRoomId",
                        column: x => x.employeesXArtRoomId,
                        principalTable: "employeesXArtRoom",
                        principalColumn: "employeesXArtRoomId",
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
                    userType_IduserTypeId = table.Column<int>(type: "int", nullable: false),
                    permissions_IdpermissionsId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permissionXUserType", x => x.permissionXUserTypeId);
                    table.ForeignKey(
                        name: "FK_permissionXUserType_permissions_permissions_IdpermissionsId",
                        column: x => x.permissions_IdpermissionsId,
                        principalTable: "permissions",
                        principalColumn: "permissionsId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_permissionXUserType_userType_userType_IduserTypeId",
                        column: x => x.userType_IduserTypeId,
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
                    user_Type_Id = table.Column<int>(type: "int", nullable: false),
                    identificationType_Id = table.Column<int>(type: "int", nullable: false),
                    identificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    names = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender_Id = table.Column<int>(type: "int", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.userId);
                    table.ForeignKey(
                        name: "FK_user_gender_gender_Id",
                        column: x => x.gender_Id,
                        principalTable: "gender",
                        principalColumn: "genderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_identificationType_identificationType_Id",
                        column: x => x.identificationType_Id,
                        principalTable: "identificationType",
                        principalColumn: "identificationTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_userType_user_Type_Id",
                        column: x => x.user_Type_Id,
                        principalTable: "userType",
                        principalColumn: "userTypeId",
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
                    artRoom_IdartRoomId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                name: "contact",
                columns: table => new
                {
                    contactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_IduserId = table.Column<int>(type: "int", nullable: false),
                    contactType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                name: "games",
                columns: table => new
                {
                    gameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_IduserId = table.Column<int>(type: "int", nullable: false),
                    gameDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    gameState_IdgameStateId = table.Column<int>(type: "int", nullable: false),
                    gameTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    punctuation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    scenary_IdscenaryId = table.Column<int>(type: "int", nullable: false),
                    gameProgress_IdgameProgressId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_games", x => x.gameId);
                    table.ForeignKey(
                        name: "FK_games_gameProgresses_gameProgress_IdgameProgressId",
                        column: x => x.gameProgress_IdgameProgressId,
                        principalTable: "gameProgresses",
                        principalColumn: "gameProgressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_games_gameStates_gameState_IdgameStateId",
                        column: x => x.gameState_IdgameStateId,
                        principalTable: "gameStates",
                        principalColumn: "gameStateId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_games_scenary_scenary_IdscenaryId",
                        column: x => x.scenary_IdscenaryId,
                        principalTable: "scenary",
                        principalColumn: "scenaryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_games_user_user_IduserId",
                        column: x => x.user_IduserId,
                        principalTable: "user",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ticket",
                columns: table => new
                {
                    ticketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_IduserId = table.Column<int>(type: "int", nullable: false),
                    visitDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ticketType_IdticketTypeId = table.Column<int>(type: "int", nullable: false),
                    paymentMethod_IdpaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    employeeId = table.Column<int>(type: "int", nullable: false),
                    ticketXCollection_IdticketXCollectionId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticket", x => x.ticketId);
                    table.ForeignKey(
                        name: "FK_ticket_paymentMethods_paymentMethod_IdpaymentMethodId",
                        column: x => x.paymentMethod_IdpaymentMethodId,
                        principalTable: "paymentMethods",
                        principalColumn: "paymentMethodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_ticketType_ticketType_IdticketTypeId",
                        column: x => x.ticketType_IdticketTypeId,
                        principalTable: "ticketType",
                        principalColumn: "ticketTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_ticketXCollection_ticketXCollection_IdticketXCollectionId",
                        column: x => x.ticketXCollection_IdticketXCollectionId,
                        principalTable: "ticketXCollection",
                        principalColumn: "ticketXCollectionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_user_user_IduserId",
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
                    exhibition_IdexhibitionId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    cost = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
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
                    user_Id = table.Column<int>(type: "int", nullable: false),
                    userId = table.Column<int>(type: "int", nullable: false),
                    typeEmployee_Id = table.Column<int>(type: "int", nullable: false),
                    typeEmployeeId = table.Column<int>(type: "int", nullable: false),
                    workShedule_Id = table.Column<int>(type: "int", nullable: false),
                    workSheduleId = table.Column<int>(type: "int", nullable: false),
                    hiringDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    employeesXArtRoom_Id = table.Column<int>(type: "int", nullable: false),
                    employeesXArtRoomId = table.Column<int>(type: "int", nullable: false),
                    maintenance_Id = table.Column<int>(type: "int", nullable: false),
                    maintenanceId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.employeeId);
                    table.ForeignKey(
                        name: "FK_employee_employeesXArtRoom_employeesXArtRoomId",
                        column: x => x.employeesXArtRoomId,
                        principalTable: "employeesXArtRoom",
                        principalColumn: "employeesXArtRoomId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employee_maintenance_maintenanceId",
                        column: x => x.maintenanceId,
                        principalTable: "maintenance",
                        principalColumn: "maintenanceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employee_typeEmployee_typeEmployeeId",
                        column: x => x.typeEmployeeId,
                        principalTable: "typeEmployee",
                        principalColumn: "typeEmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employee_user_userId",
                        column: x => x.userId,
                        principalTable: "user",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employee_workShedule_workSheduleId",
                        column: x => x.workSheduleId,
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
                name: "IX_artRoom_employeesXArtRoomId",
                table: "artRoom",
                column: "employeesXArtRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_artRoom_location_IdlocationId",
                table: "artRoom",
                column: "location_IdlocationId");

            migrationBuilder.CreateIndex(
                name: "IX_contact_user_IduserId",
                table: "contact",
                column: "user_IduserId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_employeesXArtRoomId",
                table: "employee",
                column: "employeesXArtRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_maintenanceId",
                table: "employee",
                column: "maintenanceId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_typeEmployeeId",
                table: "employee",
                column: "typeEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_userId",
                table: "employee",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_workSheduleId",
                table: "employee",
                column: "workSheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_exhibition_artRoom_IdartRoomId",
                table: "exhibition",
                column: "artRoom_IdartRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_games_gameProgress_IdgameProgressId",
                table: "games",
                column: "gameProgress_IdgameProgressId");

            migrationBuilder.CreateIndex(
                name: "IX_games_gameState_IdgameStateId",
                table: "games",
                column: "gameState_IdgameStateId");

            migrationBuilder.CreateIndex(
                name: "IX_games_scenary_IdscenaryId",
                table: "games",
                column: "scenary_IdscenaryId");

            migrationBuilder.CreateIndex(
                name: "IX_games_user_IduserId",
                table: "games",
                column: "user_IduserId");

            migrationBuilder.CreateIndex(
                name: "IX_maintenance_artObject_IdartObjectId",
                table: "maintenance",
                column: "artObject_IdartObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_permissionXUserType_permissions_IdpermissionsId",
                table: "permissionXUserType",
                column: "permissions_IdpermissionsId");

            migrationBuilder.CreateIndex(
                name: "IX_permissionXUserType_userType_IduserTypeId",
                table: "permissionXUserType",
                column: "userType_IduserTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_paymentMethod_IdpaymentMethodId",
                table: "ticket",
                column: "paymentMethod_IdpaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_ticketType_IdticketTypeId",
                table: "ticket",
                column: "ticketType_IdticketTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_ticketXCollection_IdticketXCollectionId",
                table: "ticket",
                column: "ticketXCollection_IdticketXCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ticket_user_IduserId",
                table: "ticket",
                column: "user_IduserId");

            migrationBuilder.CreateIndex(
                name: "IX_ticketXCollection_collection_IdcollectionId",
                table: "ticketXCollection",
                column: "collection_IdcollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_user_gender_Id",
                table: "user",
                column: "gender_Id");

            migrationBuilder.CreateIndex(
                name: "IX_user_identificationType_Id",
                table: "user",
                column: "identificationType_Id");

            migrationBuilder.CreateIndex(
                name: "IX_user_user_Type_Id",
                table: "user",
                column: "user_Type_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "contact");

            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "games");

            migrationBuilder.DropTable(
                name: "historicMaintenance");

            migrationBuilder.DropTable(
                name: "historicTickets");

            migrationBuilder.DropTable(
                name: "historicUser");

            migrationBuilder.DropTable(
                name: "permissionXUserType");

            migrationBuilder.DropTable(
                name: "ticket");

            migrationBuilder.DropTable(
                name: "maintenance");

            migrationBuilder.DropTable(
                name: "typeEmployee");

            migrationBuilder.DropTable(
                name: "workShedule");

            migrationBuilder.DropTable(
                name: "gameProgresses");

            migrationBuilder.DropTable(
                name: "gameStates");

            migrationBuilder.DropTable(
                name: "scenary");

            migrationBuilder.DropTable(
                name: "permissions");

            migrationBuilder.DropTable(
                name: "paymentMethods");

            migrationBuilder.DropTable(
                name: "ticketType");

            migrationBuilder.DropTable(
                name: "ticketXCollection");

            migrationBuilder.DropTable(
                name: "user");

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
                name: "employeesXArtRoom");

            migrationBuilder.DropTable(
                name: "location");
        }
    }
}
