using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kudapoyti.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Hello : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserEmail",
                table: "Comments");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserEmail",
                table: "Comments",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
