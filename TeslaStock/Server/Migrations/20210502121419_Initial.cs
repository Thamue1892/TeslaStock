using Microsoft.EntityFrameworkCore.Migrations;

namespace TeslaStock.Server.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pagination",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    limit = table.Column<int>(type: "int", nullable: false),
                    offset = table.Column<int>(type: "int", nullable: false),
                    count = table.Column<int>(type: "int", nullable: false),
                    total = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagination", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StockData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paginationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StockData_Pagination_paginationId",
                        column: x => x.paginationId,
                        principalTable: "Pagination",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Datum",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    open = table.Column<float>(type: "real", nullable: false),
                    high = table.Column<float>(type: "real", nullable: false),
                    low = table.Column<float>(type: "real", nullable: false),
                    close = table.Column<float>(type: "real", nullable: false),
                    volume = table.Column<float>(type: "real", nullable: false),
                    adj_high = table.Column<float>(type: "real", nullable: true),
                    adj_low = table.Column<float>(type: "real", nullable: true),
                    adj_close = table.Column<float>(type: "real", nullable: false),
                    adj_open = table.Column<float>(type: "real", nullable: true),
                    adj_volume = table.Column<float>(type: "real", nullable: true),
                    split_factor = table.Column<float>(type: "real", nullable: false),
                    symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    exchange = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StockDataId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datum", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Datum_StockData_StockDataId",
                        column: x => x.StockDataId,
                        principalTable: "StockData",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Datum_StockDataId",
                table: "Datum",
                column: "StockDataId");

            migrationBuilder.CreateIndex(
                name: "IX_StockData_paginationId",
                table: "StockData",
                column: "paginationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Datum");

            migrationBuilder.DropTable(
                name: "StockData");

            migrationBuilder.DropTable(
                name: "Pagination");
        }
    }
}
