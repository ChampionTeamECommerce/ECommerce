using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig36 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_OperationClaims_OperationClaimId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_OperationClaimId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OperationClaimId",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "OperationClaimId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Users_OperationClaimId",
                table: "Users",
                column: "OperationClaimId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_OperationClaims_OperationClaimId",
                table: "Users",
                column: "OperationClaimId",
                principalTable: "OperationClaims",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
