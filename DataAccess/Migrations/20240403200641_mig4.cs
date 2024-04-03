using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_City_CityId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItemProduct_Product_ProductsId",
                table: "CartItemProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_District_City_CityId",
                table: "District");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Colors_ColorId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Gender_GenderId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_OrderDetail_OrderDetailId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Size_SizeId",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities");

            migrationBuilder.RenameIndex(
                name: "IX_Product_SizeId",
                table: "Products",
                newName: "IX_Products_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_OrderDetailId",
                table: "Products",
                newName: "IX_Products_OrderDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_GenderId",
                table: "Products",
                newName: "IX_Products_GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ColorId",
                table: "Products",
                newName: "IX_Products_ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_City_CountryId",
                table: "Cities",
                newName: "IX_Cities_CountryId");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId",
                table: "Products",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Cities_CityId",
                table: "Addresses",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItemProduct_Products_ProductsId",
                table: "CartItemProduct",
                column: "ProductsId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Country_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_District_Cities_CityId",
                table: "District",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Colors_ColorId",
                table: "Products",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Gender_GenderId",
                table: "Products",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_OrderDetail_OrderDetailId",
                table: "Products",
                column: "OrderDetailId",
                principalTable: "OrderDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Size_SizeId",
                table: "Products",
                column: "SizeId",
                principalTable: "Size",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Cities_CityId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItemProduct_Products_ProductsId",
                table: "CartItemProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Country_CountryId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_District_Cities_CityId",
                table: "District");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Colors_ColorId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Gender_GenderId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_OrderDetail_OrderDetailId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Size_SizeId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Products");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City");

            migrationBuilder.RenameIndex(
                name: "IX_Products_SizeId",
                table: "Product",
                newName: "IX_Product_SizeId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_OrderDetailId",
                table: "Product",
                newName: "IX_Product_OrderDetailId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_GenderId",
                table: "Product",
                newName: "IX_Product_GenderId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ColorId",
                table: "Product",
                newName: "IX_Product_ColorId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Product",
                newName: "IX_Product_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_CountryId",
                table: "City",
                newName: "IX_City_CountryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_City_CityId",
                table: "Addresses",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItemProduct_Product_ProductsId",
                table: "CartItemProduct",
                column: "ProductsId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_District_City_CityId",
                table: "District",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Categories_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Colors_ColorId",
                table: "Product",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Gender_GenderId",
                table: "Product",
                column: "GenderId",
                principalTable: "Gender",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_OrderDetail_OrderDetailId",
                table: "Product",
                column: "OrderDetailId",
                principalTable: "OrderDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Size_SizeId",
                table: "Product",
                column: "SizeId",
                principalTable: "Size",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
