using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinemate.API.Migrations
{
    /// <inheritdoc />
    public partial class testseedmigration : Migration
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
                    actor_cast = table.Column<string>(type: "text", nullable: false),
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
                name: "theater_rooms",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
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

            migrationBuilder.CreateTable(
                name: "screenings",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    movie_id = table.Column<int>(type: "integer", nullable: false),
                    theater_room_id = table.Column<int>(type: "integer", nullable: false),
                    movie_start = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
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
                        name: "FK_screenings_theater_rooms_theater_room_id",
                        column: x => x.theater_room_id,
                        principalTable: "theater_rooms",
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
                    theater_room_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_seats", x => x.id);
                    table.ForeignKey(
                        name: "FK_seats_theater_rooms_theater_room_id",
                        column: x => x.theater_room_id,
                        principalTable: "theater_rooms",
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
                    paid = table.Column<bool>(type: "boolean", nullable: false),
                    user_id = table.Column<int>(type: "integer", nullable: false),
                    employee_id = table.Column<int>(type: "integer", nullable: true),
                    price = table.Column<decimal>(type: "numeric", nullable: false),
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
                name: "reservation_promo_codes",
                columns: table => new
                {
                    ReservationId = table.Column<int>(type: "integer", nullable: false),
                    PromoCodeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reservation_promo_codes", x => new { x.ReservationId, x.PromoCodeId });
                    table.ForeignKey(
                        name: "FK_reservation_promo_codes_promo_codes_PromoCodeId",
                        column: x => x.PromoCodeId,
                        principalTable: "promo_codes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_reservation_promo_codes_reservations_ReservationId",
                        column: x => x.ReservationId,
                        principalTable: "reservations",
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
                    reservation_id = table.Column<int>(type: "integer", nullable: false)
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
                        name: "FK_seats_reserved_seats_seat_id",
                        column: x => x.seat_id,
                        principalTable: "seats",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "authorizations",
                columns: new[] { "id", "descriptions" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" }
                });

            migrationBuilder.InsertData(
                table: "movie_categories",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Comedy" },
                    { 3, "Drama" },
                    { 4, "Horror" },
                    { 5, "Science Fiction" },
                    { 6, "Thriller" },
                    { 7, "Romance" },
                    { 8, "Adventure" },
                    { 9, "Fantasy" },
                    { 10, "Animation" }
                });

            migrationBuilder.InsertData(
                table: "promo_codes",
                columns: new[] { "id", "active", "discount", "discount_type", "name", "uses_left" },
                values: new object[,]
                {
                    { 1, true, "2.5", "DecimalDecrease", "Geheime film", 999999 },
                    { 2, true, "2.5", "DecimalIncrease", "Popcorn arrangement", 999999 }
                });

            migrationBuilder.InsertData(
                table: "theaters",
                columns: new[] { "id", "city", "country", "house_nr", "name", "street" },
                values: new object[] { 1, "Breda", "NL", "1", "Cinemate", "Hogeschoollaan" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "email", "name", "password", "subscribed_to_newsletter" },
                values: new object[] { 1, "user1@example.com", "User 1", "password123", true });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "email", "name", "password" },
                values: new object[] { 2, "user2@example.com", "User 2", "password456" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "email", "name", "password", "subscribed_to_newsletter" },
                values: new object[] { 3, "user3@example.com", "User 3", "password789", true });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "email", "name", "password" },
                values: new object[] { 4, "user4@example.com", "User 4", "password321" });

            migrationBuilder.InsertData(
                table: "users",
                columns: new[] { "id", "email", "name", "password", "subscribed_to_newsletter" },
                values: new object[] { 5, "user5@example.com", "User 5", "password654", true });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "id", "authorization_id", "email", "first_name", "last_name", "password" },
                values: new object[,]
                {
                    { 1, 1, "john@example.com", "John", "Doe", "password123" },
                    { 2, 2, "jane@example.com", "Jane", "Smith", "password456" },
                    { 3, 2, "michael@example.com", "Michael", "Johnson", "password789" },
                    { 4, 2, "emily@example.com", "Emily", "Brown", "password321" },
                    { 5, 2, "william@example.com", "William", "Taylor", "password654" }
                });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "actor_cast", "description", "director", "duration", "kijkwijzers", "movie_category_id", "release_year", "review", "title" },
                values: new object[,]
                {
                    { 1, "Liam Neeson, Ewan McGregor, Natalie Portman", "Two Jedi Knights escape a hostile blockade to find allies and come across a young boy who may bring balance to the Force, but the long dormant Sith resurface to claim their original glory.", "George Lucas", 136, "12, Geweld", 1, 1999, 7.4m, "Star Wars: Episode I - The Phantom Menace" },
                    { 2, "Hayden Christensen, Natalie Portman, Ewan McGregor", "Ten years after initially meeting, Anakin Skywalker shares a forbidden romance with Padmé Amidala, while Obi-Wan Kenobi investigates an assassination attempt on the senator and discovers a secret clone army crafted for the Jedi.", "George Lucas", 142, "12, Geweld", 1, 2002, 6.5m, "Star Wars: Episode II - Attack of the Clones" },
                    { 3, "Hayden Christensen, Natalie Portman, Ewan McGregor", "Three years into the Clone Wars, the Jedi rescue Palpatine from Count Dooku. As Obi-Wan pursues a new threat, Anakin acts as a double agent between the Jedi Council and Palpatine and is lured into a sinister plan to rule the galaxy.", "George Lucas", 140, "12, Geweld", 1, 2005, 7.5m, "Star Wars: Episode III - Revenge of the Sith" },
                    { 4, "Tim Robbins, Morgan Freeman, Bob Gunton", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "Frank Darabont", 142, "Geweld, Discriminatie", 3, 1994, 9.3m, "The Shawshank Redemption" },
                    { 5, "Marlon Brando, Al Pacino, James Caan", "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", "Francis Ford Coppola", 175, "16, Geweld", 3, 1972, 9.2m, "The Godfather" },
                    { 6, "Christian Bale, Heath Ledger, Aaron Eckhart", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "Christopher Nolan", 152, "16, Geweld, Angst", 6, 2008, 9m, "The Dark Knight" },
                    { 7, "Elijah Wood, Viggo Mortensen, Ian McKellen", "Gandalf and Aragorn lead the World of Men against Saurons army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", "Peter Jackson", 201, "16, Geweld, Angst", 8, 2003, 8.9m, "The Lord of the Rings: The Return of the King" },
                    { 8, "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page", "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", "Christopher Nolan", 148, "12, Geweld, Angst", 5, 2010, 8.8m, "Inception" },
                    { 9, "John Travolta, Uma Thurman, Samuel L. Jackson", "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "Quentin Tarantino", 154, "16, Geweld, Angst", 6, 1994, 8.9m, "Pulp Fiction" },
                    { 10, "Tom Hanks, Robin Wright, Gary Sinise", "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.", "Robert Zemeckis", 142, "12, Geweld, Angst", 7, 1994, 8.8m, "Forrest Gump" }
                });

            migrationBuilder.InsertData(
                table: "theater_rooms",
                columns: new[] { "id", "name", "theater_id" },
                values: new object[,]
                {
                    { 1, "Zaal 1", 1 },
                    { 2, "Zaal 2", 1 },
                    { 3, "Zaal 3", 1 },
                    { 4, "Zaal 4", 1 },
                    { 5, "Zaal 5", 1 },
                    { 6, "Zaal 6", 1 }
                });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "movie_id", "movie_start", "theater_room_id" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 3, 11, 22, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 1 },
                    { 2, 1, new DateTime(2024, 3, 11, 22, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 2 },
                    { 3, 2, new DateTime(2024, 3, 11, 22, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 3 },
                    { 4, 4, new DateTime(2024, 3, 11, 22, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 4 },
                    { 5, 6, new DateTime(2024, 3, 11, 22, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 5 },
                    { 6, 5, new DateTime(2024, 3, 11, 22, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 6 },
                    { 7, 1, new DateTime(2024, 3, 12, 1, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 1 },
                    { 8, 6, new DateTime(2024, 3, 12, 1, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 2 },
                    { 9, 8, new DateTime(2024, 3, 12, 1, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 3 },
                    { 10, 6, new DateTime(2024, 3, 12, 1, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 4 },
                    { 11, 1, new DateTime(2024, 3, 12, 1, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 5 },
                    { 12, 3, new DateTime(2024, 3, 12, 1, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 6 },
                    { 13, 1, new DateTime(2024, 3, 12, 0, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 1 },
                    { 14, 2, new DateTime(2024, 3, 12, 0, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 2 },
                    { 15, 3, new DateTime(2024, 3, 12, 0, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 3 },
                    { 16, 7, new DateTime(2024, 3, 12, 0, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 4 },
                    { 17, 6, new DateTime(2024, 3, 12, 0, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 5 },
                    { 18, 4, new DateTime(2024, 3, 11, 22, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 6 },
                    { 19, 1, new DateTime(2024, 3, 12, 19, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 1 },
                    { 20, 1, new DateTime(2024, 3, 12, 19, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 2 },
                    { 21, 2, new DateTime(2024, 3, 12, 19, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 3 },
                    { 22, 4, new DateTime(2024, 3, 12, 19, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 4 },
                    { 23, 6, new DateTime(2024, 3, 12, 19, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 5 },
                    { 24, 5, new DateTime(2024, 3, 12, 19, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 6 },
                    { 25, 1, new DateTime(2024, 3, 12, 19, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 1 },
                    { 26, 6, new DateTime(2024, 3, 12, 19, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 2 },
                    { 27, 8, new DateTime(2024, 3, 12, 19, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 3 },
                    { 28, 6, new DateTime(2024, 3, 12, 19, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 4 },
                    { 29, 1, new DateTime(2024, 3, 12, 19, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 5 },
                    { 30, 3, new DateTime(2024, 3, 12, 19, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 6 },
                    { 31, 1, new DateTime(2024, 3, 12, 19, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 1 },
                    { 32, 2, new DateTime(2024, 3, 12, 19, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 2 },
                    { 33, 3, new DateTime(2024, 3, 12, 19, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 3 },
                    { 34, 7, new DateTime(2024, 3, 12, 19, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 4 },
                    { 35, 6, new DateTime(2024, 3, 12, 19, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 5 },
                    { 36, 4, new DateTime(2024, 3, 12, 19, 59, 28, 51, DateTimeKind.Utc).AddTicks(7776), 6 }
                });

            migrationBuilder.InsertData(
                table: "seats",
                columns: new[] { "id", "number", "row", "theater_room_id" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 2, 1, 1 },
                    { 3, 3, 1, 1 },
                    { 4, 4, 1, 1 },
                    { 5, 5, 1, 1 },
                    { 6, 6, 1, 1 },
                    { 7, 7, 1, 1 },
                    { 8, 8, 1, 1 },
                    { 9, 9, 1, 1 },
                    { 10, 10, 1, 1 },
                    { 11, 11, 1, 1 },
                    { 12, 12, 1, 1 },
                    { 13, 13, 1, 1 },
                    { 14, 14, 1, 1 },
                    { 15, 15, 1, 1 },
                    { 16, 1, 2, 1 },
                    { 17, 2, 2, 1 },
                    { 18, 3, 2, 1 },
                    { 19, 4, 2, 1 },
                    { 20, 5, 2, 1 },
                    { 21, 6, 2, 1 },
                    { 22, 7, 2, 1 },
                    { 23, 8, 2, 1 },
                    { 24, 9, 2, 1 },
                    { 25, 10, 2, 1 },
                    { 26, 11, 2, 1 },
                    { 27, 12, 2, 1 },
                    { 28, 13, 2, 1 },
                    { 29, 14, 2, 1 },
                    { 30, 15, 2, 1 },
                    { 31, 1, 3, 1 },
                    { 32, 2, 3, 1 },
                    { 33, 3, 3, 1 },
                    { 34, 4, 3, 1 },
                    { 35, 5, 3, 1 },
                    { 36, 6, 3, 1 },
                    { 37, 7, 3, 1 },
                    { 38, 8, 3, 1 },
                    { 39, 9, 3, 1 },
                    { 40, 10, 3, 1 },
                    { 41, 11, 3, 1 },
                    { 42, 12, 3, 1 },
                    { 43, 13, 3, 1 },
                    { 44, 14, 3, 1 },
                    { 45, 15, 3, 1 },
                    { 46, 1, 4, 1 },
                    { 47, 2, 4, 1 },
                    { 48, 3, 4, 1 },
                    { 49, 4, 4, 1 },
                    { 50, 5, 4, 1 },
                    { 51, 6, 4, 1 },
                    { 52, 7, 4, 1 },
                    { 53, 8, 4, 1 },
                    { 54, 9, 4, 1 },
                    { 55, 10, 4, 1 },
                    { 56, 11, 4, 1 },
                    { 57, 12, 4, 1 },
                    { 58, 13, 4, 1 },
                    { 59, 14, 4, 1 },
                    { 60, 15, 4, 1 },
                    { 61, 1, 5, 1 },
                    { 62, 2, 5, 1 },
                    { 63, 3, 5, 1 },
                    { 64, 4, 5, 1 },
                    { 65, 5, 5, 1 },
                    { 66, 6, 5, 1 },
                    { 67, 7, 5, 1 },
                    { 68, 8, 5, 1 },
                    { 69, 9, 5, 1 },
                    { 70, 10, 5, 1 },
                    { 71, 11, 5, 1 },
                    { 72, 12, 5, 1 },
                    { 73, 13, 5, 1 },
                    { 74, 14, 5, 1 },
                    { 75, 15, 5, 1 },
                    { 76, 1, 6, 1 },
                    { 77, 2, 6, 1 },
                    { 78, 3, 6, 1 },
                    { 79, 4, 6, 1 },
                    { 80, 5, 6, 1 },
                    { 81, 6, 6, 1 },
                    { 82, 7, 6, 1 },
                    { 83, 8, 6, 1 },
                    { 84, 9, 6, 1 },
                    { 85, 10, 6, 1 },
                    { 86, 11, 6, 1 },
                    { 87, 12, 6, 1 },
                    { 88, 13, 6, 1 },
                    { 89, 14, 6, 1 },
                    { 90, 15, 6, 1 },
                    { 91, 1, 7, 1 },
                    { 92, 2, 7, 1 },
                    { 93, 3, 7, 1 },
                    { 94, 4, 7, 1 },
                    { 95, 5, 7, 1 },
                    { 96, 6, 7, 1 },
                    { 97, 7, 7, 1 },
                    { 98, 8, 7, 1 },
                    { 99, 9, 7, 1 },
                    { 100, 10, 7, 1 },
                    { 101, 11, 7, 1 },
                    { 102, 12, 7, 1 },
                    { 103, 13, 7, 1 },
                    { 104, 14, 7, 1 },
                    { 105, 15, 7, 1 },
                    { 106, 1, 8, 1 },
                    { 107, 2, 8, 1 },
                    { 108, 3, 8, 1 },
                    { 109, 4, 8, 1 },
                    { 110, 5, 8, 1 },
                    { 111, 6, 8, 1 },
                    { 112, 7, 8, 1 },
                    { 113, 8, 8, 1 },
                    { 114, 9, 8, 1 },
                    { 115, 10, 8, 1 },
                    { 116, 11, 8, 1 },
                    { 117, 12, 8, 1 },
                    { 118, 13, 8, 1 },
                    { 119, 14, 8, 1 },
                    { 120, 15, 8, 1 },
                    { 121, 1, 1, 2 },
                    { 122, 2, 1, 2 },
                    { 123, 3, 1, 2 },
                    { 124, 4, 1, 2 },
                    { 125, 5, 1, 2 },
                    { 126, 6, 1, 2 },
                    { 127, 7, 1, 2 },
                    { 128, 8, 1, 2 },
                    { 129, 9, 1, 2 },
                    { 130, 10, 1, 2 },
                    { 131, 11, 1, 2 },
                    { 132, 12, 1, 2 },
                    { 133, 13, 1, 2 },
                    { 134, 14, 1, 2 },
                    { 135, 15, 1, 2 },
                    { 136, 1, 2, 2 },
                    { 137, 2, 2, 2 },
                    { 138, 3, 2, 2 },
                    { 139, 4, 2, 2 },
                    { 140, 5, 2, 2 },
                    { 141, 6, 2, 2 },
                    { 142, 7, 2, 2 },
                    { 143, 8, 2, 2 },
                    { 144, 9, 2, 2 },
                    { 145, 10, 2, 2 },
                    { 146, 11, 2, 2 },
                    { 147, 12, 2, 2 },
                    { 148, 13, 2, 2 },
                    { 149, 14, 2, 2 },
                    { 150, 15, 2, 2 },
                    { 151, 1, 3, 2 },
                    { 152, 2, 3, 2 },
                    { 153, 3, 3, 2 },
                    { 154, 4, 3, 2 },
                    { 155, 5, 3, 2 },
                    { 156, 6, 3, 2 },
                    { 157, 7, 3, 2 },
                    { 158, 8, 3, 2 },
                    { 159, 9, 3, 2 },
                    { 160, 10, 3, 2 },
                    { 161, 11, 3, 2 },
                    { 162, 12, 3, 2 },
                    { 163, 13, 3, 2 },
                    { 164, 14, 3, 2 },
                    { 165, 15, 3, 2 },
                    { 166, 1, 4, 2 },
                    { 167, 2, 4, 2 },
                    { 168, 3, 4, 2 },
                    { 169, 4, 4, 2 },
                    { 170, 5, 4, 2 },
                    { 171, 6, 4, 2 },
                    { 172, 7, 4, 2 },
                    { 173, 8, 4, 2 },
                    { 174, 9, 4, 2 },
                    { 175, 10, 4, 2 },
                    { 176, 11, 4, 2 },
                    { 177, 12, 4, 2 },
                    { 178, 13, 4, 2 },
                    { 179, 14, 4, 2 },
                    { 180, 15, 4, 2 },
                    { 181, 1, 5, 2 },
                    { 182, 2, 5, 2 },
                    { 183, 3, 5, 2 },
                    { 184, 4, 5, 2 },
                    { 185, 5, 5, 2 },
                    { 186, 6, 5, 2 },
                    { 187, 7, 5, 2 },
                    { 188, 8, 5, 2 },
                    { 189, 9, 5, 2 },
                    { 190, 10, 5, 2 },
                    { 191, 11, 5, 2 },
                    { 192, 12, 5, 2 },
                    { 193, 13, 5, 2 },
                    { 194, 14, 5, 2 },
                    { 195, 15, 5, 2 },
                    { 196, 1, 6, 2 },
                    { 197, 2, 6, 2 },
                    { 198, 3, 6, 2 },
                    { 199, 4, 6, 2 },
                    { 200, 5, 6, 2 },
                    { 201, 6, 6, 2 },
                    { 202, 7, 6, 2 },
                    { 203, 8, 6, 2 },
                    { 204, 9, 6, 2 },
                    { 205, 10, 6, 2 },
                    { 206, 11, 6, 2 },
                    { 207, 12, 6, 2 },
                    { 208, 13, 6, 2 },
                    { 209, 14, 6, 2 },
                    { 210, 15, 6, 2 },
                    { 211, 1, 7, 2 },
                    { 212, 2, 7, 2 },
                    { 213, 3, 7, 2 },
                    { 214, 4, 7, 2 },
                    { 215, 5, 7, 2 },
                    { 216, 6, 7, 2 },
                    { 217, 7, 7, 2 },
                    { 218, 8, 7, 2 },
                    { 219, 9, 7, 2 },
                    { 220, 10, 7, 2 },
                    { 221, 11, 7, 2 },
                    { 222, 12, 7, 2 },
                    { 223, 13, 7, 2 },
                    { 224, 14, 7, 2 },
                    { 225, 15, 7, 2 },
                    { 226, 1, 8, 2 },
                    { 227, 2, 8, 2 },
                    { 228, 3, 8, 2 },
                    { 229, 4, 8, 2 },
                    { 230, 5, 8, 2 },
                    { 231, 6, 8, 2 },
                    { 232, 7, 8, 2 },
                    { 233, 8, 8, 2 },
                    { 234, 9, 8, 2 },
                    { 235, 10, 8, 2 },
                    { 236, 11, 8, 2 },
                    { 237, 12, 8, 2 },
                    { 238, 13, 8, 2 },
                    { 239, 14, 8, 2 },
                    { 240, 15, 8, 2 },
                    { 241, 1, 1, 3 },
                    { 242, 2, 1, 3 },
                    { 243, 3, 1, 3 },
                    { 244, 4, 1, 3 },
                    { 245, 5, 1, 3 },
                    { 246, 6, 1, 3 },
                    { 247, 7, 1, 3 },
                    { 248, 8, 1, 3 },
                    { 249, 9, 1, 3 },
                    { 250, 10, 1, 3 },
                    { 251, 11, 1, 3 },
                    { 252, 12, 1, 3 },
                    { 253, 13, 1, 3 },
                    { 254, 14, 1, 3 },
                    { 255, 15, 1, 3 },
                    { 256, 1, 2, 3 },
                    { 257, 2, 2, 3 },
                    { 258, 3, 2, 3 },
                    { 259, 4, 2, 3 },
                    { 260, 5, 2, 3 },
                    { 261, 6, 2, 3 },
                    { 262, 7, 2, 3 },
                    { 263, 8, 2, 3 },
                    { 264, 9, 2, 3 },
                    { 265, 10, 2, 3 },
                    { 266, 11, 2, 3 },
                    { 267, 12, 2, 3 },
                    { 268, 13, 2, 3 },
                    { 269, 14, 2, 3 },
                    { 270, 15, 2, 3 },
                    { 271, 1, 3, 3 },
                    { 272, 2, 3, 3 },
                    { 273, 3, 3, 3 },
                    { 274, 4, 3, 3 },
                    { 275, 5, 3, 3 },
                    { 276, 6, 3, 3 },
                    { 277, 7, 3, 3 },
                    { 278, 8, 3, 3 },
                    { 279, 9, 3, 3 },
                    { 280, 10, 3, 3 },
                    { 281, 11, 3, 3 },
                    { 282, 12, 3, 3 },
                    { 283, 13, 3, 3 },
                    { 284, 14, 3, 3 },
                    { 285, 15, 3, 3 },
                    { 286, 1, 4, 3 },
                    { 287, 2, 4, 3 },
                    { 288, 3, 4, 3 },
                    { 289, 4, 4, 3 },
                    { 290, 5, 4, 3 },
                    { 291, 6, 4, 3 },
                    { 292, 7, 4, 3 },
                    { 293, 8, 4, 3 },
                    { 294, 9, 4, 3 },
                    { 295, 10, 4, 3 },
                    { 296, 11, 4, 3 },
                    { 297, 12, 4, 3 },
                    { 298, 13, 4, 3 },
                    { 299, 14, 4, 3 },
                    { 300, 15, 4, 3 },
                    { 301, 1, 5, 3 },
                    { 302, 2, 5, 3 },
                    { 303, 3, 5, 3 },
                    { 304, 4, 5, 3 },
                    { 305, 5, 5, 3 },
                    { 306, 6, 5, 3 },
                    { 307, 7, 5, 3 },
                    { 308, 8, 5, 3 },
                    { 309, 9, 5, 3 },
                    { 310, 10, 5, 3 },
                    { 311, 11, 5, 3 },
                    { 312, 12, 5, 3 },
                    { 313, 13, 5, 3 },
                    { 314, 14, 5, 3 },
                    { 315, 15, 5, 3 },
                    { 316, 1, 6, 3 },
                    { 317, 2, 6, 3 },
                    { 318, 3, 6, 3 },
                    { 319, 4, 6, 3 },
                    { 320, 5, 6, 3 },
                    { 321, 6, 6, 3 },
                    { 322, 7, 6, 3 },
                    { 323, 8, 6, 3 },
                    { 324, 9, 6, 3 },
                    { 325, 10, 6, 3 },
                    { 326, 11, 6, 3 },
                    { 327, 12, 6, 3 },
                    { 328, 13, 6, 3 },
                    { 329, 14, 6, 3 },
                    { 330, 15, 6, 3 },
                    { 331, 1, 7, 3 },
                    { 332, 2, 7, 3 },
                    { 333, 3, 7, 3 },
                    { 334, 4, 7, 3 },
                    { 335, 5, 7, 3 },
                    { 336, 6, 7, 3 },
                    { 337, 7, 7, 3 },
                    { 338, 8, 7, 3 },
                    { 339, 9, 7, 3 },
                    { 340, 10, 7, 3 },
                    { 341, 11, 7, 3 },
                    { 342, 12, 7, 3 },
                    { 343, 13, 7, 3 },
                    { 344, 14, 7, 3 },
                    { 345, 15, 7, 3 },
                    { 346, 1, 8, 3 },
                    { 347, 2, 8, 3 },
                    { 348, 3, 8, 3 },
                    { 349, 4, 8, 3 },
                    { 350, 5, 8, 3 },
                    { 351, 6, 8, 3 },
                    { 352, 7, 8, 3 },
                    { 353, 8, 8, 3 },
                    { 354, 9, 8, 3 },
                    { 355, 10, 8, 3 },
                    { 356, 11, 8, 3 },
                    { 357, 12, 8, 3 },
                    { 358, 13, 8, 3 },
                    { 359, 14, 8, 3 },
                    { 360, 15, 8, 3 },
                    { 361, 1, 1, 4 },
                    { 362, 2, 1, 4 },
                    { 363, 3, 1, 4 },
                    { 364, 4, 1, 4 },
                    { 365, 5, 1, 4 },
                    { 366, 6, 1, 4 },
                    { 367, 7, 1, 4 },
                    { 368, 8, 1, 4 },
                    { 369, 9, 1, 4 },
                    { 370, 10, 1, 4 },
                    { 371, 1, 2, 4 },
                    { 372, 2, 2, 4 },
                    { 373, 3, 2, 4 },
                    { 374, 4, 2, 4 },
                    { 375, 5, 2, 4 },
                    { 376, 6, 2, 4 },
                    { 377, 7, 2, 4 },
                    { 378, 8, 2, 4 },
                    { 379, 9, 2, 4 },
                    { 380, 10, 2, 4 },
                    { 381, 1, 3, 4 },
                    { 382, 2, 3, 4 },
                    { 383, 3, 3, 4 },
                    { 384, 4, 3, 4 },
                    { 385, 5, 3, 4 },
                    { 386, 6, 3, 4 },
                    { 387, 7, 3, 4 },
                    { 388, 8, 3, 4 },
                    { 389, 9, 3, 4 },
                    { 390, 10, 3, 4 },
                    { 391, 1, 4, 4 },
                    { 392, 2, 4, 4 },
                    { 393, 3, 4, 4 },
                    { 394, 4, 4, 4 },
                    { 395, 5, 4, 4 },
                    { 396, 6, 4, 4 },
                    { 397, 7, 4, 4 },
                    { 398, 8, 4, 4 },
                    { 399, 9, 4, 4 },
                    { 400, 10, 4, 4 },
                    { 401, 1, 5, 4 },
                    { 402, 2, 5, 4 },
                    { 403, 3, 5, 4 },
                    { 404, 4, 5, 4 },
                    { 405, 5, 5, 4 },
                    { 406, 6, 5, 4 },
                    { 407, 7, 5, 4 },
                    { 408, 8, 5, 4 },
                    { 409, 9, 5, 4 },
                    { 410, 10, 5, 4 },
                    { 411, 1, 6, 4 },
                    { 412, 2, 6, 4 },
                    { 413, 3, 6, 4 },
                    { 414, 4, 6, 4 },
                    { 415, 5, 6, 4 },
                    { 416, 6, 6, 4 },
                    { 417, 7, 6, 4 },
                    { 418, 8, 6, 4 },
                    { 419, 9, 6, 4 },
                    { 420, 10, 6, 4 },
                    { 421, 1, 1, 5 },
                    { 422, 2, 1, 5 },
                    { 423, 3, 1, 5 },
                    { 424, 4, 1, 5 },
                    { 425, 5, 1, 5 },
                    { 426, 6, 1, 5 },
                    { 427, 7, 1, 5 },
                    { 428, 8, 1, 5 },
                    { 429, 9, 1, 5 },
                    { 430, 10, 1, 5 },
                    { 431, 1, 2, 5 },
                    { 432, 2, 2, 5 },
                    { 433, 3, 2, 5 },
                    { 434, 4, 2, 5 },
                    { 435, 5, 2, 5 },
                    { 436, 6, 2, 5 },
                    { 437, 7, 2, 5 },
                    { 438, 8, 2, 5 },
                    { 439, 9, 2, 5 },
                    { 440, 10, 2, 5 },
                    { 441, 1, 3, 5 },
                    { 442, 2, 3, 5 },
                    { 443, 3, 3, 5 },
                    { 444, 4, 3, 5 },
                    { 445, 5, 3, 5 },
                    { 446, 6, 3, 5 },
                    { 447, 7, 3, 5 },
                    { 448, 8, 3, 5 },
                    { 449, 9, 3, 5 },
                    { 450, 10, 3, 5 },
                    { 451, 11, 3, 5 },
                    { 452, 12, 3, 5 },
                    { 453, 13, 3, 5 },
                    { 454, 14, 3, 5 },
                    { 455, 15, 3, 5 },
                    { 456, 1, 4, 5 },
                    { 457, 2, 4, 5 },
                    { 458, 3, 4, 5 },
                    { 459, 4, 4, 5 },
                    { 460, 5, 4, 5 },
                    { 461, 6, 4, 5 },
                    { 462, 7, 4, 5 },
                    { 463, 8, 4, 5 },
                    { 464, 9, 4, 5 },
                    { 465, 10, 4, 5 },
                    { 466, 11, 4, 5 },
                    { 467, 12, 4, 5 },
                    { 468, 13, 4, 5 },
                    { 469, 14, 4, 5 },
                    { 470, 15, 4, 5 },
                    { 471, 1, 1, 6 },
                    { 472, 2, 1, 6 },
                    { 473, 3, 1, 6 },
                    { 474, 4, 1, 6 },
                    { 475, 5, 1, 6 },
                    { 476, 6, 1, 6 },
                    { 477, 7, 1, 6 },
                    { 478, 8, 1, 6 },
                    { 479, 9, 1, 6 },
                    { 480, 10, 1, 6 },
                    { 481, 1, 2, 6 },
                    { 482, 2, 2, 6 },
                    { 483, 3, 2, 6 },
                    { 484, 4, 2, 6 },
                    { 485, 5, 2, 6 },
                    { 486, 6, 2, 6 },
                    { 487, 7, 2, 6 },
                    { 488, 8, 2, 6 },
                    { 489, 9, 2, 6 },
                    { 490, 10, 2, 6 },
                    { 491, 1, 3, 6 },
                    { 492, 2, 3, 6 },
                    { 493, 3, 3, 6 },
                    { 494, 4, 3, 6 },
                    { 495, 5, 3, 6 },
                    { 496, 6, 3, 6 },
                    { 497, 7, 3, 6 },
                    { 498, 8, 3, 6 },
                    { 499, 9, 3, 6 },
                    { 500, 10, 3, 6 },
                    { 501, 11, 3, 6 },
                    { 502, 12, 3, 6 },
                    { 503, 13, 3, 6 },
                    { 504, 14, 3, 6 },
                    { 505, 15, 3, 6 },
                    { 506, 1, 4, 6 },
                    { 507, 2, 4, 6 },
                    { 508, 3, 4, 6 },
                    { 509, 4, 4, 6 },
                    { 510, 5, 4, 6 },
                    { 511, 6, 4, 6 },
                    { 512, 7, 4, 6 },
                    { 513, 8, 4, 6 },
                    { 514, 9, 4, 6 },
                    { 515, 10, 4, 6 },
                    { 516, 11, 4, 6 },
                    { 517, 12, 4, 6 },
                    { 518, 13, 4, 6 },
                    { 519, 14, 4, 6 },
                    { 520, 15, 4, 6 }
                });

            migrationBuilder.InsertData(
                table: "reservations",
                columns: new[] { "id", "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[,]
                {
                    { 1, 1, true, "iDeal", 10m, 1, 1 },
                    { 2, 1, true, "Credit Card", 64.824255830724m, 32, 5 },
                    { 3, 1, true, "Cash", 51.1988356494902m, 16, 4 },
                    { 4, 1, false, "Cash", 27.4309056309211m, 9, 2 },
                    { 5, 5, false, "Credit Card", 9.28361853260913m, 2, 2 },
                    { 6, 1, false, "Credit Card", 68.0049032797286m, 13, 3 },
                    { 7, 3, false, "Credit Card", 94.9530324834073m, 7, 5 },
                    { 8, 3, true, "Cash", 31.94065085802m, 8, 4 },
                    { 9, 4, true, "Credit Card", 31.6942578450043m, 14, 2 },
                    { 10, 3, true, "Cash", 39.2642908579301m, 31, 4 },
                    { 11, 4, false, "Credit Card", 29.1115034813743m, 15, 1 },
                    { 12, 1, false, "Credit Card", 14.9562345599697m, 20, 3 },
                    { 13, 1, true, "Credit Card", 12.0717132586782m, 21, 1 },
                    { 14, 2, false, "Credit Card", 92.2239853007998m, 19, 1 },
                    { 15, 2, false, "Cash", 51.0074091968963m, 24, 2 },
                    { 16, 3, true, "Cash", 88.0757863430433m, 28, 1 },
                    { 17, 3, true, "Credit Card", 95.6340101981577m, 28, 2 },
                    { 18, 4, true, "Cash", 14.0711684812918m, 5, 1 },
                    { 19, 3, true, "Credit Card", 30.510057269244m, 34, 3 },
                    { 20, 4, false, "Credit Card", 57.7167128022977m, 7, 1 },
                    { 21, 5, true, "Cash", 96.7236608153117m, 8, 3 },
                    { 22, 2, false, "Credit Card", 98.0058976273508m, 31, 4 },
                    { 23, 3, true, "Credit Card", 30.55633386431m, 29, 5 },
                    { 24, 5, true, "Cash", 88.6676256465572m, 20, 2 },
                    { 25, 1, false, "Cash", 12.7776325844357m, 22, 1 },
                    { 26, 4, true, "Cash", 90.1193973357608m, 18, 1 },
                    { 27, 4, true, "Credit Card", 28.584903025808m, 33, 5 },
                    { 28, 4, false, "Cash", 73.4154650028589m, 25, 5 },
                    { 29, 5, true, "Credit Card", 44.1843533917767m, 25, 5 },
                    { 30, 4, true, "Cash", 26.6075616288719m, 9, 3 },
                    { 31, 4, false, "Cash", 4.12773342168359m, 28, 2 },
                    { 32, 4, false, "Cash", 79.4366389108672m, 32, 1 },
                    { 33, 2, true, "Cash", 79.6550752211783m, 14, 5 },
                    { 34, 4, false, "Credit Card", 98.0566948207705m, 15, 1 },
                    { 35, 4, false, "Cash", 72.1098689019756m, 11, 5 },
                    { 36, 1, true, "Credit Card", 60.7741934894308m, 36, 5 },
                    { 37, 5, true, "Cash", 15.2653973988144m, 31, 1 },
                    { 38, 5, true, "Credit Card", 61.6067774381981m, 23, 4 },
                    { 39, 4, false, "Credit Card", 71.723300124373m, 20, 1 },
                    { 40, 2, true, "Credit Card", 99.2422576105939m, 11, 1 },
                    { 41, 2, false, "Credit Card", 21.6914004263295m, 35, 2 },
                    { 42, 5, true, "Credit Card", 53.1133507501027m, 17, 4 },
                    { 43, 4, false, "Cash", 36.9751671964449m, 7, 3 },
                    { 44, 3, true, "Cash", 19.0943123042531m, 14, 5 },
                    { 45, 2, false, "Cash", 17.3308401408024m, 12, 5 },
                    { 46, 5, true, "Cash", 90.9930720355712m, 11, 1 },
                    { 47, 1, true, "Credit Card", 70.828129334384m, 15, 5 },
                    { 48, 3, false, "Credit Card", 29.4644207947078m, 31, 2 },
                    { 49, 2, true, "Cash", 47.7184735742364m, 30, 1 },
                    { 50, 1, false, "Cash", 69.2888790422756m, 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "reservation_promo_codes",
                columns: new[] { "PromoCodeId", "ReservationId" },
                values: new object[] { 2, 1 });

            migrationBuilder.InsertData(
                table: "seats_reserved",
                columns: new[] { "id", "reservation_id", "seat_id" },
                values: new object[,]
                {
                    { 1, 1, 13 },
                    { 2, 1, 14 },
                    { 3, 1, 15 }
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
                name: "IX_reservation_promo_codes_PromoCodeId",
                table: "reservation_promo_codes",
                column: "PromoCodeId");

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
                name: "IX_screenings_movie_id",
                table: "screenings",
                column: "movie_id");

            migrationBuilder.CreateIndex(
                name: "IX_screenings_theater_room_id",
                table: "screenings",
                column: "theater_room_id");

            migrationBuilder.CreateIndex(
                name: "IX_seats_theater_room_id",
                table: "seats",
                column: "theater_room_id");

            migrationBuilder.CreateIndex(
                name: "IX_seats_reserved_reservation_id",
                table: "seats_reserved",
                column: "reservation_id");

            migrationBuilder.CreateIndex(
                name: "IX_seats_reserved_seat_id",
                table: "seats_reserved",
                column: "seat_id");

            migrationBuilder.CreateIndex(
                name: "IX_theater_rooms_theater_id",
                table: "theater_rooms",
                column: "theater_id");

            migrationBuilder.CreateIndex(
                name: "IX_theaters_name",
                table: "theaters",
                column: "name",
                unique: true);

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
                name: "reservation_promo_codes");

            migrationBuilder.DropTable(
                name: "seats_reserved");

            migrationBuilder.DropTable(
                name: "user_reviews");

            migrationBuilder.DropTable(
                name: "promo_codes");

            migrationBuilder.DropTable(
                name: "reservations");

            migrationBuilder.DropTable(
                name: "seats");

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
                name: "theater_rooms");

            migrationBuilder.DropTable(
                name: "movie_categories");

            migrationBuilder.DropTable(
                name: "theaters");
        }
    }
}
