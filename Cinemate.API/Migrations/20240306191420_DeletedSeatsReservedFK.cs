using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinemate.API.Migrations
{
    /// <inheritdoc />
    public partial class DeletedSeatsReservedFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_seats_reserved_screenings_screening_id",
                table: "seats_reserved");

            migrationBuilder.DropIndex(
                name: "IX_seats_reserved_screening_id",
                table: "seats_reserved");

            migrationBuilder.DropColumn(
                name: "screening_id",
                table: "seats_reserved");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "screening_id",
                table: "seats_reserved",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_seats_reserved_screening_id",
                table: "seats_reserved",
                column: "screening_id");

            migrationBuilder.AddForeignKey(
                name: "FK_seats_reserved_screenings_screening_id",
                table: "seats_reserved",
                column: "screening_id",
                principalTable: "screenings",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
