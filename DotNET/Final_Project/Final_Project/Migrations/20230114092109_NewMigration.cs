using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class NewMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DeviceId",
                table: "Tickets",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 1,
                column: "Imei",
                value: 123456789111111.0);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 2,
                column: "Imei",
                value: 123456789111118.0);

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "TechnicianId", "Name" },
                values: new object[] { 3, "Armandas" });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "CreateDateTime", "DeviceId" },
                values: new object[] { new DateTime(2023, 1, 14, 11, 21, 9, 5, DateTimeKind.Local).AddTicks(8715), null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "CreateDateTime", "DeviceId" },
                values: new object[] { new DateTime(2023, 1, 14, 11, 21, 9, 5, DateTimeKind.Local).AddTicks(8749), null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "CreateDateTime", "DeviceId" },
                values: new object[] { new DateTime(2023, 1, 14, 11, 21, 9, 5, DateTimeKind.Local).AddTicks(8751), null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "CreateDateTime", "DeviceId" },
                values: new object[] { new DateTime(2023, 1, 14, 11, 21, 9, 5, DateTimeKind.Local).AddTicks(8752), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Technicians",
                keyColumn: "TechnicianId",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "DeviceId",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 1,
                column: "Imei",
                value: 0.0);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 2,
                column: "Imei",
                value: 0.0);

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
    }
}
