using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactsCore.Migrations
{
    public partial class AddPersonTypePerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonTypeId",
                table: "Person",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PersonType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonType", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Person_PersonTypeId",
                table: "Person",
                column: "PersonTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Person_PersonType_PersonTypeId",
                table: "Person",
                column: "PersonTypeId",
                principalTable: "PersonType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Person_PersonType_PersonTypeId",
                table: "Person");

            migrationBuilder.DropTable(
                name: "PersonType");

            migrationBuilder.DropIndex(
                name: "IX_Person_PersonTypeId",
                table: "Person");

            migrationBuilder.DropColumn(
                name: "PersonTypeId",
                table: "Person");
        }
    }
}
