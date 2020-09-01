using Microsoft.EntityFrameworkCore.Migrations;

namespace StockMarketApp.AuthService.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(maxLength: 30, nullable: false),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
                    UserType = table.Column<int>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 30, nullable: true),
                    Mobile = table.Column<long>(maxLength: 30, nullable: false),
                    Confirmed = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
