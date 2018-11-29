using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WeatherForecast.Migrations
{
    public partial class InitialMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeatherForecastItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(nullable: false),
                    TemperatureInCelsius = table.Column<int>(nullable: false),
                    TemperatureInFahrenheit = table.Column<int>(nullable: false),
                    Summary = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherForecastItem", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "WeatherForecastItem",
                columns: new[] { "Id", "Date", "Summary", "TemperatureInCelsius", "TemperatureInFahrenheit" },
                values: new object[] { 1, new DateTime(2018, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Scorching", 32, 89 });

            migrationBuilder.InsertData(
                table: "WeatherForecastItem",
                columns: new[] { "Id", "Date", "Summary", "TemperatureInCelsius", "TemperatureInFahrenheit" },
                values: new object[] { 2, new DateTime(2018, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mild", 45, 112 });

            migrationBuilder.InsertData(
                table: "WeatherForecastItem",
                columns: new[] { "Id", "Date", "Summary", "TemperatureInCelsius", "TemperatureInFahrenheit" },
                values: new object[] { 3, new DateTime(2018, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mild", -4, 25 });

            migrationBuilder.InsertData(
                table: "WeatherForecastItem",
                columns: new[] { "Id", "Date", "Summary", "TemperatureInCelsius", "TemperatureInFahrenheit" },
                values: new object[] { 4, new DateTime(2018, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Balmy", 16, 60 });

            migrationBuilder.InsertData(
                table: "WeatherForecastItem",
                columns: new[] { "Id", "Date", "Summary", "TemperatureInCelsius", "TemperatureInFahrenheit" },
                values: new object[] { 5, new DateTime(2018, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hot", 53, 127 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherForecastItem");
        }
    }
}
