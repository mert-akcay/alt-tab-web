using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _04_MVC_EFCore.Migrations
{
    /// <inheritdoc />
    public partial class KitapSayisiAddToYazar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KitapSayisi",
                table: "Yazar",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KitapSayisi",
                table: "Yazar");
        }
    }
}
