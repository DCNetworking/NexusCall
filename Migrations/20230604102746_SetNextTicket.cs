using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nexus_connect.Migrations
{
    /// <inheritdoc />
    public partial class SetNextTicket : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Notification",
                columns: new[] { "Id", "Cid", "CreatedTimestamp", "CreatedUid", "Message", "ReadedTimeStamp", "Title", "Uid" },
                values: new object[] { 3, 2, 1685873466L, "53c8d500-2936-4aa6-8d38-f3b03c34c903", "Make a Better Git Commits - Webinar", 0L, "Webinar : Git can be better", "53c8d500-2936-4aa6-8d38-f3b03c34c903" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: 1685817129L);

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: 1685816129L);

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimestamp",
                value: 1685817129L);

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTimestamp",
                value: 1685817129L);

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimestamp",
                value: 1685817129L);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TicketCreatedTime", "TicketLastChangeTime" },
                values: new object[] { 1685817129L, 1685817129L });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TicketCreatedTime", "TicketLastChangeTime" },
                values: new object[] { 1685815329L, 1685815329L });

            migrationBuilder.UpdateData(
                table: "UserClient",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimestamp",
                value: 1685817129L);

            migrationBuilder.UpdateData(
                table: "UserClient",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTimestamp",
                value: 1685817129L);
        }
    }
}
