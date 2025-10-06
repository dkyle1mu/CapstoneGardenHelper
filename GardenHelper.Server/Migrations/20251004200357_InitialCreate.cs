using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GardenHelper.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Garden",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WaterInterval = table.Column<int>(type: "INTEGER", nullable: false),
                    TimeTillWater = table.Column<int>(type: "INTEGER", nullable: false),
                    FertilizerInterval = table.Column<int>(type: "INTEGER", nullable: true),
                    TimeTillFertilizer = table.Column<int>(type: "INTEGER", nullable: true),
                    MaintenanceType = table.Column<string>(type: "TEXT", nullable: true),
                    MaintenanceInterval = table.Column<int>(type: "INTEGER", nullable: true),
                    TimeTillMaintenance = table.Column<int>(type: "INTEGER", nullable: true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    PlantedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Growing = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garden", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Garden");
        }
    }
}
