using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelExpertsData.Migrations
{
    /// <inheritdoc />
    public partial class CustomerPackage14 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerPackage",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    PackageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerPackage", x => new { x.CustomerId, x.PackageId });
                    table.ForeignKey(
                        name: "FK_CustomerPackage_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerPackage_Packages_PackageId",
                        column: x => x.PackageId,
                        principalTable: "Packages",
                        principalColumn: "PackageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerPackage_PackageId",
                table: "CustomerPackage",
                column: "PackageId");
        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CustomerPackage_Customers_CustomerId",
                table: "CustomerPackage");

            migrationBuilder.DropForeignKey(
                name: "FK_CustomerPackage_Packages_PackageId",
                table: "CustomerPackage");

            migrationBuilder.RenameColumn(
                name: "PackageId",
                table: "CustomerPackage",
                newName: "PackagesPackageId");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "CustomerPackage",
                newName: "CustomersCustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_CustomerPackage_PackageId",
                table: "CustomerPackage",
                newName: "IX_CustomerPackage_PackagesPackageId");

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerPackage_Customers_CustomersCustomerId",
                table: "CustomerPackage",
                column: "CustomersCustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CustomerPackage_Packages_PackagesPackageId",
                table: "CustomerPackage",
                column: "PackagesPackageId",
                principalTable: "Packages",
                principalColumn: "PackageId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
