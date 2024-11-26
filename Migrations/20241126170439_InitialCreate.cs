using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Labb1Restaurant.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Accounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FoodPrice = table.Column<double>(type: "float", nullable: false),
                    IsPopular = table.Column<bool>(type: "bit", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableSeats = table.Column<int>(type: "int", nullable: false),
                    TableNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tables", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuestAttending = table.Column<int>(type: "int", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingStart = table.Column<TimeSpan>(type: "time", nullable: false),
                    BookingEnd = table.Column<TimeSpan>(type: "time", nullable: false),
                    FK_CustomerId = table.Column<int>(type: "int", nullable: false),
                    FK_TableId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_FK_CustomerId",
                        column: x => x.FK_CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_Tables_FK_TableId",
                        column: x => x.FK_TableId,
                        principalTable: "Tables",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "hallu.kevin@outlook.com", "hallu", "kevin", "070623454" },
                    { 2, "Robz.muuu@hotmail.com", "Robz", "Mori", "070583722" },
                    { 3, "syntia.lulu@yahoo.com", "synthia", "lulu", "0707263534" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "FoodInfo", "FoodName", "FoodPrice", "IsAvailable", "IsPopular" },
                values: new object[,]
                {
                    { 1, "Homemade pasta Alfredo.", "Pasta Alfredo", 155.0, true, true },
                    { 2, "Big Ass Pizza For You.", "Pizza", 270.0, true, true },
                    { 3, "Perfect Made Lasagne.", "Lasagne", 180.0, true, false },
                    { 4, "A Freash sallad with tuna", "Sallad", 135.0, true, false },
                    { 5, "Served with mashed potatoes.", "minute steak", 210.0, true, true },
                    { 6, "Homemade hamburger with fries.", "Hamburger", 185.0, true, false },
                    { 7, "Babyfood for your baby", "babyfood", 380.0, true, true }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "Id", "TableNumber", "TableSeats" },
                values: new object[,]
                {
                    { 1, 1, 4 },
                    { 2, 2, 4 },
                    { 3, 3, 6 },
                    { 4, 4, 6 },
                    { 5, 5, 8 },
                    { 6, 6, 8 }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "BookingDate", "BookingEnd", "BookingStart", "FK_CustomerId", "FK_TableId", "GuestAttending" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 19, 0, 0, 0), new TimeSpan(0, 18, 0, 0, 0), 1, 1, 2 },
                    { 2, new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 21, 0, 0, 0), new TimeSpan(0, 20, 0, 0, 0), 2, 2, 4 },
                    { 3, new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 22, 0, 0, 0), new TimeSpan(0, 21, 0, 0, 0), 3, 3, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_FK_CustomerId",
                table: "Bookings",
                column: "FK_CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_FK_TableId",
                table: "Bookings",
                column: "FK_TableId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accounts");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Tables");
        }
    }
}
