using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace nexus_connect.Migrations
{
    /// <inheritdoc />
    public partial class CreateTicketEnitity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ticket",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RelId = table.Column<int>(type: "INTEGER", nullable: false),
                    TicketCreatedTime = table.Column<long>(type: "INTEGER", nullable: false),
                    TicketEndTime = table.Column<long>(type: "INTEGER", nullable: false),
                    TicketLastChangeTime = table.Column<long>(type: "INTEGER", nullable: false),
                    Cid = table.Column<int>(type: "INTEGER", nullable: false),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: true),
                    TicketCaseType = table.Column<int>(type: "INTEGER", nullable: false),
                    LogHistory = table.Column<string>(type: "json", nullable: false),
                    UserId = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ticket", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ticket_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Ticket_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: 1685297679L);

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: 1685296679L);

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Cid", "ClientId", "LogHistory", "RelId", "TicketCaseType", "TicketCreatedTime", "TicketEndTime", "TicketLastChangeTime", "UserId" },
                values: new object[,]
                {
                    { 1, 1, null, "", 0, 3, 1685297679L, 0L, 1685297679L, null },
                    { 2, 1, null, "", 0, 2, 1685295879L, 0L, 1685295879L, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_ClientId",
                table: "Ticket",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Ticket_UserId",
                table: "Ticket",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ticket");

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: 1685282182L);

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: 1685281182L);
        }
    }
}
