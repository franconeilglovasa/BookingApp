using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookingApp.Migrations
{
    /// <inheritdoc />
    public partial class addbooking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PassengerName = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Date = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    Time = table.Column<string>(type: "TEXT", maxLength: 10, nullable: false),
                    PickupLocation = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    DropoffLocation = table.Column<string>(type: "TEXT", maxLength: 200, nullable: false),
                    Distance = table.Column<float>(type: "REAL", nullable: false),
                    Fare = table.Column<float>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingId);
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "BookingId", "Date", "Distance", "DropoffLocation", "Fare", "PassengerName", "PickupLocation", "Time" },
                values: new object[] { 1, "9/10/2024", 10f, "Boss R", 205f, "BenKen", "NU Baliwag", "10:00 AM" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");
        }
    }
}
