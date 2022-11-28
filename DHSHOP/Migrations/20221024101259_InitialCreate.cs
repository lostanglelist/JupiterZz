using Microsoft.EntityFrameworkCore.Migrations;

namespace DHSHOP.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ProductId = table.Column<string>(nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ProductPrice = table.Column<double>(type: "float", nullable: false),
                    ProductDetail = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    ProductImage = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ProductId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
