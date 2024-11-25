using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorEcommerce.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ChangeSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "gx");

            migrationBuilder.RenameTable(
                name: "ProductVariants",
                newName: "ProductVariants",
                newSchema: "gx");

            migrationBuilder.RenameTable(
                name: "ProductTypes",
                newName: "ProductTypes",
                newSchema: "gx");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Products",
                newSchema: "gx");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Orders",
                newSchema: "gx");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "OrderItems",
                newSchema: "gx");

            migrationBuilder.RenameTable(
                name: "Images",
                newName: "Images",
                newSchema: "gx");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Categories",
                newSchema: "gx");

            migrationBuilder.RenameTable(
                name: "CartItems",
                newName: "CartItems",
                newSchema: "gx");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Addresses",
                newSchema: "gx");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "ProductVariants",
                schema: "gx",
                newName: "ProductVariants");

            migrationBuilder.RenameTable(
                name: "ProductTypes",
                schema: "gx",
                newName: "ProductTypes");

            migrationBuilder.RenameTable(
                name: "Products",
                schema: "gx",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Orders",
                schema: "gx",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                schema: "gx",
                newName: "OrderItems");

            migrationBuilder.RenameTable(
                name: "Images",
                schema: "gx",
                newName: "Images");

            migrationBuilder.RenameTable(
                name: "Categories",
                schema: "gx",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "CartItems",
                schema: "gx",
                newName: "CartItems");

            migrationBuilder.RenameTable(
                name: "Addresses",
                schema: "gx",
                newName: "Addresses");
        }
    }
}
