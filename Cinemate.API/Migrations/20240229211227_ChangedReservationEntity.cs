using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinemate.API.Migrations
{
    /// <inheritdoc />
    public partial class ChangedReservationEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "seat_reserved_id",
                table: "reservations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "seat_reserved_id",
                table: "reservations",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
