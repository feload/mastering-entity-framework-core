using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContactsCore.Migrations
{
    public partial class AddPersonHeighIsActiveBirthdateFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "People",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "People",
                maxLength: 35,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "People",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "Height",
                table: "People",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "People",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "People");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "People");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "People");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "People",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 35);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "People",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 35);
        }
    }
}
