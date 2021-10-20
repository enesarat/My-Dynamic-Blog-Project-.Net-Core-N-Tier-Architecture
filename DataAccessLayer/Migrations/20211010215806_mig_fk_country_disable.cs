using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_fk_country_disable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Countries_CountryID",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_CountryID",
                table: "Authors");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Authors_CountryID",
                table: "Authors",
                column: "CountryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_Countries_CountryID",
                table: "Authors",
                column: "CountryID",
                principalTable: "Countries",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
