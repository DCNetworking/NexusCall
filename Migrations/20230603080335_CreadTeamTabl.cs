using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace nexus_connect.Migrations
{
    /// <inheritdoc />
    public partial class CreadTeamTabl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "AspNetUsers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Uid = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedUid = table.Column<string>(type: "TEXT", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedTimestamp = table.Column<long>(type: "INTEGER", nullable: false),
                    LastChangeTimestamp = table.Column<long>(type: "INTEGER", nullable: false),
                    Cid = table.Column<int>(type: "INTEGER", nullable: false),
                    CidOther = table.Column<string>(type: "json", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: 1685779415L);

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: 1685778415L);

            migrationBuilder.InsertData(
                table: "Team",
                columns: new[] { "Id", "Cid", "CidOther", "CreatedTimestamp", "CreatedUid", "LastChangeTimestamp", "Name", "Status", "Uid" },
                values: new object[] { 1, 1, null, 1685779415L, "53c8d500-2936-4aa6-8d38-f3b03c34c903", 0L, "Alfa Delta Team", 1, "53c8d500-2936-4aa6-8d38-f3b03c34c903" });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TicketCreatedTime", "TicketLastChangeTime" },
                values: new object[] { 1685779415L, 1685779415L });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TicketCreatedTime", "TicketLastChangeTime" },
                values: new object[] { 1685777615L, 1685777615L });

            migrationBuilder.UpdateData(
                table: "UserClient",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimestamp",
                value: 1685779415L);

            migrationBuilder.UpdateData(
                table: "UserClient",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTimestamp",
                value: 1685779415L);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTime",
                value: 1685653356L);

            migrationBuilder.UpdateData(
                table: "Client",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTime",
                value: 1685652356L);

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TicketCreatedTime", "TicketLastChangeTime" },
                values: new object[] { 1685653356L, 1685653356L });

            migrationBuilder.UpdateData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TicketCreatedTime", "TicketLastChangeTime" },
                values: new object[] { 1685651556L, 1685651556L });

            migrationBuilder.UpdateData(
                table: "UserClient",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedTimestamp",
                value: 1685653356L);

            migrationBuilder.UpdateData(
                table: "UserClient",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedTimestamp",
                value: 1685653356L);
        }
    }
}
