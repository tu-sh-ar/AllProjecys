using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneToOne_Relation.Migrations
{
    public partial class ManyToManyConnection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Catagory",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catagory", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "BooksCatagory",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BooksCatagory", x => new { x.BookId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_BooksCatagory_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BooksCatagory_Catagory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Catagory",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BooksCatagory_CategoryId",
                table: "BooksCatagory",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BooksCatagory");

            migrationBuilder.DropTable(
                name: "Catagory");
        }
    }
}
