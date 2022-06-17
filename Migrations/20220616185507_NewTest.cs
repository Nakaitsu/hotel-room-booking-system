using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prototype.Migrations
{
    public partial class NewTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Rooms",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Rooms",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Rooms",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "Children",
                table: "Rooms",
                newName: "children_cap");

            migrationBuilder.RenameColumn(
                name: "Beds",
                table: "Rooms",
                newName: "beds_cap");

            migrationBuilder.RenameColumn(
                name: "Adults",
                table: "Rooms",
                newName: "adults_cap");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "Rooms",
                type: "nvarchar(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "description",
                table: "Rooms",
                type: "nvarchar(1000)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Daily",
                table: "Rooms",
                type: "decimal(8,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)");

            migrationBuilder.AddColumn<string>(
                name: "Localization",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Rate",
                table: "Rooms",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SquareFeet",
                table: "Rooms",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Localization",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "SquareFeet",
                table: "Rooms");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Rooms",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Rooms",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Rooms",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "children_cap",
                table: "Rooms",
                newName: "Children");

            migrationBuilder.RenameColumn(
                name: "beds_cap",
                table: "Rooms",
                newName: "Beds");

            migrationBuilder.RenameColumn(
                name: "adults_cap",
                table: "Rooms",
                newName: "Adults");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Rooms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Daily",
                table: "Rooms",
                type: "decimal(8,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)",
                oldNullable: true);
        }
    }
}
