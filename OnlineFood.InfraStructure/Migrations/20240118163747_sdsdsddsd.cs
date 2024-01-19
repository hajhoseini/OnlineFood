using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFood.InfraStructure.Migrations
{
    /// <inheritdoc />
    public partial class sdsdsddsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Customer");

            migrationBuilder.CreateTable(
                name: "UsersAddresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UId = table.Column<int>(type: "int", nullable: false),
                    AId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersAddresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersAddresses_Address_AId",
                        column: x => x.AId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UsersAddresses_Customer_UId",
                        column: x => x.UId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersAddresses_AId",
                table: "UsersAddresses",
                column: "AId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersAddresses_UId",
                table: "UsersAddresses",
                column: "UId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsersAddresses");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Restaurant",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Customer",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
