using Microsoft.EntityFrameworkCore.Migrations;

namespace AlienZoo.Infrastructure.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Alien",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Age = table.Column<int>(nullable: false),
                    HandlerID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Color = table.Column<string>(nullable: true),
                    Origin = table.Column<string>(nullable: true),
                    AlienType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Alien_Person_HandlerID",
                        column: x => x.HandlerID,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Daniel" });

            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Mike" });

            migrationBuilder.InsertData(
                table: "Alien",
                columns: new[] { "Id", "Age", "AlienType", "Color", "HandlerID", "Name", "Origin" },
                values: new object[] { 1, 18, "Predator", null, 1, "Predator", null });

            migrationBuilder.InsertData(
                table: "Alien",
                columns: new[] { "Id", "Age", "AlienType", "Color", "HandlerID", "Name", "Origin" },
                values: new object[] { 2, 1, "Xenomorph", null, 1, "Mother", null });

            migrationBuilder.InsertData(
                table: "Alien",
                columns: new[] { "Id", "Age", "AlienType", "Color", "HandlerID", "Name", "Origin" },
                values: new object[] { 3, 250, "Wookiee", null, 2, "Tuggmacka", null });

            migrationBuilder.CreateIndex(
                name: "IX_Alien_HandlerID",
                table: "Alien",
                column: "HandlerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alien");

            migrationBuilder.DropTable(
                name: "Person");
        }
    }
}
