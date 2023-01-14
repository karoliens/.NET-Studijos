using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class RemovedDeviceId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeviceId",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                column: "CreateDateTime",
                value: new DateTime(2023, 1, 14, 10, 28, 9, 835, DateTimeKind.Local).AddTicks(7970));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                column: "CreateDateTime",
                value: new DateTime(2023, 1, 14, 10, 28, 9, 835, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                column: "CreateDateTime",
                value: new DateTime(2023, 1, 14, 10, 28, 9, 835, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                column: "CreateDateTime",
                value: new DateTime(2023, 1, 14, 10, 28, 9, 835, DateTimeKind.Local).AddTicks(8009));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeviceId",
                table: "Tickets",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "CreateDateTime", "DeviceId" },
                values: new object[] { new DateTime(2023, 1, 14, 10, 10, 24, 360, DateTimeKind.Local).AddTicks(3687), null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "CreateDateTime", "DeviceId" },
                values: new object[] { new DateTime(2023, 1, 14, 10, 10, 24, 360, DateTimeKind.Local).AddTicks(3720), null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "CreateDateTime", "DeviceId" },
                values: new object[] { new DateTime(2023, 1, 14, 10, 10, 24, 360, DateTimeKind.Local).AddTicks(3722), null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "CreateDateTime", "DeviceId" },
                values: new object[] { new DateTime(2023, 1, 14, 10, 10, 24, 360, DateTimeKind.Local).AddTicks(3723), null });
        }
    }
}
