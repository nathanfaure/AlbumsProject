using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace AipBlog.DAL.Migrations
{
    public partial class AddUsersToChatGroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ChartGroups",
                table: "ChartGroups");

            migrationBuilder.RenameTable(
                name: "ChartGroups",
                newName: "ChatGroups");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChatGroups",
                table: "ChatGroups",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "ChatGroupToUsers",
                columns: table => new
                {
                    ChatGroupId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatGroupToUsers", x => new { x.ChatGroupId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ChatGroupToUsers_ChatGroups_ChatGroupId",
                        column: x => x.ChatGroupId,
                        principalTable: "ChatGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChatGroupToUsers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChatGroupToUsers_UserId",
                table: "ChatGroupToUsers",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChatGroupToUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChatGroups",
                table: "ChatGroups");

            migrationBuilder.RenameTable(
                name: "ChatGroups",
                newName: "ChartGroups");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChartGroups",
                table: "ChartGroups",
                column: "Id");
        }
    }
}
