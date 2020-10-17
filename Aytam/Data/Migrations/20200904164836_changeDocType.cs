using Microsoft.EntityFrameworkCore.Migrations;

namespace Aytam.Data.Migrations
{
    public partial class changeDocType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Documents_DocumentType_TypeID",
                table: "Documents");

            migrationBuilder.DropTable(
                name: "DocumentType");

            migrationBuilder.DropIndex(
                name: "IX_Documents_TypeID",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "TypeID",
                table: "Documents");

            migrationBuilder.AddColumn<int>(
                name: "Type_ID",
                table: "Documents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type_Notes",
                table: "Documents",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type_Type",
                table: "Documents",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type_ID",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "Type_Notes",
                table: "Documents");

            migrationBuilder.DropColumn(
                name: "Type_Type",
                table: "Documents");

            migrationBuilder.AddColumn<int>(
                name: "TypeID",
                table: "Documents",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DocumentType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    Type = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentType", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Documents_TypeID",
                table: "Documents",
                column: "TypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Documents_DocumentType_TypeID",
                table: "Documents",
                column: "TypeID",
                principalTable: "DocumentType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
