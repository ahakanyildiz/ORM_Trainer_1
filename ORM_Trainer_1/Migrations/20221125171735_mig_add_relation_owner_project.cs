using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ORM_Trainer_1.Migrations
{
    public partial class mig_add_relation_owner_project : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Projects_OwnerID",
                table: "Projects",
                column: "OwnerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Owners_OwnerID",
                table: "Projects",
                column: "OwnerID",
                principalTable: "Owners",
                principalColumn: "OwnerID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Owners_OwnerID",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_OwnerID",
                table: "Projects");
        }
    }
}
