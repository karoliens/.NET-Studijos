using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FinalProject.Migrations
{
    /// <inheritdoc />
    public partial class AddedNewTablesAndProps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RepairCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Technicians",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicians", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ClientId = table.Column<int>(type: "INTEGER", nullable: true),
                    TechnicianId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketId);
                    table.ForeignKey(
                        name: "FK_Tickets_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Tickets_Technicians_TechnicianId",
                        column: x => x.TechnicianId,
                        principalTable: "Technicians",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RepairCategoryTicket",
                columns: table => new
                {
                    RepairCategoriesId = table.Column<int>(type: "INTEGER", nullable: false),
                    TicketsTicketId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairCategoryTicket", x => new { x.RepairCategoriesId, x.TicketsTicketId });
                    table.ForeignKey(
                        name: "FK_RepairCategoryTicket_RepairCategories_RepairCategoriesId",
                        column: x => x.RepairCategoriesId,
                        principalTable: "RepairCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RepairCategoryTicket_Tickets_TicketsTicketId",
                        column: x => x.TicketsTicketId,
                        principalTable: "Tickets",
                        principalColumn: "TicketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Email", "Name", "PhoneNumber", "TicketId" },
                values: new object[,]
                {
                    { 1, "karoliens@gmail.com", "Karolis", "+37061212121", 1 },
                    { 2, "ievuzis@gmail.com", "Ieva", "+37061252121", 2 },
                    { 3, "tomukas@gmail.com", "Tomas", "+37061212128", 3 },
                    { 4, "sauliens@gmail.com", "Saulius", "+37061215121", 4 }
                });

            migrationBuilder.InsertData(
                table: "RepairCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Data Recovery" },
                    { 2, "Screen Replacement" },
                    { 3, "Batery Replacement" },
                    { 4, "Logic Board Repair" }
                });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Karolis" },
                    { 2, "Artūras" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "ClientId", "CreateDateTime", "Description", "TechnicianId", "UpdateDateTime" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2023, 1, 11, 18, 52, 18, 159, DateTimeKind.Local).AddTicks(8240), "Reikia pakeisti iPhone 7 ekraną", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, null, new DateTime(2023, 1, 11, 18, 52, 18, 159, DateTimeKind.Local).AddTicks(8279), "Reikia pakeisti iPhone X bateriją", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, null, new DateTime(2023, 1, 11, 18, 52, 18, 159, DateTimeKind.Local).AddTicks(8282), "Reikia pakeisti SAMSUNG S20 ekraną", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, null, new DateTime(2023, 1, 11, 18, 52, 18, 159, DateTimeKind.Local).AddTicks(8284), "Reikia perlituoti PS5 pultelio krovimo lizdą", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RepairCategoryTicket_TicketsTicketId",
                table: "RepairCategoryTicket",
                column: "TicketsTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ClientId",
                table: "Tickets",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TechnicianId",
                table: "Tickets",
                column: "TechnicianId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RepairCategoryTicket");

            migrationBuilder.DropTable(
                name: "RepairCategories");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Technicians");
        }
    }
}
