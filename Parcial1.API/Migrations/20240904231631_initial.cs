using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Parcial1.API.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Presidente = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Tesorero = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Secretario = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Vocal1 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Vocal2 = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Members_Presidente",
                table: "Members",
                column: "Presidente",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
