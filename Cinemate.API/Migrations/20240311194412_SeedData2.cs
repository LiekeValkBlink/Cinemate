using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinemate.API.Migrations
{
    /// <inheritdoc />
    public partial class SeedData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "movies",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "actor_cast", "description", "director", "duration", "kijkwijzers", "release_year", "review", "title" },
                values: new object[] { "Timothée Chalamet, Keegan-Michael Key, Michael B. Jordan", "The story of how a young Willy Wonka meets his legendary Oompa-Loompa associates for the first time, how he came to own the world's most famous chocolate factory, and how Oompa-Loompas saved him from starvation.", "Paul King", 115, "6, Grof taalgebruik", 2023, 7.1m, "Wonka" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "actor_cast", "description", "director", "duration", "kijkwijzers", "release_year", "review", "title" },
                values: new object[] { "Sam Worthington, Zoe Saldana, Sigourney Weaver", "A sequel to Avatar (2009).", "James Cameron", 160, "12, Geweld, Angst", 2022, 7.8m, "Avatar: The Way of Water" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "actor_cast", "description", "director", "duration", "kijkwijzers", "release_year", "review", "title" },
                values: new object[] { "Kristen Bell, Idina Menzel, Josh Gad", "Anna, Elsa, Kristoff, Olaf and Sven leave Arendelle to travel to an ancient, autumn-bound forest of an enchanted land. They set out to find the origin of Elsa's powers in order to save their kingdom.", "Chris Buck, Jennifer Lee", 103, "6, Grof taalgebruik", 2019, 7m, "Frozen II" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "actor_cast", "description", "director", "kijkwijzers", "movie_category_id", "release_year", "review", "title" },
                values: new object[] { "Jennifer Lawrence, Josh Hutcherson, Liam Hemsworth", "Katniss Everdeen voluntarily takes her younger sister's place in the Hunger Games: a televised competition in which two teenagers from each of the twelve Districts of Panem are chosen at random to fight to the death.", "Gary Ross", "12, Geweld, Angst", 1, 2012, 7.2m, "The Hunger Games" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "actor_cast", "description", "director", "duration", "kijkwijzers", "movie_category_id", "release_year", "review", "title" },
                values: new object[] { "Daniel Radcliffe, Jodie Foster, Chiwetel Ejiofor", "A boy sets out on a quest to save his ill mother by searching for a mythic figure said to have magical healing powers.", "Dexter Fletcher", 110, "6, Grof taalgebruik", 1, 2020, 6.8m, "Wish" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "actor_cast", "description", "director", "duration", "kijkwijzers", "movie_category_id", "release_year", "review", "title" },
                values: new object[] { "Brittany Bristow, Jordan Dean, Taveeta Szymanowicz", "Two rival musicians, Lindsay and Wes, accidentally end up in the same town. The main problem is that Lindsay's band has broken up and Wes has become a millionaire, which makes them partners and gives them the right to interfere in each other's lives.", "Josie Day", 96, "Alle leeftijden", 1, 2022, 6.5m, "Anyone But You" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "actor_cast", "description", "director", "duration", "kijkwijzers", "movie_category_id", "release_year", "review", "title" },
                values: new object[] { "Shameik Moore, Hailee Steinfeld, Jake Johnson", "A continuation of Spider-Man: Into the Spider-Verse (2018).", "Joaquim Dos Santos, Kemp Powers", 90, "12, Geweld", 1, 2022, 8m, "Spider-Man: Across the Spider-Verse" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "actor_cast", "description", "duration", "kijkwijzers", "movie_category_id", "release_year", "review", "title" },
                values: new object[] { "Cillian Murphy, Robert Downey Jr., Emily Blunt", "The story of the development of the atomic bomb by the Manhattan Project during World War II, and the complex interpersonal relationships of the brilliant but flawed men who developed it.", 120, "12, Geweld", 1, 2023, 8.5m, "Oppenheimer" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "actor_cast", "description", "director", "duration", "kijkwijzers", "movie_category_id", "release_year", "review", "title" },
                values: new object[] { "Ryan Reynolds, Jason Segel, Mark Ruffalo", "A passenger on a flight sees a woman take her child away, but no one on the plane believes him.", "John Watts", 105, "6, Grof taalgebruik", 1, 2023, 7.3m, "Plane" });

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
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id" },
                values: new object[] { 1, true, "Cash", 19.3477773977806m, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, "Credit Card", 63.4900329996451m, 11, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 2, true, 10.577805438222m, 5, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id" },
                values: new object[] { 3, true, "Credit Card", 98.3304043613549m, 14 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 2, true, 72.3491345136892m, 10, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { "Credit Card", 3.21970270952988m, 10, 5 });

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
                columns: new[] { "employee_id", "payment_type", "price", "screening_id" },
                values: new object[] { 4, "Cash", 23.1422492945968m, 12 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "paid", "price", "screening_id", "user_id" },
                values: new object[] { false, 31.0732512286312m, 28, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 2, true, 62.7833447981603m, 14, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, "Cash", 5.23700612900142m, 1, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { "Cash", 17.369373193714m, 29, 2 });

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
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, "Cash", 69.401020316435m, 31, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "payment_type", "price", "screening_id" },
                values: new object[] { "Cash", 68.75162824986m, 35 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { true, "Credit Card", 42.1761017167798m, 24, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id" },
                values: new object[] { 2, false, "Cash", 50.0155895590767m, 3 });

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
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 1, 93.421033671173m, 25, 4 });

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
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, false, "Cash", 57.2879742367233m, 18, 2 });

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
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 2, false, 93.4974952845477m, 32, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "price", "screening_id" },
                values: new object[] { 81.1703022397649m, 21 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "price", "screening_id", "user_id" },
                values: new object[] { 33.153847385346m, 23, 5 });

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
                columns: new[] { "employee_id", "payment_type", "price", "screening_id" },
                values: new object[] { 4, "Credit Card", 50.1581808628421m, 18 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, "Credit Card", 39.2491603565366m, 23, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 4, false, 20.0620074272049m, 17, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id" },
                values: new object[] { 5, "Cash", 30.3459246249324m, 18 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 4, 30.117350437253m, 26, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 1, true, 34.4727302934563m, 35, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "price", "screening_id", "user_id" },
                values: new object[] { 31.4947215154766m, 8, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "employee_id", "price", "screening_id" },
                values: new object[] { 4, 75.5025263283993m, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "price", "screening_id", "user_id" },
                values: new object[] { 64.2324432636957m, 32, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 5, 96.0491561890862m, 15, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { "Credit Card", 84.6238557770185m, 9, 5 });

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
                columns: new[] { "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { true, "Credit Card", 64.6655061123101m, 14, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 2, false, 72.7412530878106m, 9, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, false, "Credit Card", 46.5759229723114m, 16, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, false, "Credit Card", 15.9177944254803m, 12, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 1, false, 53.3424709384416m, 8, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 3, false, 96.1868155255784m, 18, 1 });

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
                columns: new[] { "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { true, "Credit Card", 33.3581622733226m, 11, 3 });

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
                columns: new[] { "movie_id", "movie_start" },
                values: new object[] { 3, new DateTime(2024, 3, 11, 23, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455) });

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
                columns: new[] { "movie_id", "movie_start" },
                values: new object[] { 9, new DateTime(2024, 3, 12, 2, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455) });

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
                columns: new[] { "movie_id", "movie_start" },
                values: new object[] { 9, new DateTime(2024, 3, 12, 1, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455) });

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
                columns: new[] { "movie_id", "movie_start" },
                values: new object[] { 3, new DateTime(2024, 3, 12, 20, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455) });

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
                columns: new[] { "movie_id", "movie_start" },
                values: new object[] { 2, new DateTime(2024, 3, 12, 20, 44, 11, 755, DateTimeKind.Utc).AddTicks(3455) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "actor_cast", "description", "director", "duration", "kijkwijzers", "release_year", "review", "title" },
                values: new object[] { "Liam Neeson, Ewan McGregor, Natalie Portman", "Two Jedi Knights escape a hostile blockade to find allies and come across a young boy who may bring balance to the Force, but the long dormant Sith resurface to claim their original glory.", "George Lucas", 136, "12, Geweld", 1999, 7.4m, "Star Wars: Episode I - The Phantom Menace" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "actor_cast", "description", "director", "duration", "kijkwijzers", "release_year", "review", "title" },
                values: new object[] { "Hayden Christensen, Natalie Portman, Ewan McGregor", "Ten years after initially meeting, Anakin Skywalker shares a forbidden romance with Padmé Amidala, while Obi-Wan Kenobi investigates an assassination attempt on the senator and discovers a secret clone army crafted for the Jedi.", "George Lucas", 142, "12, Geweld", 2002, 6.5m, "Star Wars: Episode II - Attack of the Clones" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "actor_cast", "description", "director", "duration", "kijkwijzers", "release_year", "review", "title" },
                values: new object[] { "Hayden Christensen, Natalie Portman, Ewan McGregor", "Three years into the Clone Wars, the Jedi rescue Palpatine from Count Dooku. As Obi-Wan pursues a new threat, Anakin acts as a double agent between the Jedi Council and Palpatine and is lured into a sinister plan to rule the galaxy.", "George Lucas", 140, "12, Geweld", 2005, 7.5m, "Star Wars: Episode III - Revenge of the Sith" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "actor_cast", "description", "director", "kijkwijzers", "movie_category_id", "release_year", "review", "title" },
                values: new object[] { "Tim Robbins, Morgan Freeman, Bob Gunton", "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.", "Frank Darabont", "Geweld, Discriminatie", 3, 1994, 9.3m, "The Shawshank Redemption" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "actor_cast", "description", "director", "duration", "kijkwijzers", "movie_category_id", "release_year", "review", "title" },
                values: new object[] { "Marlon Brando, Al Pacino, James Caan", "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.", "Francis Ford Coppola", 175, "16, Geweld", 3, 1972, 9.2m, "The Godfather" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "actor_cast", "description", "director", "duration", "kijkwijzers", "movie_category_id", "release_year", "review", "title" },
                values: new object[] { "Christian Bale, Heath Ledger, Aaron Eckhart", "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice.", "Christopher Nolan", 152, "16, Geweld, Angst", 6, 2008, 9m, "The Dark Knight" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "actor_cast", "description", "director", "duration", "kijkwijzers", "movie_category_id", "release_year", "review", "title" },
                values: new object[] { "Elijah Wood, Viggo Mortensen, Ian McKellen", "Gandalf and Aragorn lead the World of Men against Saurons army to draw his gaze from Frodo and Sam as they approach Mount Doom with the One Ring.", "Peter Jackson", 201, "16, Geweld, Angst", 8, 2003, 8.9m, "The Lord of the Rings: The Return of the King" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "actor_cast", "description", "duration", "kijkwijzers", "movie_category_id", "release_year", "review", "title" },
                values: new object[] { "Leonardo DiCaprio, Joseph Gordon-Levitt, Ellen Page", "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O.", 148, "12, Geweld, Angst", 5, 2010, 8.8m, "Inception" });

            migrationBuilder.UpdateData(
                table: "movies",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "actor_cast", "description", "director", "duration", "kijkwijzers", "movie_category_id", "release_year", "review", "title" },
                values: new object[] { "John Travolta, Uma Thurman, Samuel L. Jackson", "The lives of two mob hitmen, a boxer, a gangster and his wife, and a pair of diner bandits intertwine in four tales of violence and redemption.", "Quentin Tarantino", 154, "16, Geweld, Angst", 6, 1994, 8.9m, "Pulp Fiction" });

            migrationBuilder.InsertData(
                table: "movies",
                columns: new[] { "id", "actor_cast", "description", "director", "duration", "kijkwijzers", "movie_category_id", "release_year", "review", "title" },
                values: new object[] { 10, "Tom Hanks, Robin Wright, Gary Sinise", "The presidencies of Kennedy and Johnson, the Vietnam War, the Watergate scandal and other historical events unfold from the perspective of an Alabama man with an IQ of 75, whose only desire is to be reunited with his childhood sweetheart.", "Robert Zemeckis", 142, "12, Geweld, Angst", 7, 1994, 8.8m, "Forrest Gump" });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, true, "Cash", 50.6068146258802m, 12, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id" },
                values: new object[] { 3, false, "Credit Card", 89.996786422641m, 30 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, "Cash", 75.8004477654276m, 6, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 4, false, 48.3813881035186m, 27, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id" },
                values: new object[] { 5, false, "Cash", 43.4495377727123m, 30 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 5, false, 17.0588357211671m, 18, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { "Cash", 78.9450694197138m, 36, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id" },
                values: new object[] { 2, "Cash", 67.1865562488285m, 19 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id" },
                values: new object[] { 3, "Credit Card", 99.4110766555806m, 23 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "paid", "price", "screening_id", "user_id" },
                values: new object[] { true, 61.3767453812471m, 3, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 3, false, 23.4133008007523m, 25, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, false, "Credit Card", 52.5328438496553m, 4, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 14,
                columns: new[] { "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { "Credit Card", 54.9824720573141m, 5, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 15,
                columns: new[] { "payment_type", "price", "screening_id" },
                values: new object[] { "Credit Card", 80.0867547958697m, 7 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 16,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 4, 71.7806577037188m, 18, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 17,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, "Credit Card", 76.6651743389962m, 10, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 18,
                columns: new[] { "payment_type", "price", "screening_id" },
                values: new object[] { "Credit Card", 64.4756000736444m, 24 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { false, "Cash", 64.0543542052562m, 27, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 20,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id" },
                values: new object[] { 4, true, "Credit Card", 8.45680677512696m, 14 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 21,
                columns: new[] { "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { false, "Cash", 38.5918557867133m, 25, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 4, false, "Credit Card", 1.47844900342272m, 34, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 4, 71.8119401755431m, 5, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 24,
                columns: new[] { "paid", "payment_type", "price", "screening_id" },
                values: new object[] { true, "Cash", 46.8105238707945m, 16 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, "Credit Card", 83.6403819926469m, 13, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 26,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 2, true, "Credit Card", 81.7610193351007m, 11, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 27,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, 84.0149623835882m, 15, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 28,
                columns: new[] { "price", "screening_id" },
                values: new object[] { 45.3042629287882m, 14 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 29,
                columns: new[] { "price", "screening_id", "user_id" },
                values: new object[] { 57.8350857533847m, 14, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 30,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, "Cash", 65.2795769264274m, 34, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 31,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id" },
                values: new object[] { 1, "Cash", 32.1684054605938m, 22 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 32,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, "Cash", 60.6166865324371m, 8, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 33,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 1, true, 22.8191005553817m, 22, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 34,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id" },
                values: new object[] { 1, "Credit Card", 44.0973179432771m, 12 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 35,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 3, 77.2801698964272m, 24, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 36,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 4, false, 23.3315426711549m, 13, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 37,
                columns: new[] { "price", "screening_id", "user_id" },
                values: new object[] { 48.9618310781205m, 15, 4 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 38,
                columns: new[] { "employee_id", "price", "screening_id" },
                values: new object[] { 3, 10.3577977261334m, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 39,
                columns: new[] { "price", "screening_id", "user_id" },
                values: new object[] { 62.4471203252445m, 22, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 40,
                columns: new[] { "employee_id", "price", "screening_id", "user_id" },
                values: new object[] { 3, 10.5541311848971m, 26, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 41,
                columns: new[] { "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { "Cash", 32.0523033819232m, 10, 1 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 42,
                columns: new[] { "employee_id", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 1, "Credit Card", 19.1629852958968m, 6, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 43,
                columns: new[] { "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { false, "Cash", 34.6290667295587m, 12, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 44,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, 89.9888679162083m, 6, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 45,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, "Cash", 38.9385411919113m, 22, 5 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 46,
                columns: new[] { "employee_id", "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { 3, true, "Cash", 13.6522826250697m, 2, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 47,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 2, true, 89.4341547944767m, 20, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 48,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 1, true, 36.5977546044117m, 29, 3 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 49,
                columns: new[] { "employee_id", "paid", "price", "screening_id", "user_id" },
                values: new object[] { 5, true, 20.1799939558132m, 10, 2 });

            migrationBuilder.UpdateData(
                table: "reservations",
                keyColumn: "id",
                keyValue: 50,
                columns: new[] { "paid", "payment_type", "price", "screening_id", "user_id" },
                values: new object[] { false, "Cash", 88.3240467667574m, 30, 1 });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 1,
                column: "movie_start",
                value: new DateTime(2024, 3, 11, 22, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "movie_id", "movie_start" },
                values: new object[] { 1, new DateTime(2024, 3, 11, 22, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 3,
                column: "movie_start",
                value: new DateTime(2024, 3, 11, 22, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 4,
                column: "movie_start",
                value: new DateTime(2024, 3, 11, 22, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 5,
                column: "movie_start",
                value: new DateTime(2024, 3, 11, 22, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 6,
                column: "movie_start",
                value: new DateTime(2024, 3, 11, 22, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "movie_id", "movie_start" },
                values: new object[] { 1, new DateTime(2024, 3, 12, 1, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 8,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 9,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 10,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 11,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 12,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 1, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 13,
                columns: new[] { "movie_id", "movie_start" },
                values: new object[] { 1, new DateTime(2024, 3, 12, 0, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 14,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 0, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 15,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 0, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 16,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 0, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 17,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 0, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 18,
                column: "movie_start",
                value: new DateTime(2024, 3, 11, 22, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 19,
                columns: new[] { "movie_id", "movie_start" },
                values: new object[] { 1, new DateTime(2024, 3, 12, 19, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 20,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 19, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 21,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 19, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 22,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 19, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 23,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 19, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 24,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 19, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 25,
                columns: new[] { "movie_id", "movie_start" },
                values: new object[] { 1, new DateTime(2024, 3, 12, 19, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995) });

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 26,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 19, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 27,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 19, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 28,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 19, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 29,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 19, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 30,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 19, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 31,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 19, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 32,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 19, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 33,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 19, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 34,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 19, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 35,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 19, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));

            migrationBuilder.UpdateData(
                table: "screenings",
                keyColumn: "id",
                keyValue: 36,
                column: "movie_start",
                value: new DateTime(2024, 3, 12, 19, 28, 26, 424, DateTimeKind.Utc).AddTicks(6995));
        }
    }
}
