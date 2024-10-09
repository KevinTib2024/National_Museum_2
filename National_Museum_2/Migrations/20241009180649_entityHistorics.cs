using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace National_Museum_2.Migrations
{
    /// <inheritdoc />
    public partial class entityHistorics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "historicMaintenance",
                columns: table => new
                {
                    historicMaintenanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maintenance_IdmaintenanceId = table.Column<int>(type: "int", nullable: false),
                    artObject_IdartObjectId = table.Column<int>(type: "int", nullable: false),
                    starDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    endDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cost = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historicMaintenance", x => x.historicMaintenanceId);
                    table.ForeignKey(
                        name: "FK_historicMaintenance_artObject_artObject_IdartObjectId",
                        column: x => x.artObject_IdartObjectId,
                        principalTable: "artObject",
                        principalColumn: "artObjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_historicMaintenance_maintenance_maintenance_IdmaintenanceId",
                        column: x => x.maintenance_IdmaintenanceId,
                        principalTable: "maintenance",
                        principalColumn: "maintenanceId",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "historicTickets",
                columns: table => new
                {
                    historicTicketId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ticket_IdticketId = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_historicTickets", x => x.historicTicketId);
                    table.ForeignKey(
                        name: "FK_historicTickets_paymentMethods_paymentMethod_IdpaymentMethodId",
                        column: x => x.paymentMethod_IdpaymentMethodId,
                        principalTable: "paymentMethods",
                        principalColumn: "paymentMethodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_historicTickets_ticketType_ticketType_IdticketTypeId",
                        column: x => x.ticketType_IdticketTypeId,
                        principalTable: "ticketType",
                        principalColumn: "ticketTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_historicTickets_ticketXCollection_ticketXCollection_IdticketXCollectionId",
                        column: x => x.ticketXCollection_IdticketXCollectionId,
                        principalTable: "ticketXCollection",
                        principalColumn: "ticketXCollectionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_historicTickets_ticket_ticket_IdticketId",
                        column: x => x.ticket_IdticketId,
                        principalTable: "ticket",
                        principalColumn: "ticketId",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_historicTickets_user_user_IduserId",
                        column: x => x.user_IduserId,
                        principalTable: "user",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "historicUser",
                columns: table => new
                {
                    historicUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_IduserId = table.Column<int>(type: "int", nullable: false),
                    user_Type_IduserTypeId = table.Column<int>(type: "int", nullable: false),
                    identificationType_IdidentificationTypeId = table.Column<int>(type: "int", nullable: false),
                    identificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    names = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastNames = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    birthDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender_IdgenderId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historicUser", x => x.historicUserId);
                    table.ForeignKey(
                        name: "FK_historicUser_gender_gender_IdgenderId",
                        column: x => x.gender_IdgenderId,
                        principalTable: "gender",
                        principalColumn: "genderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_historicUser_identificationType_identificationType_IdidentificationTypeId",
                        column: x => x.identificationType_IdidentificationTypeId,
                        principalTable: "identificationType",
                        principalColumn: "identificationTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_historicUser_userType_user_Type_IduserTypeId",
                        column: x => x.user_Type_IduserTypeId,
                        principalTable: "userType",
                        principalColumn: "userTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_historicUser_user_user_IduserId",
                        column: x => x.user_IduserId,
                        principalTable: "user",
                        principalColumn: "userId",
                        onDelete: ReferentialAction.NoAction);
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
                name: "IX_historicMaintenance_artObject_IdartObjectId",
                table: "historicMaintenance",
                column: "artObject_IdartObjectId");

            migrationBuilder.CreateIndex(
                name: "IX_historicMaintenance_maintenance_IdmaintenanceId",
                table: "historicMaintenance",
                column: "maintenance_IdmaintenanceId");

            migrationBuilder.CreateIndex(
                name: "IX_historicTickets_paymentMethod_IdpaymentMethodId",
                table: "historicTickets",
                column: "paymentMethod_IdpaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_historicTickets_ticket_IdticketId",
                table: "historicTickets",
                column: "ticket_IdticketId");

            migrationBuilder.CreateIndex(
                name: "IX_historicTickets_ticketType_IdticketTypeId",
                table: "historicTickets",
                column: "ticketType_IdticketTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_historicTickets_ticketXCollection_IdticketXCollectionId",
                table: "historicTickets",
                column: "ticketXCollection_IdticketXCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_historicTickets_user_IduserId",
                table: "historicTickets",
                column: "user_IduserId");

            migrationBuilder.CreateIndex(
                name: "IX_historicUser_gender_IdgenderId",
                table: "historicUser",
                column: "gender_IdgenderId");

            migrationBuilder.CreateIndex(
                name: "IX_historicUser_identificationType_IdidentificationTypeId",
                table: "historicUser",
                column: "identificationType_IdidentificationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_historicUser_user_IduserId",
                table: "historicUser",
                column: "user_IduserId");

            migrationBuilder.CreateIndex(
                name: "IX_historicUser_user_Type_IduserTypeId",
                table: "historicUser",
                column: "user_Type_IduserTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "games");

            migrationBuilder.DropTable(
                name: "historicMaintenance");

            migrationBuilder.DropTable(
                name: "historicTickets");

            migrationBuilder.DropTable(
                name: "historicUser");

            migrationBuilder.DropTable(
                name: "gameProgresses");

            migrationBuilder.DropTable(
                name: "gameStates");

            migrationBuilder.DropTable(
                name: "scenary");
        }
    }
}
