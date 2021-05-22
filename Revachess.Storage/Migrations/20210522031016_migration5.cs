using Microsoft.EntityFrameworkCore.Migrations;

namespace Revachess.Storage.Migrations
{
    public partial class migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Name", "Player1Id", "Player2Id", "WinnerId" },
                values: new object[] { 1L, "FedvsFred", null, null, null });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Name", "Player1Id", "Player2Id", "WinnerId" },
                values: new object[] { 2L, "fredvsFriday", null, null, null });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Name", "Player1Id", "Player2Id", "WinnerId" },
                values: new object[] { 3L, "SUNDAYvsSUNDAY", null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3L);
        }
    }
}
