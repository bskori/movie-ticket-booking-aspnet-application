using Microsoft.EntityFrameworkCore.Migrations;

namespace BookMyMovie.Migrations
{
    public partial class RenamedallmodelIdstoId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProducerID",
                table: "Producers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MovieID",
                table: "Movies",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CinemaID",
                table: "Cinemas",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Producers",
                newName: "ProducerID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Movies",
                newName: "MovieID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cinemas",
                newName: "CinemaID");
        }
    }
}
