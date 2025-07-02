using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Web1.Migrations
{
    /// <inheritdoc />
    public partial class cuu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsNone",
                table: "posts",
                type: "tinyint(1)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsNone",
                table: "posts");
        }
    }
}
