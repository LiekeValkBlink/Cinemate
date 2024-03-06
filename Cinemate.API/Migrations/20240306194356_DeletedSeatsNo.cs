using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinemate.API.Migrations
{
    /// <inheritdoc />
    public partial class DeletedSeatsNo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "seats_no",
                table: "theater_rooms");

            migrationBuilder.AddColumn<decimal>(
                name: "price",
                table: "reservations",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "price",
                table: "reservations");

            migrationBuilder.AddColumn<int>(
                name: "seats_no",
                table: "theater_rooms",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
