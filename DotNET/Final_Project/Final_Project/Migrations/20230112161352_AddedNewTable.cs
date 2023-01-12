using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairCategoryTicket_Tickets_TicketsTicketId",
                table: "RepairCategoryTicket");

            migrationBuilder.DropColumn(
                name: "TicketId",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "Tickets",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TicketsTicketId",
                table: "RepairCategoryTicket",
                newName: "TicketsId");

            migrationBuilder.RenameIndex(
                name: "IX_RepairCategoryTicket_TicketsTicketId",
                table: "RepairCategoryTicket",
                newName: "IX_RepairCategoryTicket_TicketsId");

            migrationBuilder.AddColumn<int>(
                name: "DeviceId",
                table: "Tickets",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Devices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devices", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "Model", "Type" },
                values: new object[,]
                {
                    { 1, "iPhone 7", "Phone" },
                    { 2, "MacBook Pro", "Laptop" }
                });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreateDateTime", "DeviceId" },
                values: new object[] { new DateTime(2023, 1, 12, 18, 13, 52, 528, DateTimeKind.Local).AddTicks(1399), null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreateDateTime", "DeviceId" },
                values: new object[] { new DateTime(2023, 1, 12, 18, 13, 52, 528, DateTimeKind.Local).AddTicks(1437), null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreateDateTime", "DeviceId" },
                values: new object[] { new DateTime(2023, 1, 12, 18, 13, 52, 528, DateTimeKind.Local).AddTicks(1439), null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreateDateTime", "DeviceId" },
                values: new object[] { new DateTime(2023, 1, 12, 18, 13, 52, 528, DateTimeKind.Local).AddTicks(1441), null });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_DeviceId",
                table: "Tickets",
                column: "DeviceId");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairCategoryTicket_Tickets_TicketsId",
                table: "RepairCategoryTicket",
                column: "TicketsId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Devices_DeviceId",
                table: "Tickets",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairCategoryTicket_Tickets_TicketsId",
                table: "RepairCategoryTicket");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Devices_DeviceId",
                table: "Tickets");

            migrationBuilder.DropTable(
                name: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_DeviceId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "DeviceId",
                table: "Tickets");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tickets",
                newName: "TicketId");

            migrationBuilder.RenameColumn(
                name: "TicketsId",
                table: "RepairCategoryTicket",
                newName: "TicketsTicketId");

            migrationBuilder.RenameIndex(
                name: "IX_RepairCategoryTicket_TicketsId",
                table: "RepairCategoryTicket",
                newName: "IX_RepairCategoryTicket_TicketsTicketId");

            migrationBuilder.AddColumn<int>(
                name: "TicketId",
                table: "Clients",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "TicketId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "TicketId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "TicketId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "TicketId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2023, 1, 11, 19, 11, 38, 574, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2023, 1, 11, 19, 11, 38, 574, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "CreateDateTime",
                value: new DateTime(2023, 1, 11, 19, 11, 38, 574, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "CreateDateTime",
                value: new DateTime(2023, 1, 11, 19, 11, 38, 574, DateTimeKind.Local).AddTicks(9369));

            migrationBuilder.AddForeignKey(
                name: "FK_RepairCategoryTicket_Tickets_TicketsTicketId",
                table: "RepairCategoryTicket",
                column: "TicketsTicketId",
                principalTable: "Tickets",
                principalColumn: "TicketId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
