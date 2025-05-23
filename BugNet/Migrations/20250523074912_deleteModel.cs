using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BugNet.Migrations
{
    /// <inheritdoc />
    public partial class deleteModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteTime",
                table: "Bugs",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDelete",
                table: "Bugs",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteTime",
                table: "Bugs");

            migrationBuilder.DropColumn(
                name: "IsDelete",
                table: "Bugs");
        }
    }
}
