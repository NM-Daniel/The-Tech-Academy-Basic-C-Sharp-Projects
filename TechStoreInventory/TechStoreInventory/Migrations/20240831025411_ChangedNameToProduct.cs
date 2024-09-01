using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechStoreInventory.Migrations
{
    /// <inheritdoc />
    public partial class ChangedNameToProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Products",
                newName: "Product");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Product",
                table: "Products",
                newName: "Name");
        }
    }
}
