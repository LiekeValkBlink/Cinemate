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
            migrationBuilder.InsertData(
                table: "reservations",
                columns: new[] { "id", "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[,]
                {
                    { 1, 1, true, "iDeal", 10m, 1, 1 },
                    { 2, 2, true, "Cash", 92.9243956915036m, 14, 4 },
                    { 3, 2, true, "Credit Card", 22.209742458647m, 11, 3 },
                    { 4, 1, true, "Cash", 56.9033506249601m, 8, 3 },
                    { 5, 5, false, "Credit Card", 28.7153090834645m, 24, 2 },
                    { 6, 4, false, "Cash", 3.47234855002593m, 21, 5 },
                    { 7, 5, true, "Cash", 94.8617228976941m, 4, 2 },
                    { 8, 2, false, "Credit Card", 29.019939757489m, 32, 3 },
                    { 9, 4, true, "Credit Card", 94.3665308953352m, 2, 2 },
                    { 10, 4, false, "Cash", 76.0759210872872m, 27, 5 },
                    { 11, 5, false, "Credit Card", 73.4184052870058m, 30, 2 },
                    { 12, 2, false, "Cash", 70.8660115270676m, 14, 4 },
                    { 13, 3, false, "Credit Card", 50.8220198156757m, 9, 5 },
                    { 14, 1, true, "Cash", 19.1147885555924m, 15, 4 },
                    { 15, 2, true, "Credit Card", 50.7811916151662m, 30, 5 },
                    { 16, 3, false, "Credit Card", 21.4750910960714m, 32, 4 },
                    { 17, 5, true, "Cash", 91.5237688405036m, 9, 3 },
                    { 18, 3, false, "Cash", 44.1146422844412m, 34, 1 },
                    { 19, 1, true, "Cash", 89.526613178119m, 11, 2 },
                    { 20, 5, false, "Cash", 83.2940852772819m, 30, 3 },
                    { 21, 4, false, "Credit Card", 59.109770189334m, 33, 3 },
                    { 22, 1, false, "Cash", 78.0850378029457m, 19, 1 },
                    { 23, 5, false, "Cash", 95.1734600009426m, 18, 4 },
                    { 24, 2, false, "Credit Card", 57.8759516612839m, 21, 3 },
                    { 25, 1, true, "Cash", 92.1115705693316m, 27, 2 },
                    { 26, 1, true, "Credit Card", 59.140718249231m, 6, 4 },
                    { 27, 5, false, "Cash", 11.3973274095828m, 27, 3 },
                    { 28, 2, true, "Credit Card", 21.1572047834238m, 29, 3 },
                    { 29, 1, false, "Credit Card", 71.9344254514301m, 24, 1 },
                    { 30, 3, false, "Credit Card", 77.7306028614711m, 27, 4 },
                    { 31, 3, false, "Cash", 19.3316250696493m, 32, 4 },
                    { 32, 2, false, "Credit Card", 10.2094038690101m, 19, 2 },
                    { 33, 1, false, "Cash", 50.6355129903814m, 4, 3 },
                    { 34, 2, false, "Cash", 17.5811038939904m, 6, 3 },
                    { 35, 2, true, "Cash", 67.4165865608978m, 1, 5 },
                    { 36, 4, true, "Cash", 41.0968204302832m, 15, 1 },
                    { 37, 3, true, "Credit Card", 14.2072746537204m, 14, 1 },
                    { 38, 3, true, "Cash", 50.7952556583658m, 17, 4 },
                    { 39, 1, false, "Cash", 64.4184680105356m, 25, 1 },
                    { 40, 1, true, "Cash", 50.3698142445315m, 18, 4 },
                    { 41, 5, false, "Cash", 47.0258170489112m, 5, 5 },
                    { 42, 2, true, "Credit Card", 11.6913222353613m, 3, 2 },
                    { 43, 2, true, "Cash", 11.7351602413209m, 8, 5 },
                    { 44, 5, false, "Credit Card", 85.4186276217238m, 9, 3 },
                    { 45, 1, true, "Credit Card", 66.1939340938219m, 1, 5 },
                    { 46, 2, false, "Cash", 49.3111458510439m, 22, 2 },
                    { 47, 5, true, "Cash", 84.8819625496889m, 27, 4 },
                    { 48, 4, true, "Cash", 46.6502849993777m, 36, 5 },
                    { 49, 4, true, "Credit Card", 62.8070302128393m, 19, 1 },
                    { 50, 1, false, "Cash", 45.9464799233236m, 17, 4 }
                });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 2, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 2, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 2, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 2, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 2, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 6,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 2, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 7,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 5, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 8,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 5, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 9,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 5, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 10,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 5, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 11,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 5, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 12,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 5, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 13,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 4, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 14,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 4, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 15,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 4, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 16,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 4, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 17,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 4, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 18,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 2, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 19,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 20,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 21,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 22,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 23,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 24,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 25,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 26,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 27,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 28,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 29,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 30,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 31,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 32,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 33,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 34,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 35,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 36,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 36, 52, 703, DateTimeKind.Utc).AddTicks(8975));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "reservation_promo_codes",
                keyColumns: new[] { "PromoCodeId", "ReservationId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "seats_reserved",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "seats_reserved",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "seats_reserved",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 2, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 2, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 2, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 2, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 2, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 6,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 2, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 7,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 5, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 8,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 5, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 9,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 5, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 10,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 5, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 11,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 5, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 12,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 5, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 13,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 4, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 14,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 4, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 15,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 4, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 16,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 4, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 17,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 4, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 18,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 2, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 19,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 20,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 21,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 22,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 23,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 24,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 25,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 26,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 27,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 28,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 29,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 30,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 31,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 32,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 33,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 34,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 35,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 36,
                column: "movie_start",
                value: new DateTime(2024, 3, 7, 23, 18, 50, 440, DateTimeKind.Utc).AddTicks(4031));
        }
    }
}
