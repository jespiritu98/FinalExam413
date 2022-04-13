using Microsoft.EntityFrameworkCore.Migrations;

namespace FinalExam413.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Quotes",
                columns: table => new
                {
                    QuoteId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Quote = table.Column<string>(nullable: false),
                    Author = table.Column<string>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    Subject = table.Column<string>(nullable: true),
                    Citation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quotes", x => x.QuoteId);
                });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "QuoteId", "Author", "Citation", "Date", "Quote", "Subject" },
                values: new object[] { 1, "Lao Tzu", "https://www.keepinspiring.me/famous-quotes/", "Unknown", "The journey of a thousand miles begins with one step.", "Inspiration" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "QuoteId", "Author", "Citation", "Date", "Quote", "Subject" },
                values: new object[] { 2, "Buddha", "https://wisdomquotes.com/famous-quotes/", "Unknown", "All that we are is the result of what we have thought.", "Inspiration" });

            migrationBuilder.InsertData(
                table: "Quotes",
                columns: new[] { "QuoteId", "Author", "Citation", "Date", "Quote", "Subject" },
                values: new object[] { 3, "Spencer", "My memory", "Several Ocassions", "Are you ready? Are you ready? Let's go to war.", "Inspiration" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Quotes");
        }
    }
}
