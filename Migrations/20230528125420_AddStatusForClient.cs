using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nexus_connect.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusForClient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Client",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTime", "Status" },
                values: new object[] { 1685278460L, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Client");

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: 1685276646L);
        }
    }
}
