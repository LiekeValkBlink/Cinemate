using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinemate.API.Migrations
{
    /// <inheritdoc />
    public partial class ChangedReservationEntityAgain : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ticket_id",
                table: "reservations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ticket_id",
                table: "reservations",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
