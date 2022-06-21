using Microsoft.EntityFrameworkCore.Migrations;

namespace Bank_Db_Class_Library.Migrations
{
    public partial class AddSoftDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "TransactionAccountConnection",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Transaction",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Request",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Person",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Card_Reader",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Card",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Branch",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Bank_Worker",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Bank",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Account",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "TransactionAccountConnection");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Transaction");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Request");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Card_Reader");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Card");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Branch");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Bank_Worker");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Bank");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Account");
        }
    }
}
