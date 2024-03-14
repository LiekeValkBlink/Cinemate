using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinemate.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "release_country",
                table: "movies",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(2)",
                oldMaxLength: 2);

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                column: "kijkwijzers",
                value: "6 Jaar, Grof taalgebruik");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                column: "kijkwijzers",
                value: "12 Jaar, Geweld, Angst");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                column: "kijkwijzers",
                value: "6 Jaar, Grof taalgebruik");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                column: "kijkwijzers",
                value: "12 Jaar, Geweld, Angst");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                column: "kijkwijzers",
                value: "6 Jaar, Grof taalgebruik");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 7,
                column: "kijkwijzers",
                value: "12 Jaar, Geweld");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 8,
                column: "kijkwijzers",
                value: "12 Jaar, Geweld");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 9,
                column: "kijkwijzers",
                value: "Alle leeftijden");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 10,
                column: "kijkwijzers",
                value: "12 Jaar, Geweld");

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { "Credit Card", 67.1439190291413m, 28, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 5, 18.664058807101m, 18, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 4, false, 93.4970281137264m, 14, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "paid", "payment_type", "price", "screening_id" },
                values: new object[] { false, "Credit Card", 35.436253140274m, 19 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 3, 28.7847885836556m, 18, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 5, false, 20.8768300613176m, 36, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, 54.914044353827m, 10, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 1, 66.3456200882325m, 3, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, "Cash", 68.3841983800066m, 7, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, "Credit Card", 67.7930592630803m, 22, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "paid", "price", "screening_id", "user_id" },
                values: new object[] { false, 1.02149016872126m, 19, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, true, "Credit Card", 68.4890391566972m, 7, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 2, 69.3424415725606m, 34, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, "Credit Card", 9.16288815870351m, 14, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, 54.392241066165m, 18, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, true, "Cash", 85.1886953731598m, 11, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, "Cash", 28.1335030809549m, 15, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, "Credit Card", 4.91122493801542m, 5, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, true, "Credit Card", 89.9068754934068m, 33, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, false, "Cash", 6.50440741353705m, 28, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, 87.9205094127651m, 8, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 4, false, 51.5662504657667m, 9, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 5, 35.876719118591m, 31, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, "Credit Card", 1.73408890508094m, 6, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 2, false, 45.0295078612148m, 15, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, "Cash", 47.8600048070709m, 11, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, false, "Cash", 3.27600159593857m, 5, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 4, 63.9022367800807m, 23, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, "Credit Card", 83.89123857668m, 18, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, false, "Cash", 67.5162107498796m, 28, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "employee_id", "price", "screening_id" },
                values: new object[] { 5, 76.0970541395357m, 26 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { "Credit Card", 25.9298020605563m, 32, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, "Credit Card", 97.0175776301902m, 29, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { "Credit Card", 54.3923544345964m, 5, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, "Credit Card", 33.470070540807m, 19, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 1, true, 43.896997745234m, 34, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, 7.3124329808314m, 9, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, false, "Credit Card", 37.3141373022009m, 28, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, false, "Credit Card", 96.6430966499301m, 18, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "employee_id", "price", "user_id" },
                values: new object[] { 4, 16.007201295497m, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "employee_id", "paid", "price", "screening_id" },
                values: new object[] { 2, true, 19.2568782129275m, 9 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 4, 67.6343979426309m, 27, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 4, 5.13516079046921m, 20, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id" },
                values: new object[] { 1, "Cash", 71.7463442960554m, 22 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "employee_id", "paid", "price", "screening_id" },
                values: new object[] { 3, false, 95.6419111483441m, 19 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, "Cash", 68.509516715088m, 23, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { "Cash", 71.6784035470894m, 15, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id" },
                values: new object[] { 5, false, "Credit Card", 3.15087550570884m, 8 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "employee_id", "paid", "price", "screening_id" },
                values: new object[] { 5, true, 45.1774064155888m, 16 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                column: "movie_start",
                value: new DateTime(2024, 3, 13, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "movie_id", "movie_start" },
                values: new object[] { 2, new DateTime(2024, 3, 13, 20, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "movie_id", "movie_start" },
                values: new object[] { 3, new DateTime(2024, 3, 13, 20, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                column: "movie_start",
                value: new DateTime(2024, 3, 13, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "movie_id", "movie_start" },
                values: new object[] { 5, new DateTime(2024, 3, 13, 20, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 6, new DateTime(2024, 3, 13, 21, 0, 0, 0, DateTimeKind.Utc), 1 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 7, new DateTime(2024, 3, 13, 21, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 8, new DateTime(2024, 3, 13, 21, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 9, new DateTime(2024, 3, 13, 21, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 10, new DateTime(2024, 3, 13, 21, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 1, new DateTime(2024, 3, 13, 22, 0, 0, 0, DateTimeKind.Utc), 1 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 2, new DateTime(2024, 3, 13, 22, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 3, new DateTime(2024, 3, 13, 22, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 4, new DateTime(2024, 3, 13, 22, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 5, new DateTime(2024, 3, 13, 22, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 6, new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Utc), 1 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 7, new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 8, new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "movie_id", "theater_room_id" },
                values: new object[] { 9, 4 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "movie_id", "theater_room_id" },
                values: new object[] { 10, 5 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 1, new DateTime(2024, 3, 14, 21, 0, 0, 0, DateTimeKind.Utc), 1 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 2, new DateTime(2024, 3, 14, 21, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 3, new DateTime(2024, 3, 14, 21, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 4, new DateTime(2024, 3, 14, 21, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 5, new DateTime(2024, 3, 14, 21, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "movie_start", "theater_room_id" },
                values: new object[] { new DateTime(2024, 3, 14, 22, 0, 0, 0, DateTimeKind.Utc), 1 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 7, new DateTime(2024, 3, 14, 22, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 8, new DateTime(2024, 3, 14, 22, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 9, new DateTime(2024, 3, 14, 22, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 10, new DateTime(2024, 3, 14, 22, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 31,
                column: "movie_start",
                value: new DateTime(2024, 3, 15, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 32,
                column: "movie_start",
                value: new DateTime(2024, 3, 15, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 33,
                column: "movie_start",
                value: new DateTime(2024, 3, 15, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "movie_id", "movie_start" },
                values: new object[] { 4, new DateTime(2024, 3, 15, 20, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "movie_id", "movie_start" },
                values: new object[] { 5, new DateTime(2024, 3, 15, 20, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 6, new DateTime(2024, 3, 15, 21, 0, 0, 0, DateTimeKind.Utc), 1 });

            migrationBuilder.InsertData(
                table: "screenings",
                columns: new[] { "id", "movie_id", "movie_start", "theater_room_id" },
                values: new object[,]
                {
                    { 37, 7, new DateTime(2024, 3, 15, 21, 0, 0, 0, DateTimeKind.Utc), 2 },
                    { 38, 8, new DateTime(2024, 3, 15, 21, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 39, 9, new DateTime(2024, 3, 15, 21, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 40, 10, new DateTime(2024, 3, 15, 21, 0, 0, 0, DateTimeKind.Utc), 5 },
                    { 41, 1, new DateTime(2024, 3, 15, 22, 0, 0, 0, DateTimeKind.Utc), 1 },
                    { 42, 2, new DateTime(2024, 3, 15, 22, 0, 0, 0, DateTimeKind.Utc), 2 },
                    { 43, 3, new DateTime(2024, 3, 15, 22, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 44, 4, new DateTime(2024, 3, 15, 22, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 45, 5, new DateTime(2024, 3, 15, 22, 0, 0, 0, DateTimeKind.Utc), 5 },
                    { 46, 6, new DateTime(2024, 3, 16, 21, 0, 0, 0, DateTimeKind.Utc), 1 },
                    { 47, 7, new DateTime(2024, 3, 16, 21, 0, 0, 0, DateTimeKind.Utc), 2 },
                    { 48, 8, new DateTime(2024, 3, 16, 21, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 49, 9, new DateTime(2024, 3, 16, 21, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 50, 10, new DateTime(2024, 3, 16, 21, 0, 0, 0, DateTimeKind.Utc), 5 },
                    { 51, 1, new DateTime(2024, 3, 16, 22, 0, 0, 0, DateTimeKind.Utc), 1 },
                    { 52, 2, new DateTime(2024, 3, 16, 22, 0, 0, 0, DateTimeKind.Utc), 2 },
                    { 53, 3, new DateTime(2024, 3, 16, 22, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 54, 4, new DateTime(2024, 3, 16, 22, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 55, 5, new DateTime(2024, 3, 16, 22, 0, 0, 0, DateTimeKind.Utc), 5 },
                    { 56, 6, new DateTime(2024, 3, 17, 20, 0, 0, 0, DateTimeKind.Utc), 1 },
                    { 57, 7, new DateTime(2024, 3, 17, 20, 0, 0, 0, DateTimeKind.Utc), 2 },
                    { 58, 8, new DateTime(2024, 3, 17, 20, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 59, 9, new DateTime(2024, 3, 17, 20, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 60, 10, new DateTime(2024, 3, 17, 20, 0, 0, 0, DateTimeKind.Utc), 5 },
                    { 61, 1, new DateTime(2024, 3, 17, 21, 0, 0, 0, DateTimeKind.Utc), 1 },
                    { 62, 2, new DateTime(2024, 3, 17, 21, 0, 0, 0, DateTimeKind.Utc), 2 },
                    { 63, 3, new DateTime(2024, 3, 17, 21, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 64, 4, new DateTime(2024, 3, 17, 21, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 65, 5, new DateTime(2024, 3, 17, 21, 0, 0, 0, DateTimeKind.Utc), 5 },
                    { 66, 6, new DateTime(2024, 3, 17, 22, 0, 0, 0, DateTimeKind.Utc), 1 },
                    { 67, 7, new DateTime(2024, 3, 17, 22, 0, 0, 0, DateTimeKind.Utc), 2 },
                    { 68, 8, new DateTime(2024, 3, 17, 22, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 69, 9, new DateTime(2024, 3, 17, 22, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 70, 10, new DateTime(2024, 3, 17, 22, 0, 0, 0, DateTimeKind.Utc), 5 },
                    { 71, 1, new DateTime(2024, 3, 18, 20, 0, 0, 0, DateTimeKind.Utc), 1 },
                    { 72, 2, new DateTime(2024, 3, 18, 20, 0, 0, 0, DateTimeKind.Utc), 2 },
                    { 73, 3, new DateTime(2024, 3, 18, 20, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 74, 4, new DateTime(2024, 3, 18, 20, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 75, 5, new DateTime(2024, 3, 18, 20, 0, 0, 0, DateTimeKind.Utc), 5 },
                    { 76, 6, new DateTime(2024, 3, 18, 21, 0, 0, 0, DateTimeKind.Utc), 1 },
                    { 77, 7, new DateTime(2024, 3, 18, 21, 0, 0, 0, DateTimeKind.Utc), 2 },
                    { 78, 8, new DateTime(2024, 3, 18, 21, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 79, 9, new DateTime(2024, 3, 18, 21, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 80, 10, new DateTime(2024, 3, 18, 21, 0, 0, 0, DateTimeKind.Utc), 5 },
                    { 81, 1, new DateTime(2024, 3, 18, 22, 0, 0, 0, DateTimeKind.Utc), 1 },
                    { 82, 2, new DateTime(2024, 3, 18, 22, 0, 0, 0, DateTimeKind.Utc), 2 },
                    { 83, 3, new DateTime(2024, 3, 18, 22, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 84, 4, new DateTime(2024, 3, 18, 22, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 85, 5, new DateTime(2024, 3, 18, 22, 0, 0, 0, DateTimeKind.Utc), 5 },
                    { 86, 6, new DateTime(2024, 3, 19, 20, 0, 0, 0, DateTimeKind.Utc), 1 },
                    { 87, 7, new DateTime(2024, 3, 19, 20, 0, 0, 0, DateTimeKind.Utc), 2 },
                    { 88, 8, new DateTime(2024, 3, 19, 20, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 89, 9, new DateTime(2024, 3, 19, 20, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 90, 10, new DateTime(2024, 3, 19, 20, 0, 0, 0, DateTimeKind.Utc), 5 },
                    { 91, 1, new DateTime(2024, 3, 19, 21, 0, 0, 0, DateTimeKind.Utc), 1 },
                    { 92, 2, new DateTime(2024, 3, 19, 21, 0, 0, 0, DateTimeKind.Utc), 2 },
                    { 93, 3, new DateTime(2024, 3, 19, 21, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 94, 4, new DateTime(2024, 3, 19, 21, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 95, 5, new DateTime(2024, 3, 19, 21, 0, 0, 0, DateTimeKind.Utc), 5 },
                    { 96, 6, new DateTime(2024, 3, 19, 22, 0, 0, 0, DateTimeKind.Utc), 1 },
                    { 97, 7, new DateTime(2024, 3, 19, 22, 0, 0, 0, DateTimeKind.Utc), 2 },
                    { 98, 8, new DateTime(2024, 3, 19, 22, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 99, 9, new DateTime(2024, 3, 19, 22, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 100, 10, new DateTime(2024, 3, 19, 22, 0, 0, 0, DateTimeKind.Utc), 5 },
                    { 101, 1, new DateTime(2024, 3, 16, 20, 0, 0, 0, DateTimeKind.Utc), 1 },
                    { 102, 2, new DateTime(2024, 3, 16, 20, 0, 0, 0, DateTimeKind.Utc), 2 },
                    { 103, 3, new DateTime(2024, 3, 16, 20, 0, 0, 0, DateTimeKind.Utc), 3 },
                    { 104, 4, new DateTime(2024, 3, 16, 20, 0, 0, 0, DateTimeKind.Utc), 4 },
                    { 105, 5, new DateTime(2024, 3, 16, 20, 0, 0, 0, DateTimeKind.Utc), 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 105);

            migrationBuilder.AlterColumn<string>(
                name: "release_country",
                table: "movies",
                type: "character varying(2)",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                column: "kijkwijzers",
                value: "6, Grof taalgebruik");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                column: "kijkwijzers",
                value: "12, Geweld, Angst");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                column: "kijkwijzers",
                value: "6, Grof taalgebruik");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                column: "kijkwijzers",
                value: "12, Geweld, Angst");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                column: "kijkwijzers",
                value: "6, Grof taalgebruik");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 7,
                column: "kijkwijzers",
                value: "12, Geweld");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 8,
                column: "kijkwijzers",
                value: "12, Geweld");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 9,
                column: "kijkwijzers",
                value: "AL");

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 10,
                column: "kijkwijzers",
                value: "12, Geweld");

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { "Cash", 5.9380006666548m, 34, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 4, 90.7498253312522m, 22, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 2, true, 88.1286428903469m, 33, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "paid", "payment_type", "price", "screening_id" },
                values: new object[] { true, "Cash", 85.0322957283092m, 9 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 4, 92.4887343588426m, 3, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 4, true, 59.1967300354066m, 32, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 3, false, 52.6875837774515m, 6, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 3, 73.9423390583867m, 8, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, false, "Credit Card", 32.578604350566m, 14, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, "Cash", 23.7430497718498m, 34, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "paid", "price", "screening_id", "user_id" },
                values: new object[] { true, 89.7151560625229m, 2, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, false, "Cash", 58.8378541380419m, 17, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 5, 42.8584338178402m, 16, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, "Cash", 36.4333954783972m, 23, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 4, false, 39.521536582786m, 21, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, false, "Credit Card", 33.6776334461548m, 19, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, "Credit Card", 86.0246742852636m, 36, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, "Cash", 90.1231769149817m, 35, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, false, "Cash", 86.6832061097488m, 26, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, "Credit Card", 23.1212781212876m, 5, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 4, false, 68.0243148637754m, 36, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 1, true, 18.4555210986851m, 10, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 3, 40.9254032645556m, 12, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, "Cash", 67.1937553733196m, 3, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 4, true, 17.4476860480077m, 13, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, "Credit Card", 43.1766305520564m, 26, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, true, "Credit Card", 5.27673059092286m, 25, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 3, 56.3072102718671m, 11, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, "Cash", 1.07008439642233m, 11, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, true, "Credit Card", 50.5300502074627m, 13, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "employee_id", "price", "screening_id" },
                values: new object[] { 4, 82.2718842860009m, 12 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { "Cash", 6.15896938014369m, 9, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, "Cash", 22.4355276266808m, 31, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { "Cash", 9.1183922940798m, 8, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, "Cash", 45.0075165071007m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 4, false, 5.45823295080621m, 13, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 3, false, 18.9982876527708m, 31, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, "Cash", 21.3524266392516m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, true, "Cash", 33.3275098272777m, 4, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "employee_id", "price", "user_id" },
                values: new object[] { 1, 31.6094017353738m, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "employee_id", "paid", "price", "screening_id" },
                values: new object[] { 1, false, 4.98573696151208m, 36 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 5, 46.4180433516493m, 10, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 2, 54.8779097853685m, 22, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id" },
                values: new object[] { 4, "Credit Card", 35.2821961089184m, 19 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "employee_id", "paid", "price", "screening_id" },
                values: new object[] { 5, true, 43.7843882526845m, 17 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, "Credit Card", 58.7092559485156m, 28, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { "Credit Card", 95.9766135146246m, 12, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id" },
                values: new object[] { 1, true, "Cash", 95.8561626472742m, 27 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "employee_id", "paid", "price", "screening_id" },
                values: new object[] { 1, false, 38.9509114003708m, 26 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                column: "movie_start",
                value: new DateTime(2024, 3, 13, 3, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "movie_id", "movie_start" },
                values: new object[] { 6, new DateTime(2024, 3, 13, 3, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "movie_id", "movie_start" },
                values: new object[] { 2, new DateTime(2024, 3, 13, 3, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                column: "movie_start",
                value: new DateTime(2024, 3, 13, 3, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "movie_id", "movie_start" },
                values: new object[] { 6, new DateTime(2024, 3, 13, 3, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 5, new DateTime(2024, 3, 13, 3, 0, 0, 0, DateTimeKind.Utc), 6 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 9, new DateTime(2024, 3, 13, 6, 0, 0, 0, DateTimeKind.Utc), 1 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 6, new DateTime(2024, 3, 13, 6, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 8, new DateTime(2024, 3, 13, 6, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 6, new DateTime(2024, 3, 13, 6, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 10, new DateTime(2024, 3, 13, 6, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 3, new DateTime(2024, 3, 13, 6, 0, 0, 0, DateTimeKind.Utc), 6 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 9, new DateTime(2024, 3, 13, 5, 0, 0, 0, DateTimeKind.Utc), 1 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 2, new DateTime(2024, 3, 13, 5, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 3, new DateTime(2024, 3, 13, 5, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 7, new DateTime(2024, 3, 13, 5, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 6, new DateTime(2024, 3, 13, 5, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 4, new DateTime(2024, 3, 13, 3, 0, 0, 0, DateTimeKind.Utc), 6 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "movie_id", "theater_room_id" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "movie_id", "theater_room_id" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 2, new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 4, new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 6, new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 5, new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Utc), 6 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 2, new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Utc), 1 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "movie_start", "theater_room_id" },
                values: new object[] { new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 8, new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 6, new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 10, new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 3, new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Utc), 6 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 31,
                column: "movie_start",
                value: new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 32,
                column: "movie_start",
                value: new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 33,
                column: "movie_start",
                value: new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Utc));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "movie_id", "movie_start" },
                values: new object[] { 7, new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "movie_id", "movie_start" },
                values: new object[] { 6, new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Utc) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "movie_id", "movie_start", "theater_room_id" },
                values: new object[] { 4, new DateTime(2024, 3, 14, 20, 0, 0, 0, DateTimeKind.Utc), 6 });
        }
    }
}
