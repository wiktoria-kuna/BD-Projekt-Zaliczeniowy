using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Biblioteka.Migrations
{
    /// <inheritdoc />
    public partial class DbUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "CategoryEntityId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryEntityId",
                table: "Books",
                column: "CategoryEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Categories_CategoryEntityId",
                table: "Books",
                column: "CategoryEntityId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Categories_CategoryEntityId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Books_CategoryEntityId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "CategoryEntityId",
                table: "Books");

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Książki o przerażających historiach, duchach i nadprzyrodzonych wydarzeniach.", "Horror" },
                    { 2, "Literatura pełna magii, mitologii i wyimaginowanych światów.", "Fantastyka" },
                    { 3, "Historie o detektywach, tajemnicach i zagadkach kryminalnych.", "Kryminał" },
                    { 4, "Opowieści o miłości, relacjach i emocjach.", "Romans" },
                    { 5, "Książki o przyszłości, technologii i kosmosie.", "Science Fiction" },
                    { 6, "Życiorysy znanych osób, opowiadające o ich życiu i osiągnięciach.", "Biografia" },
                    { 7, "Powieści osadzone w przeszłości, często z elementami historycznymi.", "Historyczna" },
                    { 8, "Książki pełne akcji, odkryć i ekscytujących podróży.", "Przygodowa" },
                    { 9, "Historie pełne napięcia, z zaskakującymi zwrotami akcji.", "Thriller" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "CategoryId", "Description", "Title" },
                values: new object[] { 1, "Stephen King", 1, "Akcja powieści rozgrywa się w hotelu Panorama (ang. The Overlook), położonym wysoko w górach, gdzie Jack Torrance z żoną i małym synkiem ma zostać na zimę, by go doglądać. Jack ma duże problemy ze sobą i swoją twórczością (jest pisarzem), a jego syn Danny ma zdolności parapsychiczne (zdolność lśnienia), dzięki którym widzi wiele makabrycznych scen, odgrywających się przed laty w opuszczonym hotelu. Obaj wraz z ojcem wyczuwają, że w Panoramie nie są sami.", "Lśnienie" });
        }
    }
}
