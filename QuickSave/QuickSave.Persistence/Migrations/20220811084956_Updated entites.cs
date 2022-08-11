using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace QuickSave.Persistence.Migrations
{
    public partial class Updatedentites : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_AspNetUsers_CostumerId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Submissions_AspNetUsers_CostumerId",
                table: "Submissions");

            migrationBuilder.DropIndex(
                name: "IX_Submissions_CostumerId",
                table: "Submissions");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_CostumerId",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Submissions");

            migrationBuilder.DropColumn(
                name: "IsPaid",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Invoices");

            migrationBuilder.AlterColumn<int>(
                name: "CostumerId",
                table: "Submissions",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CostumerId1",
                table: "Submissions",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfTransaction",
                table: "Invoices",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "CostumerId",
                table: "Invoices",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CostumerId1",
                table: "Invoices",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_CostumerId1",
                table: "Submissions",
                column: "CostumerId1");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CostumerId1",
                table: "Invoices",
                column: "CostumerId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_AspNetUsers_CostumerId1",
                table: "Invoices",
                column: "CostumerId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Submissions_AspNetUsers_CostumerId1",
                table: "Submissions",
                column: "CostumerId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_AspNetUsers_CostumerId1",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Submissions_AspNetUsers_CostumerId1",
                table: "Submissions");

            migrationBuilder.DropIndex(
                name: "IX_Submissions_CostumerId1",
                table: "Submissions");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_CostumerId1",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "CostumerId1",
                table: "Submissions");

            migrationBuilder.DropColumn(
                name: "CostumerId1",
                table: "Invoices");

            migrationBuilder.AlterColumn<string>(
                name: "CostumerId",
                table: "Submissions",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Submissions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateOfTransaction",
                table: "Invoices",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CostumerId",
                table: "Invoices",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<bool>(
                name: "IsPaid",
                table: "Invoices",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Submissions_CostumerId",
                table: "Submissions",
                column: "CostumerId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CostumerId",
                table: "Invoices",
                column: "CostumerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_AspNetUsers_CostumerId",
                table: "Invoices",
                column: "CostumerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Submissions_AspNetUsers_CostumerId",
                table: "Submissions",
                column: "CostumerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
