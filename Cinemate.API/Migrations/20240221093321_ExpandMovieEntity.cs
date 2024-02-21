using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Cinemate.API.Migrations
{
    /// <inheritdoc />
    public partial class ExpandMovieEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "authorizations",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descriptions = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_authorizations", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "movie_categories",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movie_categories", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "promo_codes",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    active = table.Column<bool>(type: "boolean", nullable: false),
                    uses_left = table.Column<int>(type: "integer", nullable: true),
                    discount = table.Column<string>(type: "text", nullable: false),
                    discount_type = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_promo_codes", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "theathers",
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
                    table.PrimaryKey("PK_theathers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    email = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    subscribed_to_newsletter = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    first_name = table.Column<string>(type: "text", nullable: false),
                    last_name = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    authorization_id = table.Column<int>(type: "integer", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.id);
                    table.ForeignKey(
                        name: "FK_employees_authorizations_authorization_id",
                        column: x => x.authorization_id,
                        principalTable: "authorizations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "movies",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "text", nullable: false),
                    description = table.Column<string>(type: "text", nullable: false),
                    duration = table.Column<int>(type: "integer", nullable: false),
                    release_year = table.Column<int>(type: "integer", nullable: false),
                    movie_category_id = table.Column<int>(type: "integer", nullable: false),
                    director = table.Column<string>(type: "text", nullable: false),
                    cast = table.Column<string>(type: "text", nullable: false),
                    review = table.Column<decimal>(type: "numeric", nullable: false),
                    kijkwijzers = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_movies", x => x.id);
                    table.ForeignKey(
                        name: "FK_movies_movie_categories_movie_category_id",
                        column: x => x.movie_category_id,
                        principalTable: "movie_categories",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "theather_rooms",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    seats_no = table.Column<int>(type: "integer", nullable: false),
                    theater_id = table.Column<int>(type: "integer", nullable: false),
                    TheatherId = table.Column<int>(type: "integer", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "screenings",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    movie_id = table.Column<int>(type: "integer", nullable: false),
                    theater_room_id = table.Column<int>(type: "integer", nullable: false),
                    movie_start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    TheatherRoomId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_screenings", x => x.id);
                    table.ForeignKey(
                        name: "FK_screenings_movies_movie_id",
                        column: x => x.movie_id,
                        principalTable: "movies",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_screenings_theather_rooms_TheatherRoomId",
                        column: x => x.TheatherRoomId,
                        principalTable: "theather_rooms",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "seats",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    row = table.Column<int>(type: "integer", nullable: false),
                    number = table.Column<int>(type: "integer", nullable: false),
                    theater_room_id = table.Column<int>(type: "integer", nullable: false),
                    TheatherRoomId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seats", x => x.id);
                    table.ForeignKey(
                        name: "FK_seats_theather_rooms_TheatherRoomId",
                        column: x => x.TheatherRoomId,
                        principalTable: "theather_rooms",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "reservations",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    seat_reserved_id = table.Column<int>(type: "integer", nullable: false),
                    paid = table.Column<bool>(type: "boolean", nullable: false),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    employee_id = table.Column<int>(type: "integer", nullable: true),
                    ticket_id = table.Column<int>(type: "integer", nullable: false),
                    payment_type = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservations", x => x.id);
                    table.ForeignKey(
                        name: "FK_reservations_employees_employee_id",
                        column: x => x.employee_id,
                        principalTable: "employees",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_reservations_screenings_screening_id",
                        column: x => x.screening_id,
                        principalTable: "screenings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservations_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "user_reviews",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false),
                    review = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user_reviews", x => x.id);
                    table.ForeignKey(
                        name: "FK_user_reviews_screenings_screening_id",
                        column: x => x.screening_id,
                        principalTable: "screenings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_user_reviews_users_user_id",
                        column: x => x.user_id,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "seats_reserved",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    seat_id = table.Column<int>(type: "integer", nullable: false),
                    reservation_id = table.Column<int>(type: "integer", nullable: false),
                    screening_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seats_reserved", x => x.id);
                    table.ForeignKey(
                        name: "FK_seats_reserved_reservations_reservation_id",
                        column: x => x.reservation_id,
                        principalTable: "reservations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_seats_reserved_screenings_screening_id",
                        column: x => x.screening_id,
                        principalTable: "screenings",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_seats_reserved_seats_seat_id",
                        column: x => x.seat_id,
                        principalTable: "seats",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tickets",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    reservation_id = table.Column<int>(type: "integer", nullable: false),
                    base_price = table.Column<decimal>(type: "numeric", nullable: false),
                    price_after_discount = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tickets", x => x.id);
                    table.ForeignKey(
                        name: "FK_tickets_reservations_reservation_id",
                        column: x => x.reservation_id,
                        principalTable: "reservations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ticket_promo_codes",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "integer", nullable: false),
                    PromoCodeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ticket_promo_codes", x => new { x.TicketId, x.PromoCodeId });
                    table.ForeignKey(
                        name: "FK_ticket_promo_codes_promo_codes_PromoCodeId",
                        column: x => x.PromoCodeId,
                        principalTable: "promo_codes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ticket_promo_codes_tickets_TicketId",
                        column: x => x.TicketId,
                        principalTable: "tickets",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_authorizations_descriptions",
                table: "authorizations",
                column: "descriptions",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_employees_authorization_id",
                table: "employees",
                column: "authorization_id");

            migrationBuilder.CreateIndex(
                name: "IX_employees_email",
                table: "employees",
                column: "email",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_movies_movie_category_id",
                table: "movies",
                column: "movie_category_id");

            migrationBuilder.CreateIndex(
                name: "IX_promo_codes_name",
                table: "promo_codes",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_reservations_employee_id",
                table: "reservations",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_screening_id",
                table: "reservations",
                column: "screening_id");

            migrationBuilder.CreateIndex(
                name: "IX_reservations_user_id",
                table: "reservations",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_screenings_TheatherRoomId",
                table: "screenings",
                column: "TheatherRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_screenings_movie_id",
                table: "screenings",
                column: "movie_id");

            migrationBuilder.CreateIndex(
                name: "IX_seats_TheatherRoomId",
                table: "seats",
                column: "TheatherRoomId");

            migrationBuilder.CreateIndex(
                name: "IX_seats_reserved_reservation_id",
                table: "seats_reserved",
                column: "reservation_id");

            migrationBuilder.CreateIndex(
                name: "IX_seats_reserved_screening_id",
                table: "seats_reserved",
                column: "screening_id");

            migrationBuilder.CreateIndex(
                name: "IX_seats_reserved_seat_id",
                table: "seats_reserved",
                column: "seat_id");

            migrationBuilder.CreateIndex(
                name: "IX_theather_rooms_TheatherId",
                table: "theather_rooms",
                column: "TheatherId");

            migrationBuilder.CreateIndex(
                name: "IX_theathers_name",
                table: "theathers",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ticket_promo_codes_PromoCodeId",
                table: "ticket_promo_codes",
                column: "PromoCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_tickets_reservation_id",
                table: "tickets",
                column: "reservation_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_reviews_screening_id",
                table: "user_reviews",
                column: "screening_id");

            migrationBuilder.CreateIndex(
                name: "IX_user_reviews_user_id",
                table: "user_reviews",
                column: "user_id");

            migrationBuilder.CreateIndex(
                name: "IX_users_email",
                table: "users",
                column: "email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "seats_reserved");

            migrationBuilder.DropTable(
                name: "ticket_promo_codes");

            migrationBuilder.DropTable(
                name: "user_reviews");

            migrationBuilder.DropTable(
                name: "seats");

            migrationBuilder.DropTable(
                name: "promo_codes");

            migrationBuilder.DropTable(
                name: "tickets");

            migrationBuilder.DropTable(
                name: "reservations");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "screenings");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "authorizations");

            migrationBuilder.DropTable(
                name: "movies");

            migrationBuilder.DropTable(
                name: "theather_rooms");

            migrationBuilder.DropTable(
                name: "movie_categories");

            migrationBuilder.DropTable(
                name: "theathers");
        }
    }
}
