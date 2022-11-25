using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ORM_Trainer_1.Migrations
{
    public partial class mig_MotherFather_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FatherName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MotherName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FatherName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MotherName",
                table: "Users");
        }
    }
}
