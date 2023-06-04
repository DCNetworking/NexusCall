using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nexus_connect.Migrations
{
    /// <inheritdoc />
    public partial class SetDisplayTimeStampForSetDelayNotifiactions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DisplayTimestamp",
                table: "Notification",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: 1685875782L);

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: 1685874782L);

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "DisplayTimestamp" },
                values: new object[] { 1685875782L, 1685875782L });

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "DisplayTimestamp" },
                values: new object[] { 1685875782L, 1685875812L });

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "DisplayTimestamp" },
                values: new object[] { 1685874782L, 1685875782L });

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimestamp",
                value: 1685875782L);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TicketCreatedTime", "TicketLastChangeTime" },
                values: new object[] { 1685875782L, 1685875782L });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TicketCreatedTime", "TicketLastChangeTime" },
                values: new object[] { 1685873982L, 1685873982L });

            migrationBuilder.UpdateData(
                table: "UserClient",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimestamp",
                value: 1685875782L);

            migrationBuilder.UpdateData(
                table: "UserClient",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTimestamp",
                value: 1685875782L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayTimestamp",
                table: "Notification");

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: 1685874466L);

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: 1685873466L);

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimestamp",
                value: 1685874466L);

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTimestamp",
                value: 1685874466L);

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedTimestamp",
                value: 1685873466L);

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimestamp",
                value: 1685874466L);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TicketCreatedTime", "TicketLastChangeTime" },
                values: new object[] { 1685874466L, 1685874466L });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TicketCreatedTime", "TicketLastChangeTime" },
                values: new object[] { 1685872666L, 1685872666L });

            migrationBuilder.UpdateData(
                table: "UserClient",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimestamp",
                value: 1685874466L);

            migrationBuilder.UpdateData(
                table: "UserClient",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTimestamp",
                value: 1685874466L);
        }
    }
}
