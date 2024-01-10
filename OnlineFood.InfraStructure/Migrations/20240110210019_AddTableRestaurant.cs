using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineFood.InfraStructure.Migrations
{
    /// <inheritdoc />
    public partial class AddTableRestaurant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Banner = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagerFullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagerPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfBranches = table.Column<int>(type: "int", nullable: false),
                    IntroduceWay = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmByAdmin = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    DeliveryPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreditAccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinimumOrderPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AverangeDeliveryTime = table.Column<int>(type: "int", nullable: false),
                    Discount = table.Column<int>(type: "int", nullable: false),
                    SendToOutOfArea = table.Column<bool>(type: "bit", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Restaurant");
        }
    }
}
