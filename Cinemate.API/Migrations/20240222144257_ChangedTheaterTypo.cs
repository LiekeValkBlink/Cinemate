using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cinemate.API.Migrations
{
    /// <inheritdoc />
    public partial class ChangedTheaterTypo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_screenings_theather_rooms_TheatherRoomId",
                table: "screenings");

            migrationBuilder.DropForeignKey(
                name: "FK_seats_theather_rooms_TheatherRoomId",
                table: "seats");

            migrationBuilder.DropTable(
                name: "theather_rooms");

            migrationBuilder.DropTable(
                name: "theathers");

            migrationBuilder.DropIndex(
                name: "IX_seats_TheatherRoomId",
                table: "seats");

            migrationBuilder.DropIndex(
                name: "IX_screenings_TheatherRoomId",
                table: "screenings");

            migrationBuilder.DropColumn(
                name: "TheatherRoomId",
                table: "seats");

            migrationBuilder.DropColumn(
                name: "TheatherRoomId",
                table: "screenings");

            migrationBuilder.CreateTable(
                name: "theaters",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    street = table.Column<string>(type: "text", nullable: false),
                    house_nr = table.Column<string>(type: "text", nullable: true),
                    city = table.Column<string>(type: "text", nullable: false),
                    country = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_theaters", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "theater_rooms",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    seats_no = table.Column<int>(type: "integer", nullable: false),
                    theater_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_theater_rooms", x => x.id);
                    table.ForeignKey(
                        name: "FK_theater_rooms_theaters_theater_id",
                        column: x => x.theater_id,
                        principalTable: "theaters",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_seats_theater_room_id",
                table: "seats",
                column: "theater_room_id");

            migrationBuilder.CreateIndex(
                name: "IX_screenings_theater_room_id",
                table: "screenings",
                column: "theater_room_id");

            migrationBuilder.CreateIndex(
                name: "IX_theater_rooms_theater_id",
                table: "theater_rooms",
                column: "theater_id");

            migrationBuilder.CreateIndex(
                name: "IX_theaters_name",
                table: "theaters",
                column: "name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_screenings_theater_rooms_theater_room_id",
                table: "screenings",
                column: "theater_room_id",
                principalTable: "theater_rooms",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_seats_theater_rooms_theater_room_id",
                table: "seats",
                column: "theater_room_id",
                principalTable: "theater_rooms",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_screenings_theater_rooms_theater_room_id",
                table: "screenings");

            migrationBuilder.DropForeignKey(
                name: "FK_seats_theater_rooms_theater_room_id",
                table: "seats");

            migrationBuilder.DropTable(
                name: "theater_rooms");

            migrationBuilder.DropTable(
                name: "theaters");

            migrationBuilder.DropIndex(
                name: "IX_seats_theater_room_id",
                table: "seats");

            migrationBuilder.DropIndex(
                name: "IX_screenings_theater_room_id",
                table: "screenings");

            migrationBuilder.AddColumn<int>(
                name: "TheatherRoomId",
                table: "seats",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TheatherRoomId",
                table: "screenings",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "theathers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    city = table.Column<string>(type: "text", nullable: false),
                    country = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    house_nr = table.Column<string>(type: "text", nullable: true),
                    name = table.Column<string>(type: "text", nullable: false),
                    street = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_theathers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "theather_rooms",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TheatherId = table.Column<int>(type: "integer", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    seats_no = table.Column<int>(type: "integer", nullable: false),
                    theater_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_theather_rooms", x => x.id);
                    table.ForeignKey(
                        name: "FK_theather_rooms_theathers_TheatherId",
                        column: x => x.TheatherId,
                        principalTable: "theathers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_seats_TheatherRoomId",
                table: "seats",
                column: "TheatherRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_screenings_TheatherRoomId",
                table: "screenings",
                column: "TheatherRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_theather_rooms_TheatherId",
                table: "theather_rooms",
                column: "TheatherId");

            migrationBuilder.CreateIndex(
                name: "IX_theathers_name",
                table: "theathers",
                column: "name",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_screenings_theather_rooms_TheatherRoomId",
                table: "screenings",
                column: "TheatherRoomId",
                principalTable: "theather_rooms",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_seats_theather_rooms_TheatherRoomId",
                table: "seats",
                column: "TheatherRoomId",
                principalTable: "theather_rooms",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
