using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinemate.API.Migrations
{
    /// <inheritdoc />
    public partial class ChangedUserEmail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_users_email",
                table: "users");

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 2, false, 37.3208443027443m, 22, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, "Credit Card", 27.2303914793388m, 33, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 3, false, 13.6183159567469m, 4, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 1, false, 14.703692512883m, 28, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, false, "Credit Card", 48.0362041870534m, 7, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 1, true, 54.1497331624659m, 9, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "price", "screening_id", "user_id" },
                values: new object[] { 68.2834469042257m, 23, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "employee_id", "price", "screening_id" },
                values: new object[] { 5, 33.1470745687479m, 35 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, "Credit Card", 43.7444792161118m, 11, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, "Cash", 74.5794194802361m, 16, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id" },
                values: new object[] { 1, false, "Credit Card", 70.7007924725264m, 30 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "price", "screening_id", "user_id" },
                values: new object[] { 91.8930343116061m, 9, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, "Credit Card", 54.0931474688518m, 6, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 4, true, 36.7736442982896m, 14, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "price", "screening_id", "user_id" },
                values: new object[] { 26.0875349496048m, 10, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "employee_id", "paid", "price", "screening_id" },
                values: new object[] { 4, false, 40.9616517121941m, 13 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, "Credit Card", 92.2984825342439m, 19, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, true, "Credit Card", 50.011978251562m, 19, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "employee_id", "price", "screening_id" },
                values: new object[] { 4, 50.329831440759m, 33 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "employee_id", "price", "screening_id" },
                values: new object[] { 3, 99.024478561282m, 16 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "paid", "price", "screening_id", "user_id" },
                values: new object[] { true, 95.4941981511658m, 4, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "paid", "price", "screening_id", "user_id" },
                values: new object[] { false, 93.9463056717002m, 25, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, "Credit Card", 26.1455439505465m, 7, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, true, "Credit Card", 49.8420148857995m, 17, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 2, false, 81.9613159595156m, 9, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 4, true, 1.39963232891226m, 16, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 3, true, 21.9203160235377m, 24, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "employee_id", "paid", "price", "screening_id" },
                values: new object[] { 2, true, 36.1577141844535m, 14 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, true, "Credit Card", 24.7838928703387m, 14, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 5, 75.0605105306914m, 25, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "price", "screening_id", "user_id" },
                values: new object[] { 69.3737099971612m, 31, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { true, "Credit Card", 90.9161561484766m, 30, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 1, false, 85.7253387659354m, 26, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "paid", "price", "screening_id", "user_id" },
                values: new object[] { true, 60.2089196870414m, 18, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "paid", "price", "screening_id" },
                values: new object[] { false, 2.42824937876031m, 17 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, "Cash", 38.6801414035356m, 5, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, true, "Cash", 51.8093822487589m, 34, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, 46.9758672791597m, 14, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, "Cash", 47.4001382519906m, 19, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, true, "Credit Card", 47.7062877784089m, 35, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 3, false, 70.7420617449086m, 21, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, true, "Credit Card", 78.6597150416554m, 29, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 4, 74.0608227759297m, 13, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 3, true, 3.39469168081861m, 7, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 4, 14.4442602775721m, 7, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, "Credit Card", 31.6634649313579m, 23, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 2, false, 84.4900298737511m, 2, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, false, "Credit Card", 59.8956862839992m, 19, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id" },
                values: new object[] { 4, false, "Cash", 79.4323141310952m, 8 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 6,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 7,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 4, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 8,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 4, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 9,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 4, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 10,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 4, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 11,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 4, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 12,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 4, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 13,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 3, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 14,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 3, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 15,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 3, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 16,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 3, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 17,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 3, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 18,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 19,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 22, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 20,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 22, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 21,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 22, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 22,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 22, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 23,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 22, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 24,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 22, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 25,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 22, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 26,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 22, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 27,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 22, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 28,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 22, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 29,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 22, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 30,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 22, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 31,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 22, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 32,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 22, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 33,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 22, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 34,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 22, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 35,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 22, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 36,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 22, 19, 26, 870, DateTimeKind.Utc).AddTicks(3931));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, 31.2538953059988m, 19, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, "Cash", 46.7347853912649m, 8, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 4, true, 62.2114479398866m, 7, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, 53.1469002870991m, 11, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, true, "Cash", 35.3259656228274m, 8, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 2, false, 1.85064564561243m, 6, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "price", "screening_id", "user_id" },
                values: new object[] { 94.9910857912389m, 17, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "employee_id", "price", "screening_id" },
                values: new object[] { 4, 15.7564820876196m, 13 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, "Cash", 64.6362032544697m, 28, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, false, "Credit Card", 36.7170497761898m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id" },
                values: new object[] { 2, true, "Cash", 73.5525437565182m, 36 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "price", "screening_id", "user_id" },
                values: new object[] { 86.3201152447446m, 28, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, false, "Cash", 60.2602895632358m, 36, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 2, false, 59.1374311848659m, 36, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "price", "screening_id", "user_id" },
                values: new object[] { 21.478302998226m, 19, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "employee_id", "paid", "price", "screening_id" },
                values: new object[] { 5, true, 22.1725975654173m, 6 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, "Cash", 59.4867864291134m, 2, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, false, "Cash", 43.4580064524465m, 9, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "employee_id", "price", "screening_id" },
                values: new object[] { 3, 44.237418305693m, 18 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "employee_id", "price", "screening_id" },
                values: new object[] { 1, 19.740681259251m, 25 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "paid", "price", "screening_id", "user_id" },
                values: new object[] { false, 78.683042689697m, 36, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "paid", "price", "screening_id", "user_id" },
                values: new object[] { true, 34.2313565053678m, 20, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, "Cash", 73.7993524764651m, 23, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, false, "Cash", 35.0504354807629m, 13, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, 90.7690106589723m, 33, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 3, false, 25.9608754361817m, 11, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 2, false, 61.3353538737857m, 26, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "employee_id", "paid", "price", "screening_id" },
                values: new object[] { 3, false, 77.5170616306265m, 10 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, false, "Cash", 34.4634596841071m, 30, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 3, 87.4847651528654m, 8, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "price", "screening_id", "user_id" },
                values: new object[] { 88.8585957401907m, 20, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { false, "Cash", 73.7897770410991m, 21, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, 56.8489018594352m, 4, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "paid", "price", "screening_id", "user_id" },
                values: new object[] { false, 70.5248715764648m, 3, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "paid", "price", "screening_id" },
                values: new object[] { true, 52.4594895933327m, 16 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, "Credit Card", 97.3078971196514m, 16, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, false, "Credit Card", 60.7684211176444m, 33, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 3, false, 35.3352498610388m, 10, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, "Credit Card", 26.9034919766357m, 18, 1 });

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
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, 16.1512580941397m, 1, 2 });

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
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 5, 84.9222818876245m, 15, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 4, false, 50.3278664599355m, 18, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 2, 80.7564052554282m, 12, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, "Cash", 66.9092184820255m, 20, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 4, true, 88.4812416075839m, 4, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, true, "Cash", 57.3325200024301m, 12, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id" },
                values: new object[] { 1, true, "Credit Card", 77.7181368904405m, 10 });

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

            migrationBuilder.CreateIndex(
                name: "IX_users_email",
                table: "users",
                column: "email",
                unique: true);
        }
    }
}
