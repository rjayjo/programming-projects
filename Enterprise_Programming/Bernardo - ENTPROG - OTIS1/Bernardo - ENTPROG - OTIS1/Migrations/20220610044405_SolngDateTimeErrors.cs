using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bernardo___ENTPROG___OTIS1.Migrations
{
    public partial class SolngDateTimeErrors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuppliersINV",
                columns: table => new
                {
                    SupplierID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    Representative = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ContactNo = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getutcdate()"),
                    DateModified = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "getutcdate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuppliersINV", x => x.SupplierID);
                });
            migrationBuilder.Sql(
 @"CREATE TRIGGER [dbo].[SuppliersINV_UPDATE] ON [dbo].[SuppliersINV]
    AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    IF ((SELECT TRIGGER_NESTLEVEL()) > 1) RETURN;

    DECLARE @SupplierID INT

    SELECT @SupplierID = INSERTED.SupplierID
    FROM INSERTED

    UPDATE dbo.SuppliersINV
    SET DateModified = GETUTCDATE()
    WHERE SupplierID = @SupplierID
END");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuppliersINV");
        }
    }
}
