﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtStudio.Migrations
{
    public partial class Update9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountOfDownload",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountOfDownload",
                table: "AspNetUsers");
        }
    }
}
