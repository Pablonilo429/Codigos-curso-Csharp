﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class DepartmentForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_Departmentid",
                table: "Seller");

            migrationBuilder.AlterColumn<int>(
                name: "Departmentid",
                table: "Seller",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_Departmentid",
                table: "Seller",
                column: "Departmentid",
                principalTable: "Department",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seller_Department_Departmentid",
                table: "Seller");

            migrationBuilder.AlterColumn<int>(
                name: "Departmentid",
                table: "Seller",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Seller_Department_Departmentid",
                table: "Seller",
                column: "Departmentid",
                principalTable: "Department",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
