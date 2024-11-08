using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TodoServerApp.Migrations
{
    /// <inheritdoc />
    public partial class add_performeritem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idPerformer",
                table: "TaskItems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PerformerItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pantronymic = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PerformerItems", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "PerformerItems",
                columns: new[] { "Id", "Name", "Pantronymic", "Surname" },
                values: new object[,]
                {
                    { 1, "Кирилл", "Андреевич", "Корнилов" },
                    { 2, "Лев", "Данилович", "Яковлев" },
                    { 3, "Игорь", "Степанович", "Калугин" },
                    { 4, "Давид", "Львович", "Иванов" }
                });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "idPerformer" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 32, 17, 451, DateTimeKind.Local).AddTicks(3399), 1 });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "idPerformer" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 32, 17, 451, DateTimeKind.Local).AddTicks(3411), null });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "idPerformer" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 32, 17, 451, DateTimeKind.Local).AddTicks(3413), 3 });

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "idPerformer" },
                values: new object[] { new DateTime(2024, 10, 25, 19, 32, 17, 451, DateTimeKind.Local).AddTicks(3414), null });

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_idPerformer",
                table: "TaskItems",
                column: "idPerformer");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_PerformerItems_idPerformer",
                table: "TaskItems",
                column: "idPerformer",
                principalTable: "PerformerItems",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_PerformerItems_idPerformer",
                table: "TaskItems");

            migrationBuilder.DropTable(
                name: "PerformerItems");

            migrationBuilder.DropIndex(
                name: "IX_TaskItems_idPerformer",
                table: "TaskItems");

            migrationBuilder.DropColumn(
                name: "idPerformer",
                table: "TaskItems");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TaskItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 9, 18, 17, 32, 154, DateTimeKind.Local).AddTicks(7395));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 9, 18, 17, 32, 154, DateTimeKind.Local).AddTicks(7407));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 9, 18, 17, 32, 154, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "TaskItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 10, 9, 18, 17, 32, 154, DateTimeKind.Local).AddTicks(7409));
        }
    }
}
