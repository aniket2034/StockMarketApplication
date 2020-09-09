using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StockMarketApp.AdminService.Migrations
{
    public partial class con : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Sector",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectorName = table.Column<string>(nullable: false),
                    Brief = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sector", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockExchange",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Brief = table.Column<string>(nullable: true),
                    ContactAddress = table.Column<string>(nullable: true),
                    Remarks = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockExchange", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
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
                    table.PrimaryKey("PK_users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: false),
                    Turnover = table.Column<decimal>(nullable: false),
                    CEO = table.Column<string>(nullable: true),
                    BoardOfDirectors = table.Column<string>(nullable: true),
                    Brief = table.Column<string>(nullable: true),
                    SectorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Company_Sector_SectorId",
                        column: x => x.SectorId,
                        principalTable: "Sector",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "IPODetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PricePerShare = table.Column<double>(nullable: false),
                    TotalNumberOfShares = table.Column<int>(nullable: false),
                    OpenDateTime = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    StockExchangeId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IPODetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IPODetails_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IPODetails_StockExchange_StockExchangeId",
                        column: x => x.StockExchangeId,
                        principalTable: "StockExchange",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockExchangeCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockExchangeId = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockExchangeCompanies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockExchangeCompanies_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockExchangeCompanies_StockExchange_StockExchangeId",
                        column: x => x.StockExchangeId,
                        principalTable: "StockExchange",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StockPrice",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentPrice = table.Column<decimal>(nullable: false),
                    Date = table.Column<string>(nullable: true),
                    Time = table.Column<string>(nullable: true),
                    CompanyId = table.Column<int>(nullable: false),
                    StockExchangeId = table.Column<string>(nullable: true),
                    StockExchangeCompaniesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockPrice", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockPrice_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StockPrice_StockExchangeCompanies_StockExchangeCompaniesId",
                        column: x => x.StockExchangeCompaniesId,
                        principalTable: "StockExchangeCompanies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StockPrice_StockExchange_StockExchangeId",
                        column: x => x.StockExchangeId,
                        principalTable: "StockExchange",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Company_SectorId",
                table: "Company",
                column: "SectorId");

            migrationBuilder.CreateIndex(
                name: "IX_IPODetails_CompanyId",
                table: "IPODetails",
                column: "CompanyId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IPODetails_StockExchangeId",
                table: "IPODetails",
                column: "StockExchangeId");

            migrationBuilder.CreateIndex(
                name: "IX_StockExchangeCompanies_CompanyId",
                table: "StockExchangeCompanies",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StockExchangeCompanies_StockExchangeId",
                table: "StockExchangeCompanies",
                column: "StockExchangeId");

            migrationBuilder.CreateIndex(
                name: "IX_StockPrice_CompanyId",
                table: "StockPrice",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_StockPrice_StockExchangeCompaniesId",
                table: "StockPrice",
                column: "StockExchangeCompaniesId");

            migrationBuilder.CreateIndex(
                name: "IX_StockPrice_StockExchangeId",
                table: "StockPrice",
                column: "StockExchangeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IPODetails");

            migrationBuilder.DropTable(
                name: "StockPrice");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "StockExchangeCompanies");

            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "StockExchange");

            migrationBuilder.DropTable(
                name: "Sector");
        }
    }
}
