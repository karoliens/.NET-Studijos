using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewProps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RepairCategoryTicket_RepairCategories_RepairCategoriesId",
                table: "RepairCategoryTicket");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairCategoryTicket_Tickets_TicketsId",
                table: "RepairCategoryTicket");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Clients_ClientId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Devices_DeviceId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Technicians_TechnicianId",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_DeviceId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Devices",
                table: "Devices");

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Tickets",
                newName: "TicketId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Technicians",
                newName: "TechnicianId");

            migrationBuilder.RenameColumn(
                name: "TicketsId",
                table: "RepairCategoryTicket",
                newName: "TicketsTicketId");

            migrationBuilder.RenameColumn(
                name: "RepairCategoriesId",
                table: "RepairCategoryTicket",
                newName: "RepairCategoriesRepairCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_RepairCategoryTicket_TicketsId",
                table: "RepairCategoryTicket",
                newName: "IX_RepairCategoryTicket_TicketsTicketId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "RepairCategories",
                newName: "RepairCategoryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Devices",
                newName: "TicketId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clients",
                newName: "ClientId");

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
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .OldAnnotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddColumn<int>(
                name: "DeviceId",
                table: "Devices",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0)
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Devices",
                table: "Devices",
                column: "DeviceId");

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "DeviceId", "Model", "TicketId", "Type" },
                values: new object[,]
                {
                    { 1, "iPhone 7", 0, "Phone" },
                    { 2, "MacBook Pro", 0, "Laptop" }
                });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ClientId", "CreateDateTime", "DeviceId", "TechnicianId" },
                values: new object[] { 0, new DateTime(2023, 1, 12, 19, 34, 24, 545, DateTimeKind.Local).AddTicks(1186), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ClientId", "CreateDateTime", "DeviceId", "TechnicianId" },
                values: new object[] { 0, new DateTime(2023, 1, 12, 19, 34, 24, 545, DateTimeKind.Local).AddTicks(1228), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ClientId", "CreateDateTime", "DeviceId", "TechnicianId" },
                values: new object[] { 0, new DateTime(2023, 1, 12, 19, 34, 24, 545, DateTimeKind.Local).AddTicks(1230), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ClientId", "CreateDateTime", "DeviceId", "TechnicianId" },
                values: new object[] { 0, new DateTime(2023, 1, 12, 19, 34, 24, 545, DateTimeKind.Local).AddTicks(1233), 0, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Devices_TicketId",
                table: "Devices",
                column: "TicketId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Tickets_TicketId",
                table: "Devices",
                column: "TicketId",
                principalTable: "Tickets",
                principalColumn: "TicketId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairCategoryTicket_RepairCategories_RepairCategoriesRepairCategoryId",
                table: "RepairCategoryTicket",
                column: "RepairCategoriesRepairCategoryId",
                principalTable: "RepairCategories",
                principalColumn: "RepairCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairCategoryTicket_Tickets_TicketsTicketId",
                table: "RepairCategoryTicket",
                column: "TicketsTicketId",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Tickets_TicketId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairCategoryTicket_RepairCategories_RepairCategoriesRepairCategoryId",
                table: "RepairCategoryTicket");

            migrationBuilder.DropForeignKey(
                name: "FK_RepairCategoryTicket_Tickets_TicketsTicketId",
                table: "RepairCategoryTicket");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Clients_ClientId",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Technicians_TechnicianId",
                table: "Tickets");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Devices",
                table: "Devices");

            migrationBuilder.DropIndex(
                name: "IX_Devices_TicketId",
                table: "Devices");

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyColumnType: "INTEGER",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "DeviceId",
                keyColumnType: "INTEGER",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "DeviceId",
                table: "Devices");

            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "Tickets",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TechnicianId",
                table: "Technicians",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TicketsTicketId",
                table: "RepairCategoryTicket",
                newName: "TicketsId");

            migrationBuilder.RenameColumn(
                name: "RepairCategoriesRepairCategoryId",
                table: "RepairCategoryTicket",
                newName: "RepairCategoriesId");

            migrationBuilder.RenameIndex(
                name: "IX_RepairCategoryTicket_TicketsTicketId",
                table: "RepairCategoryTicket",
                newName: "IX_RepairCategoryTicket_TicketsId");

            migrationBuilder.RenameColumn(
                name: "RepairCategoryId",
                table: "RepairCategories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TicketId",
                table: "Devices",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ClientId",
                table: "Clients",
                newName: "Id");

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
                name: "Id",
                table: "Devices",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER")
                .Annotation("Sqlite:Autoincrement", true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Devices",
                table: "Devices",
                column: "Id");

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
                columns: new[] { "ClientId", "CreateDateTime", "DeviceId", "TechnicianId" },
                values: new object[] { null, new DateTime(2023, 1, 12, 18, 13, 52, 528, DateTimeKind.Local).AddTicks(1399), null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClientId", "CreateDateTime", "DeviceId", "TechnicianId" },
                values: new object[] { null, new DateTime(2023, 1, 12, 18, 13, 52, 528, DateTimeKind.Local).AddTicks(1437), null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClientId", "CreateDateTime", "DeviceId", "TechnicianId" },
                values: new object[] { null, new DateTime(2023, 1, 12, 18, 13, 52, 528, DateTimeKind.Local).AddTicks(1439), null, null });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ClientId", "CreateDateTime", "DeviceId", "TechnicianId" },
                values: new object[] { null, new DateTime(2023, 1, 12, 18, 13, 52, 528, DateTimeKind.Local).AddTicks(1441), null, null });

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_DeviceId",
                table: "Tickets",
                column: "DeviceId");

            migrationBuilder.AddForeignKey(
                name: "FK_RepairCategoryTicket_RepairCategories_RepairCategoriesId",
                table: "RepairCategoryTicket",
                column: "RepairCategoriesId",
                principalTable: "RepairCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RepairCategoryTicket_Tickets_TicketsId",
                table: "RepairCategoryTicket",
                column: "TicketsId",
                principalTable: "Tickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Clients_ClientId",
                table: "Tickets",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Devices_DeviceId",
                table: "Tickets",
                column: "DeviceId",
                principalTable: "Devices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Technicians_TechnicianId",
                table: "Tickets",
                column: "TechnicianId",
                principalTable: "Technicians",
                principalColumn: "Id");
        }
    }
}
