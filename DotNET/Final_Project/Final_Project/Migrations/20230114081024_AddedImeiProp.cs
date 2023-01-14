using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class AddedImeiProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Tickets_TicketId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Clients_ClientId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Technicians_TechnicianId",
                table: "Tickets");

            migrationBuilder.AlterColumn<int>(
                name: "TechnicianId",
                table: "Tickets",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "DeviceId",
                table: "Tickets",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Tickets",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AlterColumn<int>(
                name: "TicketId",
                table: "Devices",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<double>(
                name: "Imei",
                table: "Devices",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 1,
                columns: new[] { "Imei", "TicketId" },
                values: new object[] { 0.0, null });

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 2,
                columns: new[] { "Imei", "TicketId" },
                values: new object[] { 0.0, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ClientId", "CreateDateTime", "DeviceId", "TechnicianId" },
                values: new object[] { null, new DateTime(2023, 1, 14, 10, 10, 24, 360, DateTimeKind.Local).AddTicks(3687), null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ClientId", "CreateDateTime", "DeviceId", "TechnicianId" },
                values: new object[] { null, new DateTime(2023, 1, 14, 10, 10, 24, 360, DateTimeKind.Local).AddTicks(3720), null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ClientId", "CreateDateTime", "DeviceId", "TechnicianId" },
                values: new object[] { null, new DateTime(2023, 1, 14, 10, 10, 24, 360, DateTimeKind.Local).AddTicks(3722), null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ClientId", "CreateDateTime", "DeviceId", "TechnicianId" },
                values: new object[] { null, new DateTime(2023, 1, 14, 10, 10, 24, 360, DateTimeKind.Local).AddTicks(3723), null, null });

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Tickets_TicketId",
                table: "Devices",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "TicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Clients_ClientId",
                table: "Tickets",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Technicians_TechnicianId",
                table: "Tickets",
                column: "TechnicianId",
                principalTable: "Technicians",
                principalColumn: "TechnicianId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Tickets_TicketId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Clients_ClientId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Technicians_TechnicianId",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Imei",
                table: "Devices");

            migrationBuilder.AlterColumn<int>(
                name: "TechnicianId",
                table: "Tickets",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DeviceId",
                table: "Tickets",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Tickets",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TicketId",
                table: "Devices",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 1,
                column: "TicketId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyValue: 2,
                column: "TicketId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ClientId", "CreateDateTime", "DeviceId", "TechnicianId" },
                values: new object[] { 0, new DateTime(2023, 1, 12, 19, 44, 54, 308, DateTimeKind.Local).AddTicks(7523), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ClientId", "CreateDateTime", "DeviceId", "TechnicianId" },
                values: new object[] { 0, new DateTime(2023, 1, 12, 19, 44, 54, 308, DateTimeKind.Local).AddTicks(7561), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ClientId", "CreateDateTime", "DeviceId", "TechnicianId" },
                values: new object[] { 0, new DateTime(2023, 1, 12, 19, 44, 54, 308, DateTimeKind.Local).AddTicks(7564), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ClientId", "CreateDateTime", "DeviceId", "TechnicianId" },
                values: new object[] { 0, new DateTime(2023, 1, 12, 19, 44, 54, 308, DateTimeKind.Local).AddTicks(7567), 0, 0 });

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Tickets_TicketId",
                table: "Devices",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "TicketId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Clients_ClientId",
                table: "Tickets",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "ClientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Technicians_TechnicianId",
                table: "Tickets",
                column: "TechnicianId",
                principalTable: "Technicians",
                principalColumn: "TechnicianId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
