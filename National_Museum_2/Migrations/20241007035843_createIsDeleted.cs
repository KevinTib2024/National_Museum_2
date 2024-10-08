using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace National_Museum_2.Migrations
{
    /// <inheritdoc />
    public partial class createIsDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "workShedule",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "typeEmployee",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ticketXCollection",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ticketType",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "ticket",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "state",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "paymentMethods",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "maintenance",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "location",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "exhibition",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "employeesXArtRoom",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "employee",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "collection",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "artRoom",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "artObject",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "workShedule");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "typeEmployee");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ticketXCollection");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ticketType");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ticket");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "state");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "paymentMethods");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "maintenance");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "location");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "exhibition");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "employeesXArtRoom");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "employee");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "collection");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "categories");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "artRoom");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "artObject");
        }
    }
}
