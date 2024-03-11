using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinemate.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "actor_cast", "description", "director", "duration", "kijkwijzers", "movie_category_id", "review", "title" },
                values: new object[] { "Margot Robbie", "Barbie and Ken are having the time of their lives in the colorful and seemingly perfect world of Barbie Land. However, when they get a chance to go to the real world, they soon discover the joys and perils of living among humans.", "Greta Gerwig", 116, "AL", 2, 7.5m, "Barbie" });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, "Cash", 31.2538953059988m, 19, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 3, false, 46.7347853912649m, 8, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "paid", "price", "screening_id", "user_id" },
                values: new object[] { true, 62.2114479398866m, 7, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 5, 53.1469002870991m, 11, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, "Cash", 35.3259656228274m, 8, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "paid", "price", "screening_id", "user_id" },
                values: new object[] { false, 1.85064564561243m, 6, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "employee_id", "price", "screening_id" },
                values: new object[] { 5, 94.9910857912389m, 17 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id" },
                values: new object[] { 4, "Cash", 15.7564820876196m, 13 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 2, 64.6362032544697m, 28, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "price", "screening_id", "user_id" },
                values: new object[] { 36.7170497761898m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "price", "screening_id" },
                values: new object[] { 73.5525437565182m, 36 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 1, 86.3201152447446m, 28, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 4, false, 60.2602895632358m, 36, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "payment_type", "price", "screening_id" },
                values: new object[] { "Credit Card", 59.1374311848659m, 36 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 4, 21.478302998226m, 19, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 5, 22.1725975654173m, 6, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 4, false, 59.4867864291134m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id" },
                values: new object[] { 4, false, "Cash", 43.4580064524465m, 9 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, true, "Credit Card", 44.237418305693m, 18, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { false, "Cash", 19.740681259251m, 25, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, false, "Credit Card", 78.683042689697m, 36, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "employee_id", "price", "screening_id" },
                values: new object[] { 2, 34.2313565053678m, 20 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "paid", "payment_type", "price", "screening_id" },
                values: new object[] { true, "Cash", 73.7993524764651m, 23 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "price", "screening_id", "user_id" },
                values: new object[] { 35.0504354807629m, 13, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, "Credit Card", 90.7690106589723m, 33, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 3, 25.9608754361817m, 11, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, "Cash", 61.3353538737857m, 26, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, "Credit Card", 77.5170616306265m, 10, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, "Cash", 34.4634596841071m, 30, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 3, true, 87.4847651528654m, 8, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, true, "Cash", 88.8585957401907m, 20, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 2, 73.7897770410991m, 21, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { true, "Credit Card", 56.8489018594352m, 4, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id" },
                values: new object[] { 2, false, "Cash", 70.5248715764648m, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { "Credit Card", 52.4594895933327m, 16, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 3, true, 97.3078971196514m, 16, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 5, false, 60.7684211176444m, 33, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, false, "Credit Card", 35.3352498610388m, 10, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "employee_id", "price", "screening_id" },
                values: new object[] { 3, 26.9034919766357m, 18 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, false, "Cash", 20.1897472482649m, 32, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, "Credit Card", 16.1512580941397m, 1, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, false, "Cash", 51.9548798404221m, 27, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, "Credit Card", 84.9222818876245m, 15, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, "Cash", 50.3278664599355m, 18, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "employee_id", "payment_type", "price", "user_id" },
                values: new object[] { 2, "Cash", 80.7564052554282m, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 3, 66.9092184820255m, 20, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id" },
                values: new object[] { 4, true, "Credit Card", 88.4812416075839m, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 4, true, 57.3325200024301m, 12, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 1, 77.7181368904405m, 10, 1 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                column: "movie_start",
                value: new DateTime(2024, 3, 11, 23, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                column: "movie_start",
                value: new DateTime(2024, 3, 11, 23, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                column: "movie_start",
                value: new DateTime(2024, 3, 11, 23, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                column: "movie_start",
                value: new DateTime(2024, 3, 11, 23, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                column: "movie_start",
                value: new DateTime(2024, 3, 11, 23, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 6,
                column: "movie_start",
                value: new DateTime(2024, 3, 11, 23, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 7,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 2, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 8,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 2, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 9,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 2, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 10,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 2, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 11,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 2, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 12,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 2, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 13,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 14,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 15,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 16,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 17,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 18,
                column: "movie_start",
                value: new DateTime(2024, 3, 11, 23, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 19,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 20,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 21,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 22,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 23,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 24,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 25,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 26,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 27,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 28,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 29,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 30,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 31,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 32,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 33,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 34,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 35,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 36,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 50, 53, 764, DateTimeKind.Utc).AddTicks(4621));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "actor_cast", "description", "director", "duration", "kijkwijzers", "movie_category_id", "review", "title" },
                values: new object[] { "Ryan Reynolds, Jason Segel, Mark Ruffalo", "A passenger on a flight sees a woman take her child away, but no one on the plane believes him.", "John Watts", 105, "6, Grof taalgebruik", 1, 7.3m, "Plane" });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, false, "Credit Card", 87.7736136779318m, 1, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 1, true, 19.3477773977806m, 3, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "paid", "price", "screening_id", "user_id" },
                values: new object[] { false, 63.4900329996451m, 11, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 2, 10.577805438222m, 5, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, "Credit Card", 98.3304043613549m, 14, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "paid", "price", "screening_id", "user_id" },
                values: new object[] { true, 72.3491345136892m, 10, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "employee_id", "price", "screening_id" },
                values: new object[] { 2, 3.21970270952988m, 10 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id" },
                values: new object[] { 1, "Credit Card", 3.67289336795402m, 15 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 4, 23.1422492945968m, 12, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "price", "screening_id", "user_id" },
                values: new object[] { 31.0732512286312m, 28, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "price", "screening_id" },
                values: new object[] { 62.7833447981603m, 14 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 5, 5.23700612900142m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 2, true, 17.369373193714m, 29, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "payment_type", "price", "screening_id" },
                values: new object[] { "Cash", 89.184370503613m, 6 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 5, 79.9107667082424m, 33, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 1, 69.401020316435m, 31, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, 68.75162824986m, 35, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id" },
                values: new object[] { 5, true, "Credit Card", 42.1761017167798m, 24 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, false, "Cash", 50.0155895590767m, 3, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { true, "Credit Card", 88.7398627487026m, 36, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, "Cash", 76.5833529817449m, 24, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "employee_id", "price", "screening_id" },
                values: new object[] { 1, 93.421033671173m, 25 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "paid", "payment_type", "price", "screening_id" },
                values: new object[] { false, "Credit Card", 98.7224958730008m, 29 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "price", "screening_id", "user_id" },
                values: new object[] { 57.2879742367233m, 18, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, false, "Cash", 3.86138147866811m, 27, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 2, 93.4974952845477m, 32, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, "Credit Card", 81.1703022397649m, 21, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, "Cash", 33.153847385346m, 23, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, "Credit Card", 47.0649425269832m, 26, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 4, false, 50.1581808628421m, 18, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, false, "Credit Card", 39.2491603565366m, 23, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 4, 20.0620074272049m, 17, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { false, "Cash", 30.3459246249324m, 18, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id" },
                values: new object[] { 4, true, "Credit Card", 30.117350437253m, 26 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { "Cash", 34.4727302934563m, 35, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 1, false, 31.4947215154766m, 8, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 4, true, 75.5025263283993m, 5, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, true, "Cash", 64.2324432636957m, 32, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "employee_id", "price", "screening_id" },
                values: new object[] { 5, 96.0491561890862m, 15 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, true, "Credit Card", 84.6238557770185m, 9, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, "Cash", 13.7527355153376m, 14, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, true, "Credit Card", 64.6655061123101m, 14, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, "Cash", 72.7412530878106m, 9, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, "Credit Card", 46.5759229723114m, 16, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "employee_id", "payment_type", "price", "user_id" },
                values: new object[] { 5, "Credit Card", 15.9177944254803m, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 1, 53.3424709384416m, 8, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id" },
                values: new object[] { 3, false, "Cash", 96.1868155255784m, 18 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 1, false, 42.8934680622642m, 13, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 4, 33.3581622733226m, 11, 3 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                column: "movie_start",
                value: new DateTime(2024, 3, 11, 23, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                column: "movie_start",
                value: new DateTime(2024, 3, 11, 23, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                column: "movie_start",
                value: new DateTime(2024, 3, 11, 23, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                column: "movie_start",
                value: new DateTime(2024, 3, 11, 23, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                column: "movie_start",
                value: new DateTime(2024, 3, 11, 23, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 6,
                column: "movie_start",
                value: new DateTime(2024, 3, 11, 23, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 7,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 2, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 8,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 2, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 9,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 2, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 10,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 2, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 11,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 2, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 12,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 2, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 13,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 14,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 15,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 16,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 17,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 18,
                column: "movie_start",
                value: new DateTime(2024, 3, 11, 23, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 19,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 20,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 21,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 22,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 23,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 24,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 25,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 26,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 27,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 28,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 29,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 30,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 31,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 32,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 33,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 34,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 35,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 36,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 20, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455));
        }
    }
}
