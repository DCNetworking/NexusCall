using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nexus_connect.Migrations
{
    /// <inheritdoc />
    public partial class SetPriorityStatementImportant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Important",
                table: "Notification",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: 1685876651L);

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: 1685875651L);

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedTimestamp", "DisplayTimestamp", "Important" },
                values: new object[] { 1685876651L, 1685876651L, true });

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedTimestamp", "DisplayTimestamp", "Important" },
                values: new object[] { 1685876651L, 1685876681L, false });

            migrationBuilder.UpdateData(
                table: "Notification",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedTimestamp", "DisplayTimestamp", "Important" },
                values: new object[] { 1685875651L, 1685876651L, true });

            migrationBuilder.UpdateData(
                table: "Team",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimestamp",
                value: 1685876651L);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TicketCreatedTime", "TicketLastChangeTime" },
                values: new object[] { 1685876651L, 1685876651L });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TicketCreatedTime", "TicketLastChangeTime" },
                values: new object[] { 1685874851L, 1685874851L });

            migrationBuilder.UpdateData(
                table: "UserClient",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimestamp",
                value: 1685876651L);

            migrationBuilder.UpdateData(
                table: "UserClient",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTimestamp",
                value: 1685876651L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Important",
                table: "Notification");

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
    }
}
