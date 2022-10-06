using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TagsService.DataContext.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    HexColor = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubTag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: true),
                    TagId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TagModelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTag", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubTag_Tag_TagModelId",
                        column: x => x.TagModelId,
                        principalTable: "Tag",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "SubTag",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "TagId", "TagModelId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, true, "SubTag example 1 - tag 1", 1, null, null },
                    { 2, null, true, "SubTag example 2 - tag 1", 1, null, null },
                    { 3, null, true, "SubTag example 3 - tag 1", 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "CreatedAt", "Description", "HexColor", "Image", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, "Desciption example 1...", "#1B999B", null, true, "Tag example 1", null },
                    { 2, null, "Desciption example 2...", "#ED217C", null, true, "Tag example 2", null },
                    { 3, null, "Desciption example 3...", "#55DDFF", null, true, "Tag example 3", null },
                    { 4, null, "Desciption example 4...", "#FFFD82", null, true, "Tag example 4", null },
                    { 5, null, "Desciption example 5...", "#FF9B71", null, true, "Tag example 5", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubTag_TagModelId",
                table: "SubTag",
                column: "TagModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubTag");

            migrationBuilder.DropTable(
                name: "Tag");
        }
    }
}
