using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nexus_connect.Migrations
{
    /// <inheritdoc />
    public partial class ReloadDtbAddedFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Permission",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: 1685479164L);

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: 1685478164L);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TicketCreatedTime", "TicketLastChangeTime" },
                values: new object[] { 1685479164L, 1685479164L });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TicketCreatedTime", "TicketLastChangeTime" },
                values: new object[] { 1685477364L, 1685477364L });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Permission",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: 1685307066L);

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: 1685306066L);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TicketCreatedTime", "TicketLastChangeTime" },
                values: new object[] { 1685307066L, 1685307066L });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TicketCreatedTime", "TicketLastChangeTime" },
                values: new object[] { 1685305266L, 1685305266L });
        }
    }
}
