using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bernardo___ENTPROG___OTIS1.Migrations
{
    public partial class TestCaseF1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateModified",
                table: "SuppliersINV",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "SuppliersINV",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValueSql: "getutcdate()");

            migrationBuilder.CreateTable(
                name: "ProductsINV",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductsINV", x => x.ProductID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductsINV");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateModified",
                table: "SuppliersINV",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "SuppliersINV",
                type: "datetime2",
                nullable: true,
                defaultValueSql: "getutcdate()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
