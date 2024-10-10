using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace National_Museum_2.Migrations
{
    /// <inheritdoc />
    public partial class updateEntityHistorics : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "email",
                table: "historicUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "password",
                table: "historicUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "email",
                table: "historicUser");

            migrationBuilder.DropColumn(
                name: "password",
                table: "historicUser");
        }
    }
}
