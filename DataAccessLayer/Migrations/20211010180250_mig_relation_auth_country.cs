using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_relation_auth_country : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountryID",
                table: "Authors",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_Countries_CountryID",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_CountryID",
                table: "Authors");

            migrationBuilder.DropColumn(
                name: "CountryID",
                table: "Authors");
        }
    }
}
