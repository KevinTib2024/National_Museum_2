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
                    ModificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModicationBy = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historicUser", x => x.historicUserId);
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
