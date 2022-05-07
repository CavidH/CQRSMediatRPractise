using Microsoft.EntityFrameworkCore.Migrations;

namespace CQRSMediatRPractise.Migrations
{
    public partial class cr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    HP = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "HP", "Name", "Weight" },
                values: new object[,]
                {
                    { 1, 1.5, "Lada", 1.5 },
                    { 2, 2.5, "nissan", 2.5 },
                    { 3, 3.5, "toyota", 3.5 },
                    { 4, 4.5, "ford", 4.5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
