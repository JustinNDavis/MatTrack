using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MatTrack.Migrations
{
    public partial class AddedEventTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UpcomingEvents",
                columns: table => new
                {
                    UpcomingEventsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    EventSummary = table.Column<string>(nullable: true),
                    EventPrice = table.Column<float>(nullable: false),
                    EventDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UpcomingEvents", x => x.UpcomingEventsID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UpcomingEvents");
        }
    }
}
