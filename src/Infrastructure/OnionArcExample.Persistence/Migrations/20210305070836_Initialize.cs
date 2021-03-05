using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnionArcExample.Persistence.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { new Guid("7cbcbb36-3fcb-4f2f-99ee-f3e099e35ef9"), "Product 1 Description", "Product 1", 1000, 10 },
                    { new Guid("db98f2ca-0494-458d-a935-7926dd3ed4ba"), "Product 2 Description", "Product 2", 2000, 20 },
                    { new Guid("059d420a-2c8a-4c5a-a3bd-cfb5c2607113"), "Product 3 Description", "Product 3", 3000, 30 },
                    { new Guid("e98141d1-54ae-4e32-b9f3-278b132cf72b"), "Product 4 Description", "Product 4", 4000, 40 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
