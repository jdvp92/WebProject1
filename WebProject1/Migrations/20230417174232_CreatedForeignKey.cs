using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebProject1.Migrations
{
    public partial class CreatedForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "Department",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "Seller",
                table: "SalesRecord");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Seller",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "Seller",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "SalesRecord",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SellerId",
                table: "SalesRecord",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesRecord_ProductId",
                table: "SalesRecord",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SalesRecord_SellerId",
                table: "SalesRecord",
                column: "SellerId");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Product_ProductId",
                table: "SalesRecord",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Product_ProductId",
                table: "SalesRecord");

            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropIndex(
                name: "IX_SalesRecord_ProductId",
                table: "SalesRecord");

            migrationBuilder.DropIndex(
                name: "IX_SalesRecord_SellerId",
                table: "SalesRecord");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Seller");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "SalesRecord");

            migrationBuilder.DropColumn(
                name: "SellerId",
                table: "SalesRecord");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Seller",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Department",
                table: "Seller",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Seller",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Seller",
                table: "SalesRecord",
                nullable: true);
        }
    }
}
