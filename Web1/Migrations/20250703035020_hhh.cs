using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web1.Migrations
{
    /// <inheritdoc />
    public partial class hhh : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsNone",
                table: "partners");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "partners",
                type: "varchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "partners",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsNoneDesktop",
                table: "partners",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsNoneMobile",
                table: "partners",
                type: "tinyint(1)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsNoneTablet",
                table: "partners",
                type: "tinyint(1)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "partners");

            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "partners");

            migrationBuilder.DropColumn(
                name: "IsNoneDesktop",
                table: "partners");

            migrationBuilder.DropColumn(
                name: "IsNoneMobile",
                table: "partners");

            migrationBuilder.DropColumn(
                name: "IsNoneTablet",
                table: "partners");

            migrationBuilder.AddColumn<bool>(
                name: "IsNone",
                table: "partners",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }
    }
}
