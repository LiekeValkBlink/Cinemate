using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Cinemate.API.Migrations
{
    /// <inheritdoc />
    public partial class ChangedMovieCastColumnName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cast",
                table: "movies",
                newName: "actor_cast");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "actor_cast",
                table: "movies",
                newName: "cast");
        }
    }
}
