using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiLucasFlix.Migrations
{
    public partial class ligacao2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "enderecos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enderecos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "cinema",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EnderecoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cinema", x => x.Id);
                    table.ForeignKey(
                        name: "FK_cinema_enderecos_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "enderecos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_cinema_EnderecoId",
                table: "cinema",
                column: "EnderecoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cinema");

            migrationBuilder.DropTable(
                name: "enderecos");
        }
    }
}
