using Microsoft.EntityFrameworkCore.Migrations;

namespace _11_LayoutPagesTemplateGiydirme.Migrations
{
    public partial class CategoryListingReleations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Listing",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Listing_CategoryID",
                table: "Listing",
                column: "CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Listing_Categories_CategoryID",
                table: "Listing",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Listing_Categories_CategoryID",
                table: "Listing");

            migrationBuilder.DropIndex(
                name: "IX_Listing_CategoryID",
                table: "Listing");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Listing");
        }
    }
}
