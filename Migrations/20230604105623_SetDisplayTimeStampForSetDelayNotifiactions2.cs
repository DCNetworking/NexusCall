using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nexus_connect.Migrations
{
    /// <inheritdoc />
    public partial class SetDisplayTimeStampForSetDelayNotifiactions2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: 1685876183L);

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: 1685875183L);

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "DisplayTimestamp" },
                values: new object[] { 1685876183L, 1685876183L });

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "DisplayTimestamp" },
                values: new object[] { 1685876183L, 1685876213L });

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "DisplayTimestamp" },
                values: new object[] { 1685875183L, 1685876183L });

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimestamp",
                value: 1685876183L);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TicketCreatedTime", "TicketLastChangeTime" },
                values: new object[] { 1685876183L, 1685876183L });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TicketCreatedTime", "TicketLastChangeTime" },
                values: new object[] { 1685874383L, 1685874383L });

            migrationBuilder.UpdateData(
                table: "UserClient",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimestamp",
                value: 1685876183L);

            migrationBuilder.UpdateData(
                table: "UserClient",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTimestamp",
                value: 1685876183L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
