using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Garden_Helper_Site.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Plant",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    water_interval = table.Column<int>(type: "int", nullable: false),
                    time_till_water = table.Column<int>(type: "int", nullable: false),
                    fertilizer_interval = table.Column<int>(type: "int", nullable: true),
                    time_till_fertilizer = table.Column<int>(type: "int", nullable: true),
                    maintenance_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maintenance_interval = table.Column<int>(type: "int", nullable: true),
                    time_till_maintenance = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    plant_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    growing = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plant", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Plant");
        }
    }
}
