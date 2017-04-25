using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CheeseMVC.Migrations
{
    public partial class secondTryItemMenu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheeseMenus_Menu_MenuID",
                table: "CheeseMenus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menu",
                table: "Menu");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menus",
                table: "Menu",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CheeseMenus_Menus_MenuID",
                table: "CheeseMenus",
                column: "MenuID",
                principalTable: "Menu",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "Menu",
                newName: "Menus");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CheeseMenus_Menus_MenuID",
                table: "CheeseMenus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Menus",
                table: "Menus");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Menu",
                table: "Menus",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_CheeseMenus_Menu_MenuID",
                table: "CheeseMenus",
                column: "MenuID",
                principalTable: "Menus",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.RenameTable(
                name: "Menus",
                newName: "Menu");
        }
    }
}
